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
    public partial class products_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool isSearched = false;
        products_Filter_Form filter_Form;
        products_Sort_Form sort_Form;
        public products_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            filter_Form = new products_Filter_Form(this, connectionstring);
            sort_Form = new products_Sort_Form(this);
        }

        private void products_Form_Load(object sender, EventArgs e)
        {
            sortAndFilter();
            dataGridView.Columns[0].HeaderText = "Номер";
            dataGridView.Columns[1].HeaderText = "Тип";
            dataGridView.Columns[2].HeaderText = "Назва";
            dataGridView.Columns[3].HeaderText = "Виробник";
            dataGridView.Columns[4].HeaderText = "Ціна";
            dataGridView.Columns[5].HeaderText = "Кількість";
            dataGridView.Columns[6].HeaderText = "Строк придатності до";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            new products_AddEdit_Form(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value), connectionstring).ShowDialog();
            sortAndFilter();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new products_AddEdit_Form(connectionstring).ShowDialog();
            sortAndFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0 || MessageBox.Show($"Ви дійсно бажаєте видалити продукт \"{dataGridView.SelectedRows[0].Cells[2].Value}\"?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                cmd.CommandText = $"DELETE FROM products WHERE product_id = {dataGridView.SelectedRows[0].Cells[0].Value}";
                cmd.ExecuteNonQuery();
            }
            sortAndFilter();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            isSearched = !isSearched;
            if (isSearched)
            {
                searchButton.FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                searchButton.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }

            if (!isSearched)
            {
                errorProvider1.Clear();
                return;
            }
            if (!searchTextBox_Validate())
                return;

            string field = "WHERE product_name";
            if (search_manufacturerRadioButton.Checked)
            {
                field = "WHERE manufacturer";
            }
            string select = $"SELECT * FROM products {field} LIKE @search + '%'";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@search", searchTextBox.Text);
                DataTable ds = new DataTable();
                da.Fill(ds);

                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Rows.Count; j++)
                    {
                        if (dataGridView.Rows[j].Cells[0].Value.ToString() == ds.Rows[i].ItemArray[0].ToString())
                        {
                            dataGridView.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(227, 105, 15);
                            break;
                        }
                    }
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filter_Form.Show();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            sort_Form.Show();
        }

        private string GetFilterData()
        {
            string filter = "WHERE ";
            if (filter_Form.product_type != -1)
                filter += $"products.type_id = '{filter_Form.product_type}' AND ";
            if (filter_Form.manufacturer != "")
                filter += $"manufacturer = '{filter_Form.manufacturer}' AND ";
            
            filter += $"product_price BETWEEN {filter_Form.price_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.price_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} " +
                    $"AND product_amount BETWEEN {filter_Form.amount_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.amount_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} " +
                    $"AND expiration_date BETWEEN '{filter_Form.expired_min.ToString("MM/dd/yyyy")}' AND '{filter_Form.expired_max.ToString("MM/dd/yyyy")}'";
            return filter;
        }

        private string GetSortData()
        {
            string order = "ORDER BY " + sort_Form.sortName + sort_Form.sortManufacturer + sort_Form.sortPrice + sort_Form.sortAmount + sort_Form.sortExpirationDate;
            if (order == "ORDER BY ")
                return "";
            return order.Substring(0, order.Length - 2);
        }

        public void sortAndFilter()
        {
            string select = $"SELECT products.product_id, types_of_products.[type_name], products.product_name, products.manufacturer, products.product_price, products.product_amount, products.expiration_date FROM products JOIN types_of_products ON products.[type_id] = types_of_products.[type_id] {GetFilterData()} {GetSortData()}";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView.DataSource = ds;
            }
        }
        private bool searchTextBox_Validate()
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                errorProvider1.SetError(searchTextBox, "Поле не повинно бути пустим");
                return false;
            }
            errorProvider1.SetError(searchTextBox, "");
            return true;
        }
        private void products_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            sort_Form.Close();
            filter_Form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}