using chef.PL.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace chef
{
    public partial class ProductsSortForm : SortBaseForm
    {
        public string NameStatement => _sortRows[0].GetStatement;
        public string ManufacturerStatement => _sortRows[1].GetStatement;
        public string PriceStatement => _sortRows[2].GetStatement;
        public string AmountStatement => _sortRows[3].GetStatement;
        public string ExpirationDateStatement => _sortRows[4].GetStatement;

        public ProductsSortForm(Action updateDataTable) : base(updateDataTable)
        {
            InitializeComponent();

            _sortRows.Add(new SortRow("product_name", type_nameCheckBox, name1, name2, true));
            _sortRows.Add(new SortRow("manufacturer", manufacturerCheckBox, manufacturer1, manufacturer2, true));
            _sortRows.Add(new SortRow("product_price", priceCheckBox, price1, price2, true));
            _sortRows.Add(new SortRow("product_amount", amountCheckBox, amount1, amount2, true));
            _sortRows.Add(new SortRow("expiration_date", expiredCheckBox, expired1, expired2, true));
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
