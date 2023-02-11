using chef.BLL.Entities;
using chef.BLL.Services;
using chef.BLL.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace chef
{
    public partial class DishesAddEditForm : Form
    {
        private readonly bool _isUpdateMode;

        private int _dishId;
        private bool _isDataSaved = false;
        private int _indexOfLastEditedCell = 0;

        private readonly IDishService _dishService;
        private IEnumerable<ProductType> _productTypes = new List<ProductType>();

        public DishesAddEditForm(IDishService dishService, bool isUpdateMode)
        {
            InitializeComponent();

            _dishService = dishService;
            _isUpdateMode = isUpdateMode;

            FillProductTypesComboBox();

            dataGridView.Columns[3].DefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = Color.FromArgb(207, 46, 5),
                Font = new Font("Calibri", 14, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            
            saveButon.Text = _isUpdateMode ? "Зберегти" : "Додати";
            Text = _isUpdateMode ? "Редагування страви" : "Додавання страви";

            AutoValidate = AutoValidate.Disable;
        }

        public void FillWithDishData(int dishId)
        {
            _dishId = dishId;

            var dish = _dishService.GetDishById(_dishId);

            dishNameTextBox.Text = dish.Name;
            weightTextBox.Text = dish.Weight.ToString();
            recipeTextBox.Text = dish.Recipe;
            dishPriceTextBox.Text = dish.Price.ToString();
            cookingTimeTextBox.Text = dish.CookingTimeInMinutes.ToString();
            menuSectionComboBox.Text = dish.MenuSection;
            dishPortionsTextBox.Text = dish.Portions.ToString();

            dataGridView.Rows.Clear();

            for (int i = 0; i < dish.Ingredients.Count; i++)
            {
                dataGridView.Rows.Add();

                var row = dataGridView.Rows[i];
                var ingredient = dish.Ingredients[i];

                row.Cells[0].Value = ingredient.ProductType.Id;
                row.Cells[1].Value = ingredient.AmountInUnits;
                row.Cells[2].Value = ingredient.ProductType.UnitsOfMeasurement;
            }
        }

        private void SaveButon_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            var dish = new Dish
            {
                Id = _dishId,
                Name = dishNameTextBox.Text,
                Portions = (int)dishPortionsTextBox.Value,
                Recipe = recipeTextBox.Text,
                MenuSection = menuSectionComboBox.SelectedItem.ToString(),
                Price = dishPriceTextBox.Value,
                Weight = (int)weightTextBox.Value,
                CookingTimeInMinutes = (int)cookingTimeTextBox.Value,
                Ingredients = new List<Ingredient>()
            };

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dish.Ingredients.Add(new Ingredient
                {
                    ProductTypeId = (int)dataGridView.Rows[i].Cells[0].Value,
                    AmountInUnits = float.Parse(dataGridView.Rows[i].Cells[1].Value.ToString())
                });
            }

            if (_isUpdateMode)
            {
                _dishService.UpdateDish(dish);
            }
            else
            {
                _dishService.CreateDish(dish);
            }

            _isDataSaved = true;

            Hide();
        }



        private void DishesAddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (_isDataSaved)
            {
                Hide();
                return;
            }

            var message = $"Ви дійсно бажаєте закрити це вікно? В такому разі ваші зміни не буде збережено.";

            var isAgreeWithClosing = MessageBox.Show(message, "Вихід", MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (isAgreeWithClosing)
            {
                Hide();
            }
        }

        private void FillProductTypesComboBox()
        {
            _productTypes = _dishService.GetAllProductTypes();

            var column = (DataGridViewComboBoxColumn)dataGridView.Columns[0];

            column.DataSource = _productTypes;
            column.DisplayMember = "Name";
            column.ValueMember = "Id";
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                _indexOfLastEditedCell = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editedRow = dataGridView.Rows[e.RowIndex];

            if (e.ColumnIndex != 0 || editedRow.Cells[0].Value == null)
            {
                return;
            }

            var typeId = Convert.ToInt32(editedRow.Cells[0].Value);

            //Визначення одиниці вимірювання
            editedRow.Cells[2].Value = _productTypes.First(x => x.Id == typeId).UnitsOfMeasurement;

            //Пошук дублікатів
            int counter = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == typeId)
                {
                    if (counter > 1)
                    {
                        MessageBox.Show("Інгредієнт, який ви намагаєтесь обрати, вже присутній в страві", "", MessageBoxButtons.OK);

                        if (_indexOfLastEditedCell == 0)
                        {
                            editedRow.Cells[0].Value = null;
                            return;
                        }

                        editedRow.Cells[0].Value = _indexOfLastEditedCell;
                        break;
                    }

                    counter++;
                }
            }


            var isRowValid = editedRow.Cells[0].Value != null
                && editedRow.Cells[1].Value != null
                && float.TryParse(editedRow.Cells[1].Value.ToString(), out _);

            editedRow.Cells[3].Value = isRowValid ? string.Empty : "*";


            CheckAndShowDataGridValidity();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null)
                {
                    return;
                }
            }

            dataGridView.Rows.Add();
            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[3].Value = "*";

            CheckAndShowDataGridValidity();
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
            }

            CheckAndShowDataGridValidity();
        }

        private void DishNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            var (isValid, error) = TextValidator.Validate(dishNameTextBox.Text);

            e.Cancel = !isValid;
            errorProvider1.SetError(dishNameTextBox, error);
        }

        private void MenuSectionComboBox_Validating(object sender, CancelEventArgs e)
        {
            var isInvalid = menuSectionComboBox.SelectedIndex == -1;

            e.Cancel = isInvalid;

            errorProvider1.SetError(menuSectionComboBox,
                isInvalid ? "Оберіть один з варіантів розділу меню" : string.Empty);
        }

        private void DataGridView_Validating(object sender, CancelEventArgs e)
        {
            if (IsDataGridInvalid())
            {
                e.Cancel = true;

                MessageBox.Show("Неможливо зберегти страву, адже серед доданих інгредієнтів присутні хибні дані", "", MessageBoxButtons.OK);
                
                return;
            }

            e.Cancel = false;
        }

        private void CheckAndShowDataGridValidity()
        {
            warningLabel.Visible = IsDataGridInvalid();
        }

        private bool IsDataGridInvalid()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[3].Value != null
                    && !row.Cells[3].Value.ToString().Equals(string.Empty))
                {
                    return true;
                }
            }
            return false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
