using chef.PL.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace chef
{
    public partial class OrdersSortForm : SortBaseForm
    {
        public string NumStatement => _sortRows[0].GetStatement;
        public string TotalStatement => _sortRows[1].GetStatement;
        public string DateStatement => _sortRows[2].GetStatement;

        public OrdersSortForm(Action updateDataTable) : base(updateDataTable)
        {
            InitializeComponent();

            _sortRows.Add(new SortRow("order_id", numCheckBox, num1, num2, true));
            _sortRows.Add(new SortRow("order_total", totalCheckBox, total1, total2, true));
            _sortRows.Add(new SortRow("order_date", dateCheckBox, date1, date2, true));
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
