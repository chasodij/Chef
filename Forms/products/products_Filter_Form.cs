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
    public partial class products_Filter_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        products_Form parent_Form;
        float max_price;
        float max_amount;
        DateTime max_date;
        bool isInitialized = false;
        
        public int product_type
        {
            get
            {
                if (typeCheckBox.Checked == false || typeComboBox.SelectedIndex == -1)
                    return -1;
                else
                {
                    return Int32.Parse(typeComboBox.SelectedValue.ToString());
                }
            }
        }
        public string manufacturer
        {
            get
            {
                if (manufacturerCheckBox.Checked == false || manufacturerComboBox.SelectedIndex == -1)
                    return "";
                else
                {
                    return manufacturerComboBox.SelectedValue.ToString();
                }
            }
        }
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
        public float amount_min
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(amount1.Text, out num);
                if (amountCheckBox.Checked == false || string.IsNullOrWhiteSpace(amount1.Text) || !isFloat)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public float amount_max
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(amount2.Text, out num);
                if (amountCheckBox.Checked == false || string.IsNullOrWhiteSpace(amount2.Text) || !isFloat)
                {
                    return max_amount;
                }
                else
                {
                    return num;
                }
            }
        }
        public DateTime expired_min
        {
            get
            {
                DateTime date = DateTime.MinValue;
                bool isDate = DateTime.TryParse(expired1.Text, out date);
                if (expiredCheckBox.Checked == false || string.IsNullOrWhiteSpace(expired1.Text) || !isDate || date < DateTime.Parse("01.01.1990") || date > DateTime.Parse("31.12.2077"))
                {
                    return new DateTime(2000, 1, 1);
                }
                else
                {
                    return date;
                }
            }
        }
        public DateTime expired_max
        {
            get
            {
                DateTime date = DateTime.MinValue;
                bool isDate = DateTime.TryParse(expired2.Text, out date);
                if (expiredCheckBox.Checked == false || string.IsNullOrWhiteSpace(expired2.Text) || !isDate || date < DateTime.Parse("01.01.1990") || date > DateTime.Parse("31.12.2077"))
                {
                    return max_date.AddDays(1);
                }
                else
                {
                    return date.AddDays(1);
                }
            }
        }
        public products_Filter_Form(products_Form parent_Form, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            this.parent_Form = parent_Form;
            string select = "SELECT type_id, type_name FROM types_of_products";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                typeComboBox.DataSource = ds;
                typeComboBox.DisplayMember = "type_name";
                typeComboBox.ValueMember = "type_id";
                select = "SELECT DISTINCT manufacturer FROM products";
                da = new SqlDataAdapter(select, c);
                ds = new DataTable();
                da.Fill(ds);
                manufacturerComboBox.DataSource = ds;
                manufacturerComboBox.ValueMember = "manufacturer";
                select = "SELECT MAX(product_price), MAX(product_amount), MAX(expiration_date) FROM products";
                da = new SqlDataAdapter(select, c);
                ds = new DataTable();
                da.Fill(ds);
                float.TryParse(ds.Rows[0].ItemArray[0].ToString(), out max_price);
                float.TryParse(ds.Rows[0].ItemArray[1].ToString(), out max_amount);
                DateTime.TryParse(ds.Rows[0].ItemArray[2].ToString(), out max_date);
                max_date.AddDays(1);
            }
            isInitialized = true;
        }

        private void units_of_measurementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(typeCheckBox.Checked)
            {
                typeComboBox.Enabled = true;
            }
            else
            {
                typeComboBox.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void proteinsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (manufacturerCheckBox.Checked)
            {
                manufacturerComboBox.Enabled = true;
            }
            else
            {
                manufacturerComboBox.Enabled = false;
            }
            parent_Form.sortAndFilter();
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
            if (amountCheckBox.Checked)
            {
                amount1.Enabled = true;
                amount2.Enabled = true;
            }
            else
            {
                amount1.Enabled = false;
                amount2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void energy_valueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (expiredCheckBox.Checked)
            {
                expired1.Enabled = true;
                expired2.Enabled = true;
            }
            else
            {
                expired1.Enabled = false;
                expired2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void cancel_filtrationButton_Click(object sender, EventArgs e)
        {
            typeCheckBox.Checked = false;
            manufacturerCheckBox.Checked = false;
            priceCheckBox.Checked = false;
            amountCheckBox.Checked = false;
            expiredCheckBox.Checked = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void proteinsTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (isInitialized)
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
