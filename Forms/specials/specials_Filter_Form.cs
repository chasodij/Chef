using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace chef
{
    public partial class specials_Filter_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        specials_Form parent_Form;
        float max_price;
        DateTime max_date;
        
        public float price_min
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(price1.Text, out num);
                if(priceCheckBox.Checked == false || string.IsNullOrWhiteSpace(price1.Text) || !isFloat)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public float price_max
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(price2.Text, out num);
                if (priceCheckBox.Checked == false || string.IsNullOrWhiteSpace(price2.Text) || !isFloat)
                {
                    return max_price;
                }
                else
                {
                    return num;
                }
            }
        }
        public DateTime date_min
        {
            get
            {
                DateTime date = DateTime.MinValue;
                bool isDate = DateTime.TryParse(date1.Text, out date);
                if (dateCheckBox.Checked == false || string.IsNullOrWhiteSpace(date1.Text) || !isDate || date < DateTime.Parse("01.01.1990") || date > DateTime.Parse("31.12.2077"))
                {
                    return new DateTime(2000, 1, 1);
                }
                else
                {
                    return date;
                }
            }
        }
        public DateTime date_max
        {
            get
            {
                DateTime date = DateTime.MinValue;
                bool isDate = DateTime.TryParse(date2.Text, out date);
                if (dateCheckBox.Checked == false || string.IsNullOrWhiteSpace(date2.Text) || !isDate || date < DateTime.Parse("01.01.1990") || date > DateTime.Parse("31.12.2077"))
                {
                    return max_date;
                }
                else
                {
                    return date.AddDays(1);
                }
            }
        }

        public specials_Filter_Form(specials_Form parent_Form, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            this.parent_Form = parent_Form;
            string select = "SELECT MAX(special_price), MAX(special_date) FROM specials";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                float.TryParse(ds.Rows[0].ItemArray[0].ToString(), out max_price);
                DateTime.TryParse(ds.Rows[0].ItemArray[1].ToString(), out max_date);
                max_date.AddDays(1);
            }
        }

        private void fatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (priceCheckBox.Checked)
            {
                price1.Enabled = true;
                price2.Enabled = true;
            }
            else
            {
                price1.Enabled = false;
                price2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void carbohydratesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheckBox.Checked)
            {
                date1.Enabled = true;
                date2.Enabled = true;
            }
            else
            {
                date1.Enabled = false;
                date2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void cancel_filtrationButton_Click(object sender, EventArgs e)
        {
            priceCheckBox.Checked = false;
            dateCheckBox.Checked = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void proteinsTextBox1_TextChanged(object sender, EventArgs e)
        {
            parent_Form.sortAndFilter();
        }

        private void types_of_products_Filter_Form_Leave(object sender, EventArgs e)
        {
            Hide();
        }

        private void types_of_products_Filter_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
