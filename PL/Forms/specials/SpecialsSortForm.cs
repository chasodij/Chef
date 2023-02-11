using chef.PL.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace chef
{
    public partial class SpecialsSortForm : SortBaseForm
    {
        public string DishStatement => _sortRows[0].GetStatement;
        public string PriceStatement => _sortRows[1].GetStatement;
        public string DateStatement => _sortRows[2].GetStatement;

        public SpecialsSortForm(Action updateDataTable) : base(updateDataTable)
        {
            InitializeComponent();

            _sortRows.Add(new SortRow("dishes.dish_name", dishCheckBox, dish1, dish2, true));
            _sortRows.Add(new SortRow("special_price", priceCheckBox, price1, price2, true));
            _sortRows.Add(new SortRow("special_date", dateCheckBox, date1, date2, true));
        }

        // Next methods are present only for viewing the form in the designer
        protected override void SortRowCheckBox_CheckedChanged(object sender, EventArgs e) =>
            base.SortRowCheckBox_CheckedChanged(sender, e);

        protected override void Picture1_Click(object sender, EventArgs e) =>
            base.Picture1_Click(sender, e);

        protected override void Picture2_Click(object sender, EventArgs e) =>
            base.Picture2_Click(sender, e);

        protected override void ClearSortingButton_Click(object sender, EventArgs e) =>
            base.ClearSortingButton_Click(sender, e);

        protected override void HideForm(object sender, EventArgs e) =>
            base.HideForm(sender, e);

        protected override void CloseForm(object sender, FormClosingEventArgs e) =>
            base.CloseForm(sender, e);
    }
}
