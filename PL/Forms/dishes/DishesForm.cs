using chef.BLL.Entities;
using chef.BLL.Services;
using chef.BLL.Validators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace chef
{
    public partial class DishesForm : Form
    {
        private readonly IDishService _dishService;

        private readonly DishesAddEditForm _addForm;
        private readonly DishesAddEditForm _editForm;
        private readonly DishesDetailsForm _detailsForm;
        private readonly DishesFilterForm _filterForm;
        private readonly DishesSortForm _sortForm;

        private bool isSearched = false;

        public DishesForm(IDishService dishService)
        {
            InitializeComponent();

            _dishService = dishService;

            _addForm = new DishesAddEditForm(_dishService, false);
            _editForm = new DishesAddEditForm(_dishService, true);
            _detailsForm = new DishesDetailsForm(_dishService);
            _filterForm = new DishesFilterForm(FillDishesTable, _dishService);
            _sortForm = new DishesSortForm(FillDishesTable);
        }

        private void DishesForm_Load(object sender, EventArgs e)
        {
            FillDishesTable();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                _editForm.FillWithDishData(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
                _editForm.ShowDialog();
                FillDishesTable();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _addForm.ShowDialog();
            FillDishesTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var dish = new Dish
                {
                    Id = (int)dataGridView.SelectedRows[0].Cells[0].Value,
                    Name = (string)dataGridView.SelectedRows[0].Cells[1].Value
                };

                var (canDelete, error) = _dishService.CanDeleteDish(dish);

                if (!canDelete)
                {
                    MessageBox.Show(error, "Видалення", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show($"Ви дійсно бажаєте видалити страву \"{dataGridView.SelectedRows[0].Cells[1].Value}\"?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                _dishService.DeleteDish(dish.Id);

                FillDishesTable();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            isSearched = !isSearched;

            searchButton.FlatAppearance.BorderColor = isSearched ? Color.Blue : Color.FromArgb(64, 0, 0);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            if (!isSearched)
            {
                errorProvider.Clear();
                return;
            }

            if (!SearchTextBox_Validate())
            {
                return;
            }

            var foundDishes = _dishService.GetDishesByName(searchTextBox.Text).ToList();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var dishId = (int)row.Cells[0].Value;

                if (foundDishes.Exists(x => x.Id == dishId))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(227, 105, 15);
                }
            }
        }

        private void FillDishesTable()
        {
            var dishes = _dishService.GetDishes(
                new List<string>
                {
                    _filterForm.MenuStatement,
                    _filterForm.PriceStatement,
                    _filterForm.CookingTimeStatement,
                    _filterForm.PortionsStatement,
                    _filterForm.WeightStatement,
                    _filterForm.EnergyStatement,
                },
                new List<string>
                {
                    _sortForm.CookingTimeStatement,
                    _sortForm.NameStatement,
                    _sortForm.PortionsStatement,
                    _sortForm.PriceStatement,
                    _sortForm.WeightStatement
                });

            dataGridView.Rows.Clear();

            foreach (var dish in dishes)
            {
                var row = new DataGridViewRow();

                row.Cells.AddRange(
                    new DataGridViewTextBoxCell { Value = dish.Id },
                    new DataGridViewTextBoxCell { Value = dish.Name },
                    new DataGridViewTextBoxCell { Value = dish.Portions },
                    new DataGridViewTextBoxCell { Value = dish.CookingTimeInMinutes },
                    new DataGridViewTextBoxCell { Value = dish.Weight },
                    new DataGridViewTextBoxCell { Value = dish.MenuSection },
                    new DataGridViewTextBoxCell { Value = dish.Price },
                    new DataGridViewTextBoxCell { Value = dish.EnergyCategory }
                );

                dataGridView.Rows.Add(row);
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var dishId = (int)dataGridView.SelectedRows[0].Cells[0].Value;

                _detailsForm.FillWithData(dishId);
                _detailsForm.ShowDialog();

                FillDishesTable();
            }
        }

        private bool SearchTextBox_Validate()
        {
            var (isValid, error) = TextValidator.Validate(searchTextBox.Text);

            errorProvider.SetError(searchTextBox, error);

            return isValid;
        }

        private void DishesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _filterForm.Close();
            _sortForm.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            _filterForm.Show();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            _sortForm.Show();
        }
    }
}