using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace chef
{
    public partial class orders_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool isSearched = false;
        readonly orders_Filter_Form filter_Form;
        readonly OrdersSortForm sort_Form;
        public orders_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            filter_Form = new orders_Filter_Form(this, connectionstring);
            sort_Form = new OrdersSortForm(sortAndFilter);
        }

        private void orders_Form_Load(object sender, EventArgs e)
        {
            sortAndFilter();
            dataGridView.Columns[0].HeaderText = "Статус виконання";
            dataGridView.Columns[1].HeaderText = "Номер";
            dataGridView.Columns[2].HeaderText = "Сума";
            dataGridView.Columns[3].HeaderText = "Час замовлення";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            string select = "SELECT * FROM orders WHERE order_id = @order_id";
            DataTable ds = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@order_id", dataGridView.SelectedRows[0].Cells[1].Value);
                da.Fill(ds);
            }
            object[] row = ds.Rows[0].ItemArray;
            orders_AddEdit_Form form = new orders_AddEdit_Form(Convert.ToInt32(row[0]), DateTime.Parse(row[2].ToString()), bool.Parse(row[3].ToString()), connectionstring);
            form.ShowDialog();
            sortAndFilter();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new orders_AddEdit_Form(connectionstring).ShowDialog();
            sortAndFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            if (dataGridView.SelectedRows[0].Cells[0].Value.ToString() == "Виконане")
            {
                MessageBox.Show("Дане замовлення неможливо видалити, адже його статус \"Виконане\"", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show($"Ви дійсно бажаєте видалити замовлення \"{dataGridView.SelectedRows[0].Cells[1].Value}\"?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();

                cmd.CommandText = "DELETE FROM order_items WHERE order_id = @order_id";
                cmd.Parameters.AddWithValue("@order_id", dataGridView.SelectedRows[0].Cells[1].Value);
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"DELETE FROM orders WHERE order_id = {dataGridView.SelectedRows[0].Cells[1].Value}";
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

            if (!search_idTextBox_Validate())
                return;
            string select = "SELECT * FROM orders WHERE order_id LIKE @search_id + '%'";

            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@search_id", search_idTextBox.Text);
                DataTable ds = new DataTable();
                da.Fill(ds);

                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Rows.Count; j++)
                    {
                        if (dataGridView.Rows[j].Cells[1].Value.ToString() == ds.Rows[i].ItemArray[0].ToString())
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
            if (filter_Form.is_completed != -1)
                filter += $"is_completed = '{filter_Form.is_completed}' AND ";

            filter += $"order_date BETWEEN '{filter_Form.date_min.ToString("MM/dd/yyyy")}' AND '{filter_Form.date_max.ToString("MM /dd/yyyy")}' " +
                    $"AND order_total BETWEEN {filter_Form.total_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.total_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} ";
            return filter;
        }

        private string GetSortData()
        {
            string order = "ORDER BY " + sort_Form.NumStatement + sort_Form.TotalStatement + sort_Form.DateStatement;
            if (order == "ORDER BY ")
                return "";
            return order.Substring(0, order.Length - 2);
        }

        public void sortAndFilter()
        {
            string select = $"SELECT CASE is_completed WHEN 1 THEN 'Виконане' WHEN 0 THEN 'Не виконане' END, order_id, order_total, order_date FROM orders {GetFilterData()} {GetSortData()}";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);

                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView.DataSource = ds;
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            string select = "SELECT * FROM orders WHERE order_id = @order_id";
            DataTable ds = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@order_id", dataGridView.SelectedRows[0].Cells[1].Value);
                da.Fill(ds);
            }
            object[] row = ds.Rows[0].ItemArray;
            orders_Details_Form form = new orders_Details_Form(Convert.ToInt32(row[0]), float.Parse(row[1].ToString()), DateTime.Parse(row[2].ToString()), bool.Parse(row[3].ToString()), connectionstring);
            form.ShowDialog();
            sortAndFilter();
        }

        private bool search_idTextBox_Validate()
        {
            if (string.IsNullOrWhiteSpace(search_idTextBox.Text))
            {
                errorProvider1.SetError(search_idTextBox, "Поле не повинно бути пустим");
                return false;
            }
            errorProvider1.SetError(search_idTextBox, "");
            return true;
        }

        private void orders_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            filter_Form.Close();
            sort_Form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}