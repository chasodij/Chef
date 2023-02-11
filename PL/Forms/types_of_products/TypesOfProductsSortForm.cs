using chef.PL.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace chef
{
    public partial class TypesOfProductsSortForm : SortBaseForm
    {
        public string NameStatement => _sortRows[0].GetStatement;
        public string ProteinsStatement => _sortRows[1].GetStatement;
        public string FatsStatement => _sortRows[2].GetStatement;
        public string CarbohydratesStatement => _sortRows[3].GetStatement;
        public string EnergyStatemenet => _sortRows[4].GetStatement;

        public TypesOfProductsSortForm(Action updateDataTable) : base(updateDataTable)
        {
            InitializeComponent();

            _sortRows.Add(new SortRow("type_name", type_nameCheckBox, name1, name2, true));
            _sortRows.Add(new SortRow("proteins", proteinsCheckBox, proteins1, proteins2, true));
            _sortRows.Add(new SortRow("fats", fatsCheckBox, fats1, fats2, true));
            _sortRows.Add(new SortRow("carbohydrates", carbohydratesCheckBox, carbohydrates1, carbohydrates2, true));
            _sortRows.Add(new SortRow("energy_value", energy_valueCheckBox, energy1, energy2, true));
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
