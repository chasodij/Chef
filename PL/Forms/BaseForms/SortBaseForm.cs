using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace chef.PL.Forms.BaseForms
{
    public class SortBaseForm : Form
    {
        protected readonly Action _updateDataTable;
        protected readonly List<SortRow> _sortRows = new List<SortRow>();

        public SortBaseForm() { }

        public SortBaseForm(Action updateDataTable)
        {
            _updateDataTable = updateDataTable;
        }

        protected virtual void SortRowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var sortRow = _sortRows.First(x => x.CheckBox.Equals(sender as CheckBox));

            sortRow.ChangeImage();

            _updateDataTable();
        }

        protected virtual void Picture1_Click(object sender, EventArgs e)
        {
            var sortRow = _sortRows.First(x => x.PictureBox1.Equals(sender as PictureBox));

            sortRow.ChangeOrder(true);

            _updateDataTable();
        }

        protected virtual void Picture2_Click(object sender, EventArgs e)
        {
            var sortRow = _sortRows.First(x => x.PictureBox2.Equals(sender as PictureBox));

            sortRow.ChangeOrder(false);

            _updateDataTable();
        }

        protected virtual void ClearSortingButton_Click(object sender, EventArgs e)
        {
            foreach (var sortRow in _sortRows)
            {
                sortRow.CheckBox.Checked = false;
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
