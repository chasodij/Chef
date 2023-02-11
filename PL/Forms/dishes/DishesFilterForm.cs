using chef.BLL.Services;
using chef.PL.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace chef
{
    public partial class DishesFilterForm : FilterBaseForm
    {
        public string MenuStatement => _filterRows[0].GetStatement;
        public string EnergyStatement => _filterRows[1].GetStatement;
        public string PortionsStatement => _filterRows[2].GetStatement;
        public string CookingTimeStatement => _filterRows[3].GetStatement;
        public string WeightStatement => _filterRows[4].GetStatement;
        public string PriceStatement => _filterRows[5].GetStatement;

        public DishesFilterForm(Action updateDataTable, IDishService dishService) : base(updateDataTable)
        {
            InitializeComponent();

            dishService.GetMaxValues(out int maxPortions,
                out int maxCookingTime,
                out int maxWeight,
                out float maxPrice);

            _filterRows.Add(new ComboBoxFilterRow("menu_section", menuSectionComboBox, menuSectionCheckBox, updateDataTable));
            _filterRows.Add(new ComboBoxFilterRow("energy_category", energyCategoryComboBox, energyCategoryCheckBox, updateDataTable));
            _filterRows.Add(new TwoIntsFilterRow("dish_portions", 0, maxPortions, portionsCheckBox, portions1TextBox, portions2TextBox, updateDataTable));
            _filterRows.Add(new TwoIntsFilterRow("cooking_time", 0, maxCookingTime, cookingTimeCheckBox, cookingTime1, cookingTime2, updateDataTable));
            _filterRows.Add(new TwoIntsFilterRow("mass", 0, maxWeight, weightCheckBox, weight1, weight2, updateDataTable));
            _filterRows.Add(new TwoFloatsFilterRow("dish_price", 0f, maxPrice, priceCheckBox, price1, price2, updateDataTable));
        }

        // Next methods are present only for viewing the form in the designer

        protected override void FilterValue_ValueChanged(object sender, EventArgs e) =>
            base.FilterValue_ValueChanged(sender, e);

        protected override void CancelFiltrationButton_Click(object sender, EventArgs e) =>
            base.CancelFiltrationButton_Click(sender, e);

        protected override void HideForm(object sender, EventArgs e) =>
            base.HideForm(sender, e);

        protected override void CloseForm(object sender, FormClosingEventArgs e) =>
            base.CloseForm(sender, e);
    }
}
