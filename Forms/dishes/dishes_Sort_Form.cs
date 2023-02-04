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
    public partial class dishes_Sort_Form : Form
    {
        sortRow[] sortRows = new sortRow[5];
        dishes_Form parent_Form;

        public string sortName
        {
            get
            {
                if (type_nameCheckBox.Checked)
                {
                    if (sortRows[0].sortWhatAsc)
                    {
                        return "dish_name, ";
                    }
                    else
                    {
                        return "dish_name DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortPortions
        {
            get
            {
                if (portionsCheckBox.Checked)
                {
                    if (sortRows[1].sortWhatAsc)
                    {
                        return "dish_portions, ";
                    }
                    else
                    {
                        return "dish_portions DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortPrice
        {
            get
            {
                if (priceCheckBox.Checked)
                {
                    if (sortRows[2].sortWhatAsc)
                    {
                        return "dish_price, ";
                    }
                    else
                    {
                        return "dish_price DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortCooking_time
        {
            get
            {
                if (cooking_timeCheckBox.Checked)
                {
                    if (sortRows[3].sortWhatAsc)
                    {
                        return "cooking_time, ";
                    }
                    else
                    {
                        return "cooking_time DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortMass
        {
            get
            {
                if (massCheckBox.Checked)
                {
                    if (sortRows[4].sortWhatAsc)
                    {
                        return "mass, ";
                    }
                    else
                    {
                        return "mass DESC, ";
                    }
                }
                return "";
            }
        }
        public dishes_Sort_Form(dishes_Form parent_Form)
        {
            InitializeComponent();
            sortRows[0] = new sortRow(type_nameCheckBox, name1, name2, true);
            sortRows[1] = new sortRow(portionsCheckBox, portions1, portions2, true);
            sortRows[2] = new sortRow(priceCheckBox, price1, price2, true);
            sortRows[3] = new sortRow(cooking_timeCheckBox, cooking_time1, cooking_time2, true);
            sortRows[4] = new sortRow(massCheckBox, mass1, mass2, true);
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
