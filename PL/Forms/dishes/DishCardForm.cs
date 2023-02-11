using chef.BLL.DTOs;
using chef.BLL.Services;
using System;
using System.Windows.Forms;

namespace chef
{
    public partial class DishCardForm : Form
    {
        private DishCardDTO _dishCardDTO;
        private readonly IDishService _dishService;

        public DishCardForm(int dishId, IDishService dishService)
        {
            InitializeComponent();

            _dishService = dishService;

            FillWithData(dishId);
        }

        public void FillWithData(int dishId)
        {
            var dish = _dishService.GetDishCardDataById(dishId);

            _dishCardDTO = dish;

            dish_nameLabel.Text = "Найменування страви " + dish.DishName;
            massLabel.Text = "Вага готової страви " + dish.Weight + " г";

            dataGridView.Rows.Clear();

            foreach (var ingredient in dish.Ingredients)
            {
                dataGridView.Rows.Add(ingredient.Name,
                    ingredient.AmountInUnits,
                    ingredient.UnitsOfMeasurement,
                    ingredient.ProteinsInGrams,
                    ingredient.FatsInGrams,
                    ingredient.CarbohydratesInGrams,
                    ingredient.Calories);
            }

            dataGridView.Rows.Add();
            dataGridView.Rows.Add("", "", "Підсумок:",
                dish.TotalProteinsInGrams,
                dish.TotalFatsInGrams,
                dish.TotalCarbohydratesInGrams,
                dish.TotalCalories);
        }

        private void SaveDocument_Click(object sender, EventArgs e)
        {

            saveFileDialog.Filter = "MS Word files(*.docx)|*.docx";
            saveFileDialog.FileName = $"Розкладка '{_dishCardDTO.DishName}'.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            _dishService.SaveDishCard(_dishCardDTO, saveFileDialog.FileName);

            Cursor.Current = Cursors.Default;

            MessageBox.Show("Документ успішно збережено!");

            System.Diagnostics.Process.Start(saveFileDialog.FileName);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DishCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
