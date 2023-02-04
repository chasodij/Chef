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
    public partial class dishes_AddEdit_Form : Form
    {
        readonly int dish_id;
        readonly bool edit = false;
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool saved = false;
        int savedIndex = 0;
        public dishes_AddEdit_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            FillComboBox();
            saveButon.Text = "Додати";
            this.Text = "Додавання страви";
            AutoValidate = AutoValidate.Disable;
        }
        public dishes_AddEdit_Form(int dish_id, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            string select = "SELECT * FROM dishes WHERE dish_id = @dish_id";
            DataTable ds = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@dish_id", dish_id);
                da.Fill(ds);
            }
            string dish_name = ds.Rows[0].ItemArray[1].ToString();
            int dish_portions = Convert.ToInt32(ds.Rows[0].ItemArray[2]);
            int cooking_time = Convert.ToInt32(ds.Rows[0].ItemArray[3]);
            int mass = Convert.ToInt32(ds.Rows[0].ItemArray[4]);
            string recipe = ds.Rows[0].ItemArray[5].ToString();
            string menu_section = ds.Rows[0].ItemArray[6].ToString();
            decimal dish_price = decimal.Parse(ds.Rows[0].ItemArray[7].ToString());

            FillComboBox();

            edit = true;
            this.dish_id = dish_id;
            dish_nameTextBox.Text = dish_name;
            dish_portionsTextBox.Value = dish_portions;
            cooking_timeTextBox.Value = cooking_time;
            massTextBox.Value = mass;
            recipeTextBox.Text = recipe;
            menu_sectionComboBox.SelectedItem = menu_section;
            dish_priceTextBox.Value = dish_price;

            saveButon.Text = "Зберегти";
            this.Text = "Редагування страви";

            dataGridView.Columns[3].DefaultCellStyle.ForeColor = Color.FromArgb(207, 46, 5);
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string query = "SELECT types_of_products.type_id, ingredients.ingredient_amount, types_of_products.units_of_measurement FROM types_of_products JOIN ingredients ON types_of_products.type_id = ingredients.type_id WHERE ingredients.dish_id = @dish_id";
            ds = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, c);
                da.SelectCommand.Parameters.AddWithValue("@dish_id", dish_id);
                da.Fill(ds);
            }
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = ds.Rows[i].ItemArray[0];
                dataGridView.Rows[i].Cells[1].Value = ds.Rows[i].ItemArray[1];
                dataGridView.Rows[i].Cells[2].Value = ds.Rows[i].ItemArray[2];
            }
            AutoValidate = AutoValidate.Disable;
        }

        private void saveButon_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;
            string query;
            if(edit)
            {
                query = "UPDATE dishes SET dish_name = @dish_name, dish_portions = @dish_portions, cooking_time = @cooking_time, mass = @mass, recipe = @recipe, menu_section = @menu_section, dish_price = @dish_price WHERE dish_id = @dish_id";
            }
            else
            {
                query = "INSERT INTO dishes (dish_name, dish_portions, cooking_time, mass, recipe, menu_section, dish_price) VALUES (@dish_name, @dish_portions, @cooking_time, @mass, @recipe, @menu_section, @dish_price) " +
                    "SELECT SCOPE_IDENTITY();";
            }
            DataTable ds = new DataTable();
            SqlDataAdapter da;
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                //Додавання чи оновлення страви
                da = new SqlDataAdapter(query, c);
                da.SelectCommand.Parameters.AddWithValue("@dish_name", dish_nameTextBox.Text);
                da.SelectCommand.Parameters.AddWithValue("@dish_portions", dish_portionsTextBox.Value);
                da.SelectCommand.Parameters.AddWithValue("@cooking_time", cooking_timeTextBox.Value);
                da.SelectCommand.Parameters.AddWithValue("@mass", massTextBox.Value);
                da.SelectCommand.Parameters.AddWithValue("@recipe", recipeTextBox.Text);
                da.SelectCommand.Parameters.AddWithValue("@menu_section", menu_sectionComboBox.SelectedItem);
                da.SelectCommand.Parameters.AddWithValue("@dish_price", dish_priceTextBox.Value);
                da.SelectCommand.Parameters.AddWithValue("@dish_id", dish_id);
                da.Fill(ds);
            }
            //Визначення ідентифікатора поточної страви
            string a = dish_id.ToString();
            if (!edit)
            {
                a = ds.Rows[0].ItemArray[0].ToString();
            }

            //Видалення  старих інгредієнтів з таблиці ingredients
            query = "DELETE FROM ingredients WHERE dish_id = @dish_id";
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@dish_id", a);
                cmd.ExecuteNonQuery();
            }

            //Додавання нових інгредієнтів
            using (SqlConnection c = new SqlConnection(connectionstring))
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                query = "INSERT INTO ingredients (type_id, dish_id, ingredient_amount) VALUES (@type_id, @dish_id, @ingredient_amount)";
                using (var cmd = c.CreateCommand())
                {
                    if (c.State != ConnectionState.Open)
                    {
                        c.Open();
                    }
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@type_id", dataGridView.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@dish_id", a);
                    cmd.Parameters.AddWithValue("@ingredient_amount", float.Parse(dataGridView.Rows[i].Cells[1].Value.ToString()));

                    cmd.ExecuteNonQuery();
                }
            }

            //Визначення енергетичної вартості страви
            float sum_energy_value = 0;
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                query = "SELECT SUM(types_of_products.energy_value * ingredients.ingredient_amount)/dishes.dish_portions FROM types_of_products JOIN ingredients ON types_of_products.type_id = ingredients.type_id JOIN dishes ON ingredients.dish_id = dishes.dish_id WHERE ingredients.dish_id = @dish_id GROUP BY dishes.dish_portions";
                da = new SqlDataAdapter(query, c);
                da.SelectCommand.Parameters.AddWithValue("@dish_id", a);
                ds = new DataTable();
                da.Fill(ds);
            }

            if (ds.Rows.Count != 0)
            {
                sum_energy_value = float.Parse(ds.Rows[0].ItemArray[0].ToString());
            }
            //Додавання енергетичної категорії до страви
            string energy_category;
            if (sum_energy_value <= 200)
            {
                energy_category = "низька";
            }
            else if (sum_energy_value <= 500)
            {
                energy_category = "середня";
            }
            else
            {
                energy_category = "висока";
            }
            query = "UPDATE dishes SET energy_category = @energy_category WHERE dish_id = @dish_id";
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@energy_category", energy_category);
                cmd.Parameters.AddWithValue("@dish_id", a);
                cmd.ExecuteNonQuery();
            }
            saved = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dishes_AddEdit_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && MessageBox.Show($"Ви дійсно бажаєте закрити це вікно? В такому разі ваші зміни не буде збережено.", "Вихід", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
        private void FillComboBox()
        {
            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dataGridView.Columns[0];
            string select = "SELECT type_id, type_name FROM types_of_products";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                column.DataSource = ds;
                column.DisplayMember = "type_name";
                column.ValueMember = "type_id";
            }
        }
        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                savedIndex = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int value = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);

                //Визначення одиниці вимірювання
                string select = $"SELECT units_of_measurement FROM types_of_products WHERE type_id = {value}";
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter da = new SqlDataAdapter(select, c);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView.Rows[e.RowIndex].Cells[2].Value = ds.Rows[0].ItemArray[0];
                }

                //Пошук дублікатів
                int counter = 0;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView.Rows[i].Cells[0].Value) == value)
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    MessageBox.Show("Інгредієнт, який ви намагаєтесь обрати, вже присутній в страві", "", MessageBoxButtons.OK);
                    if (savedIndex == 0)
                    {
                        dataGridView.Rows[e.RowIndex].Cells[0].Value = null;
                        return;
                    }
                    dataGridView.Rows[e.RowIndex].Cells[0].Value = savedIndex;
                }
            }
            if(dataGridView.Rows[e.RowIndex].Cells[0].Value == null || dataGridView.Rows[e.RowIndex].Cells[1].Value == null || !float.TryParse(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), out float a))
            {
                dataGridView.Rows[e.RowIndex].Cells[3].Value = "*";
            }
            else
            {
                dataGridView.Rows[e.RowIndex].Cells[3].Value = "";
            }
            showWarning();
        }

        private void add_rowButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value == null || dataGridView.Rows[i].Cells[1].Value == null)
                {
                    return;
                }
            }
            dataGridView.Rows.Add();
            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[3].Value = "*";
            showWarning();
        }

        private void delete_rowButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
            }
            showWarning();
        }
        private void dish_nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dish_nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dish_nameTextBox, "Поле не повинно бути пустим");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dish_nameTextBox, "");
            }
        }
        private void menu_sectionComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (menu_sectionComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(menu_sectionComboBox, "Оберіть один з варіантів розділу меню");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(menu_sectionComboBox, "");
            }
        }

        private void dataGridView_Validating(object sender, CancelEventArgs e)
        {
            int countInvalidRows = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[3].Value != null && dataGridView.Rows[i].Cells[3].Value.ToString() != "")
                {
                    countInvalidRows++;
                }
            }
            if (countInvalidRows > 0)
            {
                e.Cancel = true;
                MessageBox.Show("Неможливо зберегти страву, адже серед доданих інгредієнтів присутні хибні дані", "", MessageBoxButtons.OK);
                return;
            }
            e.Cancel = false;
        }
        private void showWarning()
        {
            int countInvalidRows = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[3].Value != null && dataGridView.Rows[i].Cells[3].Value.ToString() != "")
                {
                    countInvalidRows++;
                }
            }
            if (countInvalidRows > 0)
            {
                warningLabel.Visible = true;
            }
            else
            {
                warningLabel.Visible = false;
            }
        }
    }
}
