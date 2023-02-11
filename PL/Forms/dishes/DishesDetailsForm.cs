using chef.BLL.Services;
using System;
using System.Windows.Forms;

namespace chef
{
    public partial class DishesDetailsForm : Form
    {
        private int _dishId;
        private DishCardForm _dishCardForm;

        private readonly IDishService _dishService;

        private DishCardForm DishCardForm
        {
            get
            {
                if (_dishCardForm == null)
                {
                    _dishCardForm = new DishCardForm(_dishId, _dishService);
                }
                return _dishCardForm;
            }
        }

        public DishesDetailsForm(IDishService dishService)
        {
            InitializeComponent();

            _dishService = dishService;
        }

        public void FillWithData(int dishId)
        {
            _dishId = dishId;

            var dish = _dishService.GetDishById(dishId);

            dish_nameTextBox.Text = dish.Name;
            dish_portionsTextBox.Text = dish.Portions.ToString();
            cooking_timeTextBox.Text = dish.CookingTimeInMinutes.ToString();
            massTextBox.Text = dish.Weight.ToString();
            recipeTextBox.Text = dish.Recipe;
            menu_sectionTextBox.Text = dish.MenuSection;
            dish_priceTextBox.Text = dish.Price.ToString();

            dataGridView.Rows.Clear();

            for (int i = 0; i < dish.Ingredients.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = dish.Ingredients[i].ProductType.Name;
                dataGridView.Rows[i].Cells[1].Value = dish.Ingredients[i].AmountInUnits;
                dataGridView.Rows[i].Cells[2].Value = dish.Ingredients[i].ProductType.UnitsOfMeasurement;
            }

            DishCardForm.FillWithData(dishId);
        }

        private void ShowDishCard_Click(object sender, EventArgs e)
        {
            DishCardForm.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DishesDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
