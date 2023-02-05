using System;
using System.Windows.Forms;

namespace chef
{
    public partial class products_Sort_Form : Form
    {
        sortRow[] sortRows = new sortRow[5];
        products_Form parent_Form;

        public string sortName
        {
            get
            {
                if (type_nameCheckBox.Checked)
                {
                    if (sortRows[0].sortWhatAsc)
                    {
                        return "product_name, ";
                    }
                    else
                    {
                        return "product_name DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortManufacturer
        {
            get
            {
                if (manufacturerCheckBox.Checked)
                {
                    if (sortRows[1].sortWhatAsc)
                    {
                        return "manufacturer, ";
                    }
                    else
                    {
                        return "manufacturer DESC, ";
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
                        return "product_price, ";
                    }
                    else
                    {
                        return "product_price DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortAmount
        {
            get
            {
                if (amountCheckBox.Checked)
                {
                    if (sortRows[3].sortWhatAsc)
                    {
                        return "product_amount, ";
                    }
                    else
                    {
                        return "product_amount DESC, ";
                    }
                }
                return "";
            }
        }
        public string sortExpirationDate
        {
            get
            {
                if (expiredCheckBox.Checked)
                {
                    if (sortRows[4].sortWhatAsc)
                    {
                        return "expiration_date, ";
                    }
                    else
                    {
                        return "expiration_date DESC, ";
                    }
                }
                return "";
            }
        }
        public products_Sort_Form(products_Form parent_Form)
        {
            InitializeComponent();
            sortRows[0] = new sortRow(type_nameCheckBox, name1, name2, true);
            sortRows[1] = new sortRow(manufacturerCheckBox, manufacturer1, manufacturer2, true);
            sortRows[2] = new sortRow(priceCheckBox, price1, price2, true);
            sortRows[3] = new sortRow(amountCheckBox, amount1, amount2, true);
            sortRows[4] = new sortRow(expiredCheckBox, expired1, expired2, true);
            this.parent_Form = parent_Form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sortRows.Length; i++)
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
                if (sortRows[i].pictureBox1 == a)
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
            if (sortAsc)
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
