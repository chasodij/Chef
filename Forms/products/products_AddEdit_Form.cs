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
using System.Text.RegularExpressions;

namespace chef
{
    public partial class products_AddEdit_Form : Form
    {
        readonly int product_id;
        readonly bool edit = false;
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool saved = false;
        public products_AddEdit_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            FillComboBox();
            saveButon.Text = "Додати";
            this.Text = "Додавання продукту";
            AutoValidate = AutoValidate.Disable;
        }
        public products_AddEdit_Form(int product_id, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;

            string select = "SELECT * FROM products WHERE product_id = @product_id";
            DataTable ds = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@product_id", product_id);
                da.Fill(ds);
            }

            int type_id = Convert.ToInt32(ds.Rows[0].ItemArray[1]);
            string product_name = ds.Rows[0].ItemArray[2].ToString();
            string manufacturer = ds.Rows[0].ItemArray[3].ToString();
            decimal product_price = decimal.Parse(ds.Rows[0].ItemArray[4].ToString());
            decimal product_amount = decimal.Parse(ds.Rows[0].ItemArray[5].ToString());
            DateTime expiration_date = DateTime.Parse(ds.Rows[0].ItemArray[6].ToString());

            FillComboBox();
            edit = true;
            this.product_id = product_id;
            type_idComboBox.SelectedValue = type_id;
            product_nameTextBox.Text = product_name;
            manufacturerTextBox.Text = manufacturer;
            product_priceTextBox.Value = product_price;
            product_amountTextBox.Value = product_amount;
            expiration_dateDatePicker.Value = expiration_date;
            saveButon.Text = "Зберегти";
            this.Text = "Редагування продукту";
            AutoValidate = AutoValidate.Disable;
        }

        private void saveButon_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;
            string query;
            if(edit)
            {
                query = "UPDATE products SET type_id = @type_id, product_name = @product_name, manufacturer = @manufacturer, product_price = @product_price, product_amount = @product_amount, expiration_date = @expiration_date WHERE product_id = @product_id";
            }
            else
            {
                query = $"INSERT INTO products (type_id, product_name, manufacturer, product_price, product_amount, expiration_date) VALUES (@type_id, @product_name, @manufacturer, @product_price, @product_amount, @expiration_date);";
            }
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@type_id", type_idComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@product_name", product_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@manufacturer", manufacturerTextBox.Text);
                cmd.Parameters.AddWithValue("@product_price", product_priceTextBox.Value);
                cmd.Parameters.AddWithValue("@product_amount", product_amountTextBox.Value);
                cmd.Parameters.AddWithValue("@expiration_date", expiration_dateDatePicker.Value);
                cmd.Parameters.AddWithValue("@product_id", product_id);

                cmd.ExecuteNonQuery();
            }
            saved = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void products_AddEdit_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && MessageBox.Show($"Ви дійсно бажаєте закрити це вікно? В такому разі ваші зміни не буде збережено.", "Вихід", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
        private void FillComboBox()
        {
            string select = "SELECT type_id, type_name FROM types_of_products";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                type_idComboBox.DataSource = ds;
                type_idComboBox.DisplayMember = "type_name";
                type_idComboBox.ValueMember = "type_id";
            }
        }

        private void product_nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(product_nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(product_nameTextBox, "Поле не повинно бути пустим");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(product_nameTextBox, "");
            }
        }

        private void type_idComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (type_idComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(type_idComboBox, "Оберіть один з варіантів розділу меню");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(type_idComboBox, "");
            }
        }

        private void manufacturerTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(manufacturerTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(manufacturerTextBox, "Поле не повинно бути пустим");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(manufacturerTextBox, "");
            }
        }
    }
}
