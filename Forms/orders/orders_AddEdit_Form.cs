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
    public partial class orders_AddEdit_Form : Form
    {
        readonly int order_id;
        readonly bool edit = false;
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool saved = false;
        int savedIndex = 0;
        int numericIndexX = 0, numericIndexY = 0;

        public orders_AddEdit_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            FillComboBox();
            saveButon.Text = "Створити";
            this.Text = "Створення замовлення";
            order_dateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            AutoValidate = AutoValidate.Disable;
        }
        public orders_AddEdit_Form(int order_id, DateTime order_date, bool is_completed, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            FillComboBox();

            edit = true;
            this.order_id = order_id;
            order_dateDateTimePicker.Value = order_date;
            is_completedCheckBox.Checked = is_completed;

            saveButon.Text = "Зберегти";
            this.Text = "Редагування замовлення";
            headerLabel.Text = $"Замовлення №{order_id}";

            dataGridView.Columns[2].DefaultCellStyle.ForeColor = Color.FromArgb(207, 46, 5);
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            order_dateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            string query = "SELECT order_items.dish_id, order_items.order_item_portions, dishes.dish_portions FROM order_items JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE order_items.order_id = @order_id";
            DataTable ds = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, c);
                da.SelectCommand.Parameters.AddWithValue("@order_id", order_id);
                da.Fill(ds);
            }
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = ds.Rows[i].ItemArray[0];
                dataGridView.Rows[i].Cells[1].Value = ds.Rows[i].ItemArray[1];
                dataGridView.Rows[i].Cells[3].Value = ds.Rows[i].ItemArray[2];
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
                query = "UPDATE orders SET order_date = @order_date, is_completed = @is_completed WHERE order_id = @order_id";
            }
            else
            {
                query = "INSERT INTO orders (order_date, is_completed) VALUES (@order_date, @is_completed) " +
                    "SELECT SCOPE_IDENTITY();";
            }
            DataTable ds;
            SqlDataAdapter da;
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                //Додавання чи оновлення замовлення
                da = new SqlDataAdapter(query, c);

                da.SelectCommand.Parameters.AddWithValue("@order_date", order_dateDateTimePicker.Value);
                da.SelectCommand.Parameters.AddWithValue("@is_completed", is_completedCheckBox.Checked);
                da.SelectCommand.Parameters.AddWithValue("@order_id", order_id);

                ds = new DataTable();
                da.Fill(ds);
            }
            //Визначення ідентифікатора поточної страви
            string a = order_id.ToString();
            if (!edit)
            {
                a = ds.Rows[0].ItemArray[0].ToString();
            }

            //Видалення старих позицій замовлення з таблиці order_items
            query = "DELETE FROM order_items WHERE order_id = @order_id";
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@order_id", a);
                cmd.ExecuteNonQuery();
            }

            //Додавання нових позицій замовлення
            using (SqlConnection c = new SqlConnection(connectionstring))
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                query = "INSERT INTO order_items (order_id, dish_id, order_item_portions) VALUES (@order_id, @dish_id, @order_item_portions)";
                using (var cmd = c.CreateCommand())
                {
                    if (c.State != ConnectionState.Open)
                    {
                        c.Open();
                    }
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@dish_id", dataGridView.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@order_id", a);
                    cmd.Parameters.AddWithValue("@order_item_portions", dataGridView.Rows[i].Cells[1].Value);

                    cmd.ExecuteNonQuery();
                }
            }

            //Визначення суми замовлення
            query = "UPDATE orders SET order_total = (SELECT CASE WHEN SUM(dishes.dish_price * CAST(order_items.order_item_portions AS float) / CAST(dishes.dish_portions AS float)) IS NOT NULL THEN SUM(dishes.dish_price * CAST(order_items.order_item_portions AS float) / CAST(dishes.dish_portions AS float)) ELSE 0 END FROM order_items JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE order_items.order_id = @order_id) WHERE order_id = @order_id;";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                da = new SqlDataAdapter(query, c);
                da.SelectCommand.Parameters.AddWithValue("@order_id", a);
                ds = new DataTable();
                da.Fill(ds);
            }
            saved = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void orders_AddEdit_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && MessageBox.Show($"Ви дійсно бажаєте закрити це вікно? В такому разі ваші зміни не буде збережено.", "Вихід", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
        private void FillComboBox()
        {
            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dataGridView.Columns[0];
            string select = "SELECT dish_id, dish_name FROM dishes";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                DataTable ds = new DataTable();
                da.Fill(ds);
                column.DataSource = ds;
                column.DisplayMember = "dish_name";
                column.ValueMember = "dish_id";
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int value = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);

                string select = $"SELECT dish_portions FROM dishes WHERE dish_id = {value}";
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter da = new SqlDataAdapter(select, c);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView.Rows[e.RowIndex].Cells[1].Value = ds.Rows[0].ItemArray[0];
                    dataGridView.Rows[e.RowIndex].Cells[3].Value = ds.Rows[0].ItemArray[0];
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
                    MessageBox.Show("Страва, яку ви намагаєтесь обрати, вже присутня в замовленні", "", MessageBoxButtons.OK);
                    if (savedIndex == 0)
                    {
                        dataGridView.Rows[e.RowIndex].Cells[0].Value = null;
                        return;
                    }
                    dataGridView.Rows[e.RowIndex].Cells[0].Value = savedIndex;
                }
            }
            if (dataGridView.Rows[e.RowIndex].Cells[0].Value == null || dataGridView.Rows[e.RowIndex].Cells[1].Value == null || !int.TryParse(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), out int a))
            {
                dataGridView.Rows[e.RowIndex].Cells[2].Value = "*";
            }
            else
            {
                dataGridView.Rows[e.RowIndex].Cells[2].Value = "";
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
            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[2].Value = "*";
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
        private void showWarning()
        {
            int countInvalidRows = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[2].Value != null && dataGridView.Rows[i].Cells[2].Value.ToString() != "")
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

        private void dataGridView_Validating(object sender, CancelEventArgs e)
        {
            int countInvalidRows = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[2].Value != null && dataGridView.Rows[i].Cells[2].Value.ToString() != "")
                {
                    countInvalidRows++;
                }
            }
            if (countInvalidRows > 0)
            {
                e.Cancel = true;
                MessageBox.Show("Неможливо зберегти замовлення, адже серед доданих позицій присутні хибні дані", "", MessageBoxButtons.OK);
                return;
            }
            e.Cancel = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView.Rows[numericIndexY].Cells[numericIndexX].Value = numericUpDown1.Value;
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                numericUpDown1.Visible = true;
                numericIndexX = e.ColumnIndex;
                numericIndexY = e.RowIndex;
                numericUpDown1.Location = new Point(dataGridView.Location.X + dataGridView.RowHeadersWidth + dataGridView.Columns[0].Width, dataGridView.Location.Y + dataGridView.ColumnHeadersHeight + dataGridView.Rows[0].Height * e.RowIndex - dataGridView.VerticalScrollingOffset);
                numericUpDown1.Width = dataGridView.Columns[1].Width;
                numericUpDown1.Value = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                numericUpDown1.Increment = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }
    }
}
