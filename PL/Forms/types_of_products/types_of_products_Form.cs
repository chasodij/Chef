using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace chef
{
    public partial class types_of_products_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool isSearched = false;
        types_of_products_Filter_Form filter_Form;
        TypesOfProductsSortForm sort_Form;
        public types_of_products_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            filter_Form = new types_of_products_Filter_Form(this);
            sort_Form = new TypesOfProductsSortForm(sortAndFilter);
        }

        private void types_of_products_Form_Load(object sender, EventArgs e)
        {
            sortAndFilter();
            dataGridView.Columns[0].HeaderText = "Номер";
            dataGridView.Columns[1].HeaderText = "Назва";
            dataGridView.Columns[2].HeaderText = "Білки";
            dataGridView.Columns[3].HeaderText = "Жири";
            dataGridView.Columns[4].HeaderText = "Вуглеводи";
            dataGridView.Columns[5].HeaderText = "Енергетична цінність";
            dataGridView.Columns[6].HeaderText = "Одиниці вимірювання";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            new types_of_products_AddEdit_Form(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value), connectionstring).ShowDialog();
            sortAndFilter();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new types_of_products_AddEdit_Form(connectionstring).ShowDialog();
            sortAndFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                string select = "SELECT product_id FROM products WHERE type_id = @type_id";
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@type_id", dataGridView.SelectedRows[0].Cells[0].Value);
                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count != 0)
                {
                    MessageBox.Show($"Ви не можете видалити тип продукту \"{dataGridView.SelectedRows[0].Cells[1].Value}\", бо продукт такого типу присутній на складі", "Видалення", MessageBoxButtons.OK);
                    return;
                }
                select = "SELECT type_id FROM ingredients WHERE type_id = @type_id";
                da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@type_id", dataGridView.SelectedRows[0].Cells[0].Value);
                ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count != 0)
                {
                    MessageBox.Show($"Ви не можете видалити тип продукту \"{dataGridView.SelectedRows[0].Cells[1].Value}\", бо він присутній в стравах", "Видалення", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show($"Ви дійсно бажаєте видалити тип продукту \"{dataGridView.SelectedRows[0].Cells[1].Value}\"?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                cmd.CommandText = $"DELETE FROM types_of_products WHERE type_id = {dataGridView.SelectedRows[0].Cells[0].Value}";
                cmd.ExecuteNonQuery();
            }
            sortAndFilter();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!searchTextBox_Validate())
                return;
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

            string select = $"SELECT * FROM types_of_products WHERE type_name LIKE @search + '%'";
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
            if (filter_Form.units_of_measurement != "")
            {
                filter += $"units_of_measurement = '{filter_Form.units_of_measurement}' AND ";
            }
            filter += $"proteins BETWEEN {filter_Form.proteins_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.proteins_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} " +
                $"AND fats BETWEEN {filter_Form.fats_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.fats_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} " +
                $"AND carbohydrates BETWEEN {filter_Form.carbohydrates_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.carbohydrates_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} " +
                $"AND energy_value BETWEEN {filter_Form.energy_value_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.energy_value_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}";
            return filter;
        }

        private string GetSortData()
        {
            string order = "ORDER BY " + sort_Form.NameStatement + sort_Form.ProteinsStatement + sort_Form.FatsStatement + sort_Form.CarbohydratesStatement + sort_Form.EnergyStatemenet;
            if (order == "ORDER BY ")
                return "";
            return order.Substring(0, order.Length - 2);
        }

        public void sortAndFilter()
        {
            string select = $"SELECT * FROM types_of_products {GetFilterData()} {GetSortData()}";
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

        private void types_of_products_Form_FormClosing(object sender, FormClosingEventArgs e)
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