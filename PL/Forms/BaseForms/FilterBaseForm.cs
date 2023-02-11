using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace chef.PL.Forms.BaseForms
{
    public class FilterBaseForm : Form
    {
        protected readonly Action _updateDataTable;
        protected readonly List<IFilterRow> _filterRows = new List<IFilterRow>();

        public FilterBaseForm() { }
        public FilterBaseForm(Action updateDataTable)
        {
            _updateDataTable = updateDataTable;
        }

        protected virtual void FilterValue_ValueChanged(object sender, EventArgs e)
        {
            _updateDataTable();
        }

        protected virtual void CancelFiltrationButton_Click(object sender, EventArgs e)
        {
            foreach (var row in _filterRows)
            {
                row.CancelFiltration();
            }
        }

        protected virtual void HideForm(object sender, EventArgs e)
        {
            Hide();
        }

        protected virtual void CloseForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
