using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace chef
{
    public partial class specials_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool isSearched = false;
        specials_Filter_Form filter_Form;
        SpecialsSortForm sort_Form;
        public specials_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            filter_Form = new specials_Filter_Form(this, connectionstring);
            sort_Form = new SpecialsSortForm(sortAndFilter);
        }

        private void specials_Form_Load(object sender, EventArgs e)
        {
            sortAndFilter();
            dataGridView.Columns[0].HeaderText = "Номер";
            dataGridView.Columns[1].HeaderText = "Страва";
            dataGridView.Columns[2].HeaderText = "Ціна";
            dataGridView.Columns[3].HeaderText = "Дата";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            if (DateTime.Parse(dataGridView.SelectedRows[0].Cells[3].Value.ToString()).Date != DateTime.Now.Date)
            {
                MessageBox.Show("Видалити страву дня неможливо, адже вона обрана не на сьогодні", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show($"Ви дійсно бажаєте видалити страву дня на сьогодні?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                cmd.CommandText = $"DELETE FROM specials WHERE special_id = {dataGridView.SelectedRows[0].Cells[0].Value}";
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
            if (!search_dishTextBox_Validate())
                return;
            string select = "SELECT specials.special_id FROM specials JOIN dishes ON specials.dish_id = dishes.dish_id WHERE dishes.dish_name LIKE @search_dish + '%'";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                DataTable ds;
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@search_dish", search_dishTextBox.Text);
                ds = new DataTable();
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
            filter += $"special_date BETWEEN '{filter_Form.date_min.ToString("MM/dd/yyyy")}' AND '{filter_Form.date_max.ToString("MM/dd/yyyy")}' " +
                    $"AND special_price BETWEEN {filter_Form.price_min.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} AND {filter_Form.price_max.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} ";
            return filter;
        }

        private string GetSortData()
        {
            string order = "ORDER BY " + sort_Form.DishStatement + sort_Form.PriceStatement + sort_Form.DateStatement;
            if (order == "ORDER BY ")
                return "";
            return order.Substring(0, order.Length - 2);
        }

        public void sortAndFilter()
        {
            string select = $"SELECT specials.special_id, dishes.dish_name, specials.special_price, specials.special_date FROM specials JOIN dishes ON specials.dish_id = dishes.dish_id {GetFilterData()} {GetSortData()}";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView.DataSource = ds;
            }
        }

        private void find_today_specialButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (DateTime.Parse(dataGridView.Rows[i].Cells[3].Value.ToString()).Date == DateTime.Now.Date)
                {
                    MessageBox.Show("Неможливо додати страву дня на сьогодні, адже вона вже обрана", "", MessageBoxButtons.OK);
                    return;
                }
            }
            new specials_Finding_Form(connectionstring).ShowDialog();
            sortAndFilter();
        }
        private bool search_dishTextBox_Validate()
        {
            if (string.IsNullOrWhiteSpace(search_dishTextBox.Text))
            {
                errorProvider1.SetError(search_dishTextBox, "Поле не повинно бути пустим");
                return false;
            }
            errorProvider1.SetError(search_dishTextBox, "");
            return true;
        }

        private void specials_Form_FormClosing(object sender, FormClosingEventArgs e)
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