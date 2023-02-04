using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chef
{
    public partial class orders_Sort_Form : Form
    {
        sortRow[] sortRows = new sortRow[3];
        orders_Form parent_Form;

        public string sortNum
        {
            get
            {
                if (numCheckBox.Checked)
                {
                    if (sortRows[0].sortWhatAsc)
                    {
                        return "order_id, ";
                    }
                    else
                    {
                        return "order_id DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortTotal
        {
            get
            {
                if (totalCheckBox.Checked)
                {
                    if (sortRows[1].sortWhatAsc)
                    {
                        return "order_total, ";
                    }
                    else
                    {
                        return "order_total DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortDate
        {
            get
            {
                if (dateCheckBox.Checked)
                {
                    if (sortRows[2].sortWhatAsc)
                    {
                        return "order_date, ";
                    }
                    else
                    {
                        return "order_date DESC, ";
                    }
                }
                return "";
            }
        }
        public orders_Sort_Form(orders_Form parent_Form)
        {
            InitializeComponent();
            sortRows[0] = new sortRow(numCheckBox, num1, num2, true);
            sortRows[1] = new sortRow(totalCheckBox, total1, total2, true);
            sortRows[2] = new sortRow(dateCheckBox, date1, date2, true);
            this.parent_Form = parent_Form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < sortRows.Length; i++)
            {
                sortRows[i].checkBox.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void types_of_products_Sort_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void types_of_products_Sort_Form_Leave(object sender, EventArgs e)
        {
            Hide();
        }

        private void type_nameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = sender as CheckBox;
            int i = 0;
            for (i = 0; i < sortRows.Length; i++)
            {
                if (sortRows[i].checkBox == a)
                {
                    break;
                }
            }
            ChangeImage(sortRows[i]);
            parent_Form.sortAndFilter();
        }
        private void ChangeImage(sortRow sortRow)
        {
            if (sortRow.checkBox.Checked)
            {
                sortRow.pictureBox1.Cursor = Cursors.Hand;
                sortRow.pictureBox2.Cursor = Cursors.Hand;
                if (sortRow.sortWhatAsc)
                {
                    sortRow.pictureBox1.Image = Properties.Resources.asc2;
                    sortRow.pictureBox2.Image = Properties.Resources.desc1;
                }
                else
                {
                    sortRow.pictureBox1.Image = Properties.Resources.asc1;
                    sortRow.pictureBox2.Image = Properties.Resources.desc2;
                }
            }
            else
            {
                sortRow.pictureBox1.Cursor = Cursors.Default;
                sortRow.pictureBox2.Cursor = Cursors.Default;
                if (sortRow.sortWhatAsc)
                {
                    sortRow.pictureBox1.Image = Properties.Resources.asc2_dis;
                    sortRow.pictureBox2.Image = Properties.Resources.desc1_dis;
                }
                else
                {
                    sortRow.pictureBox1.Image = Properties.Resources.asc1_dis;
                    sortRow.pictureBox2.Image = Properties.Resources.desc2_dis;
                }
            }
        }
        private void name1_Click(object sender, EventArgs e)
        {
            PictureBox a = sender as PictureBox;
            int i = 0;
            for (i = 0; i < sortRows.Length; i++)
            {
                if(sortRows[i].pictureBox1 == a)
                {
                    break;
                }
            }
            ChangeOrder(sortRows[i], true);
            parent_Form.sortAndFilter();
        }
        private void name2_Click(object sender, EventArgs e)
        {
            PictureBox a = sender as PictureBox;
            int i = 0;
            for (i = 0; i < sortRows.Length; i++)
            {
                if (sortRows[i].pictureBox2 == a)
                {
                    break;
                }
            }
            ChangeOrder(sortRows[i], false);
            parent_Form.sortAndFilter();
        }
        private void ChangeOrder(sortRow sortRow, bool sortAsc)
        {
            if(sortAsc)
            {
                if (sortRow.checkBox.Checked && !sortRow.sortWhatAsc)
                {
                    sortRow.sortWhatAsc = true;
                    sortRow.pictureBox1.Image = Properties.Resources.asc2;
                    sortRow.pictureBox2.Image = Properties.Resources.desc1;
                }
            }
            else
            {
                if (sortRow.checkBox.Checked && sortRow.sortWhatAsc)
                {
                    sortRow.sortWhatAsc = false;
                    sortRow.pictureBox1.Image = Properties.Resources.asc1;
                    sortRow.pictureBox2.Image = Properties.Resources.desc2;
                }
            }
        }
    
    }
}
