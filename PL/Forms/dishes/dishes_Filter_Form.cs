using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace chef
{
    public partial class dishes_Filter_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        dishes_Form parent_Form;
        int max_portions, max_cooking_time, max_mass;
        float max_price;

        public string menu_section
        {
            get
            {
                if (menu_sectionCheckBox.Checked == false || menu_sectionComboBox.SelectedIndex == -1)
                    return "";
                else
                {
                    return menu_sectionComboBox.SelectedItem.ToString();
                }
            }
        }
        public string energy_category
        {
            get
            {
                if (energy_categoryCheckBox.Checked == false || energy_categoryComboBox.SelectedIndex == -1)
                    return "";
                else
                {
                    return energy_categoryComboBox.SelectedItem.ToString();
                }
            }
        }
        public int portions_min
        {
            get
            {
                int num = 0;
                bool isInt = int.TryParse(portions1.Text, out num);
                if (portionsCheckBox.Checked == false || string.IsNullOrWhiteSpace(portions1.Text) || !isInt)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public int portions_max
        {
            get
            {
                int num = 0;
                bool isInt = int.TryParse(portions2.Text, out num);
                if (portionsCheckBox.Checked == false || string.IsNullOrWhiteSpace(portions2.Text) || !isInt)
                {
                    return max_portions;
                }
                else
                {
                    return num;
                }
            }
        }
        public int cooking_time_min
        {
            get
            {
                int num = 0;
                bool isInt = int.TryParse(cooking_time1.Text, out num);
                if (cooking_timeCheckBox.Checked == false || string.IsNullOrWhiteSpace(cooking_time1.Text) || !isInt)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public int cooking_time_max
        {
            get
            {
                int num = 0;
                bool isInt = int.TryParse(cooking_time2.Text, out num);
                if (cooking_timeCheckBox.Checked == false || string.IsNullOrWhiteSpace(cooking_time2.Text) || !isInt)
                {
                    return max_cooking_time;
                }
                else
                {
                    return num;
                }
            }
        }
        public int mass_min
        {
            get
            {
                int num = 0;
                bool isInt = int.TryParse(mass1.Text, out num);
                if (massCheckBox.Checked == false || string.IsNullOrWhiteSpace(mass1.Text) || !isInt)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public int mass_max
        {
            get
            {
                int num = 0;
                bool isInt = int.TryParse(mass2.Text, out num);
                if (massCheckBox.Checked == false || string.IsNullOrWhiteSpace(mass2.Text) || !isInt)
                {
                    return max_mass;
                }
                else
                {
                    return num;
                }
            }
        }
        public float price_min
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(price1.Text, out num);
                if (priceCheckBox.Checked == false || string.IsNullOrWhiteSpace(price1.Text) || !isFloat)
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
        public dishes_Filter_Form(dishes_Form parent_Form, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            this.parent_Form = parent_Form;
            string select = "SELECT MAX(dish_portions), MAX(cooking_time), MAX(mass), MAX(dish_price) FROM dishes";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                int.TryParse(ds.Rows[0].ItemArray[0].ToString(), out max_portions);
                int.TryParse(ds.Rows[0].ItemArray[1].ToString(), out max_cooking_time);
                int.TryParse(ds.Rows[0].ItemArray[2].ToString(), out max_mass);
                float.TryParse(ds.Rows[0].ItemArray[3].ToString(), out max_price);
            }
        }

        private void units_of_measurementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu_sectionCheckBox.Checked)
            {
                menu_sectionComboBox.Enabled = true;
            }
            else
            {
                menu_sectionComboBox.Enabled = false;
            }
            parent_Form.SortAndFilter();
        }

        private void proteinsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (energy_categoryCheckBox.Checked)
            {
                energy_categoryComboBox.Enabled = true;
            }
            else
            {
                energy_categoryComboBox.Enabled = false;
            }
            parent_Form.SortAndFilter();
        }

        private void fatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (portionsCheckBox.Checked)
            {
                portions1.Enabled = true;
                portions2.Enabled = true;
            }
            else
            {
                portions1.Enabled = false;
                portions2.Enabled = false;
            }
            parent_Form.SortAndFilter();
        }

        private void carbohydratesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cooking_timeCheckBox.Checked)
            {
                cooking_time1.Enabled = true;
                cooking_time2.Enabled = true;
            }
            else
            {
                cooking_time1.Enabled = false;
                cooking_time2.Enabled = false;
            }
            parent_Form.SortAndFilter();
        }

        private void energy_valueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (massCheckBox.Checked)
            {
                mass1.Enabled = true;
                mass2.Enabled = true;
            }
            else
            {
                mass1.Enabled = false;
                mass2.Enabled = false;
            }
            parent_Form.SortAndFilter();
        }

        private void cancel_filtrationButton_Click(object sender, EventArgs e)
        {
            menu_sectionCheckBox.Checked = false;
            energy_categoryCheckBox.Checked = false;
            portionsCheckBox.Checked = false;
            cooking_timeCheckBox.Checked = false;
            massCheckBox.Checked = false;
            priceCheckBox.Checked = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void proteinsTextBox1_TextChanged(object sender, EventArgs e)
        {
            parent_Form.SortAndFilter();
        }

        private void priceCheckBox_CheckedChanged(object sender, EventArgs e)
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
            parent_Form.SortAndFilter();
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
