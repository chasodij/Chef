using chef.BLL.Services;
using System;
using System.Windows.Forms;
using static chef.DAL.Delegates;

namespace chef
{
    public partial class dishes_Filter_Form : Form
    {
        private readonly Action _updateDataTable;

        private readonly int _maxPortions;
        private readonly int _maxCookingTime;
        private readonly int _maxWeight;
        private readonly float _maxPrice;

        public string MenuSection => GetStringParameter(menu_sectionComboBox, menuSectionCheckBox.Checked);

        public string EnergyCategory => GetStringParameter(energy_categoryComboBox, energyCategoryCheckBox.Checked);

        public int MinPortions => GetNumberParameter(portions1TextBox.Text, 0, portionsCheckBox.Checked, int.TryParse);

        public int MaxPortions => GetNumberParameter(portions2TextBox.Text, _maxPortions, portionsCheckBox.Checked, int.TryParse);

        public int MinCookingTime => GetNumberParameter(cookingTime1.Text, 0, cookingTimeCheckBox.Checked, int.TryParse);

        public int MaxCookingTime => GetNumberParameter(cookingTime2.Text, _maxCookingTime, cookingTimeCheckBox.Checked, int.TryParse);

        public int MinWeight => GetNumberParameter(weight1.Text, 0, weightCheckBox.Checked, int.TryParse);

        public int MaxWeight => GetNumberParameter(weight2.Text, _maxWeight, weightCheckBox.Checked, int.TryParse);

        public float MinPrice => GetNumberParameter(price1.Text, 0f, priceCheckBox.Checked, float.TryParse);

        public float MaxPrice => GetNumberParameter(price2.Text, _maxPrice, priceCheckBox.Checked, float.TryParse);

        public dishes_Filter_Form(Action updateDataTable, IDishService dishService)
        {
            InitializeComponent();

            _updateDataTable = updateDataTable;

            dishService.GetMaxValues(out _maxPortions, out _maxCookingTime, out _maxWeight, out _maxPrice);
        }

        private T GetNumberParameter<T>(string text, T defaultValue, bool isChecked, TryParseDelegate<T> TryParse)
        {
            bool isDesiredType = TryParse(text, out T num);
            if (!isChecked || string.IsNullOrWhiteSpace(text) || !isDesiredType)
            {
                return defaultValue;
            }
            else
            {
                return num;
            }
        }

        private string GetStringParameter(ComboBox comboBox, bool isChecked)
        {
            if (!isChecked || comboBox.SelectedIndex == -1)
            {
                return "";
            }
            else
            {
                return comboBox.SelectedItem.ToString();
            }
        }

        private void units_of_measurementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            menu_sectionComboBox.Enabled = menuSectionCheckBox.Checked;

            _updateDataTable();
        }

        private void proteinsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            energy_categoryComboBox.Enabled = energyCategoryCheckBox.Checked;

            _updateDataTable();
        }

        private void fatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            portions1TextBox.Enabled = portionsCheckBox.Checked;
            portions2TextBox.Enabled = portionsCheckBox.Checked;

            _updateDataTable();
        }

        private void carbohydratesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cookingTime1.Enabled = cookingTimeCheckBox.Checked;
            cookingTime2.Enabled = cookingTimeCheckBox.Checked;

            _updateDataTable();
        }

        private void energy_valueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            weight1.Enabled = weightCheckBox.Checked;
            weight2.Enabled = weightCheckBox.Checked;

            _updateDataTable();
        }

        private void priceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            price1.Enabled = priceCheckBox.Checked;
            price2.Enabled = priceCheckBox.Checked;

            _updateDataTable();
        }

        private void filterValue_ValueChanged(object sender, EventArgs e)
        {
            _updateDataTable();
        }

        private void cancel_filtrationButton_Click(object sender, EventArgs e)
        {
            menuSectionCheckBox.Checked = false;
            energyCategoryCheckBox.Checked = false;
            portionsCheckBox.Checked = false;
            cookingTimeCheckBox.Checked = false;
            weightCheckBox.Checked = false;
            priceCheckBox.Checked = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void types_of_products_Filter_Form_Leave(object sender, EventArgs e)
        {
            Hide();
        }

        private void types_of_products_Filter_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
