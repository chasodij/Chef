using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace chef
{
    public partial class orders_Filter_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        readonly orders_Form parent_Form;
        readonly float max_total;
        readonly DateTime max_date;

        public int is_completed
        {
            get
            {
                if (is_completedCheckBox.Checked == false || is_completedComboBox.SelectedIndex == -1)
                    return -1;
                else
                {
                    return is_completedComboBox.SelectedIndex;
                }
            }
        }
        public float total_min
        {
            get
            {
                bool isFloat = float.TryParse(total1.Text, out float num);
                if (totalCheckBox.Checked == false || string.IsNullOrWhiteSpace(total1.Text) || !isFloat)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public float total_max
        {
            get
            {
                bool isFloat = float.TryParse(total2.Text, out float num);
                if (totalCheckBox.Checked == false || string.IsNullOrWhiteSpace(total2.Text) || !isFloat)
                {
                    return max_total;
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
                bool isDate = DateTime.TryParse(date1.Text, out DateTime date);
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
                bool isDate = DateTime.TryParse(date2.Text, out DateTime date);
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

        public orders_Filter_Form(orders_Form parent_Form, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            this.parent_Form = parent_Form;
            string select = "SELECT MAX(order_total), MAX(order_date) FROM orders";
            using (SqlConnection c = new SqlConnection(this.connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                float.TryParse(ds.Rows[0].ItemArray[0].ToString(), out max_total);
                DateTime.TryParse(ds.Rows[0].ItemArray[1].ToString(), out max_date);
                max_date = max_date.AddDays(1);
            }
        }

        private void units_of_measurementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (is_completedCheckBox.Checked)
            {
                is_completedComboBox.Enabled = true;
            }
            else
            {
                is_completedComboBox.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void fatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (totalCheckBox.Checked)
            {
                total1.Enabled = true;
                total2.Enabled = true;
            }
            else
            {
                total1.Enabled = false;
                total2.Enabled = false;
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
            is_completedCheckBox.Checked = false;
            totalCheckBox.Checked = false;
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
