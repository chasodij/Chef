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
    public partial class dishes_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool isSearched = false;
        dishes_Filter_Form filter_Form;
        dishes_Sort_Form sort_Form;
        public dishes_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            filter_Form = new dishes_Filter_Form(this, connectionstring);
            sort_Form = new dishes_Sort_Form(this);
        }

        private void dishes_Form_Load(object sender, EventArgs e)
        {
            sortAndFilter();
            dataGridView.Columns[0].HeaderText = "Номер";
            dataGridView.Columns[1].HeaderText = "Назва";
            dataGridView.Columns[2].HeaderText = "Кількість порцій";
            dataGridView.Columns[3].HeaderText = "Час приготування";
            dataGridView.Columns[4].HeaderText = "Маса на виході";
            dataGridView.Columns[5].HeaderText = "Розділ меню";
            dataGridView.Columns[6].HeaderText = "Ціна";
            dataGridView.Columns[7].HeaderText = "Енергетична категорія";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            new dishes_AddEdit_Form(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value), connectionstring).ShowDialog();
            sortAndFilter();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new dishes_AddEdit_Form(connectionstring).ShowDialog();
            sortAndFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                string select = "SELECT dish_id FROM order_items WHERE dish_id = @dish_id";
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@dish_id", dataGridView.SelectedRows[0].Cells[0].Value);
                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count != 0)
                {
                    MessageBox.Show($"Ви не можете видалити страву \"{dataGridView.SelectedRows[0].Cells[1].Value}\", бо вона присутня в замовленнях", "Видалення", MessageBoxButtons.OK);
                    return;
                }
                select = "SELECT dish_id FROM specials WHERE dish_id = @dish_id";
                da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@dish_id", dataGridView.SelectedRows[0].Cells[0].Value);
                ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count != 0)
                {
                    MessageBox.Show($"Ви не можете видалити страву \"{dataGridView.SelectedRows[0].Cells[1].Value}\", бо її було обрано стравою дня", "Видалення", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show($"Ви дійсно бажаєте видалити страву \"{dataGridView.SelectedRows[0].Cells[1].Value}\"?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                c.Open();
                cmd.CommandText = "DELETE FROM ingredients WHERE dish_id = @dish_id";
                cmd.Parameters.AddWithValue("@dish_id", dataGridView.SelectedRows[0].Cells[0].Value);
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"DELETE FROM dishes WHERE dish_id = {dataGridView.SelectedRows[0].Cells[0].Value}";
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

            string select = $"SELECT * FROM dishes WHERE dish_name LIKE @search + '%'";
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
            if (filter_Form.menu_section != "")
                filter += $"menu_section = '{filter_Form.menu_section}' AND ";
            if (filter_Form.energy_category != "")
                filter += $"energy_category = '{filter_Form.energy_category}' AND ";

            filter += $"dish_price BETWEEN {filter_Form.price_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.price_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} " +
                    $"AND cooking_time BETWEEN {filter_Form.cooking_time_min} AND {filter_Form.cooking_time_max} " +
                    $"AND dish_portions BETWEEN {filter_Form.portions_min} AND {filter_Form.portions_max} " +
                    $"AND mass BETWEEN '{filter_Form.mass_min}' AND '{filter_Form.mass_max}'";
            return filter;
        }

        private string GetSortData()
        {
            string order = "ORDER BY " + sort_Form.sortName + sort_Form.sortPortions + sort_Form.sortPrice + sort_Form.sortCooking_time + sort_Form.sortMass;
            if (order == "ORDER BY ")
                return "";
            return order.Substring(0, order.Length - 2);
        }

        public void sortAndFilter()
        {
            string select = $"SELECT dish_id, dish_name, dish_portions, cooking_time, mass, menu_section, dish_price, energy_category FROM dishes {GetFilterData()} {GetSortData()}";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            new dishes_Details_Form(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value), connectionstring).ShowDialog();
            sortAndFilter();
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

        private void dishes_Form_FormClosing(object sender, FormClosingEventArgs e)
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