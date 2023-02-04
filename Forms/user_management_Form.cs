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
using System.IO;

namespace chef
{
    public partial class user_management_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        string login_id;
        main_Form parent_Form;
        public user_management_Form(string login, main_Form parent_Form, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            this.login_id = login;
            label2.Text = login;
            this.parent_Form = parent_Form;
            FillFirstDataGrid();
            if (login != "admin")
            {
                tabControl1.Controls.Remove(tabControl1.TabPages[2]);
                tabControl1.Controls.Remove(tabControl1.TabPages[2]);
                tabControl1.Controls.Remove(tabControl1.TabPages[2]);
            }
            else
            {
                linkLabel1.Visible = false;
            }
            string select = "SELECT is_admin FROM users WHERE login = @login";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                DataTable ds;
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@login", login_id);
                ds = new DataTable();
                da.Fill(ds);
                if(ds.Rows[0].ItemArray[0].ToString() == "False")
                {
                    tabControl1.Controls.Remove(tabControl1.TabPages[1]);
                }
            }
            FillSecondDataGrid();
            FillThirdDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Пароль не може бути пустим чи складатися з пробілів");
                return;
            }
            label5.Visible = false;
            string select = "SELECT password FROM users WHERE login = @login AND password = @password";
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                DataTable ds;
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@login", login_id);
                da.SelectCommand.Parameters.AddWithValue("@password", textBox1.Text);
                ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count == 0)
                {
                    label5.Text = "Хибний старий пароль";
                    label5.Visible = true;
                    return;
                }
                if (textBox2.Text != textBox3.Text)
                {
                    label5.Text = "Введені паролі відрізняються";
                    label5.Visible = true;
                    return;
                }
                if (MessageBox.Show("Ви підтверджуєте зміну пароля?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                select = "UPDATE users SET password = @password WHERE login = @login";
                da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@login", login_id);
                da.SelectCommand.Parameters.AddWithValue("@password", textBox2.Text);
                ds = new DataTable();
                da.Fill(ds);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Пароль успішно змінено!");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Ви справді хочете видалити акаунт?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                string select = "DELETE FROM users WHERE login = @login";
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@login", login_id);
                DataTable ds = new DataTable();
                da.Fill(ds);
            }
            MessageBox.Show("Акаунт успішно видалено!");
            parent_Form.ShowGreeting("");
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show($"Ви точно хочете надати права адміністратора користувачу \"{dataGridView1.Rows[e.RowIndex].Cells[0].Value}\"?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    string select = "UPDATE users SET is_admin = 1 WHERE login = @login";
                    SqlDataAdapter da = new SqlDataAdapter(select, c);
                    da.SelectCommand.Parameters.AddWithValue("@login", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                }
                FillFirstDataGrid();
                FillSecondDataGrid();
                MessageBox.Show("Права успішно надано!");
            }
        }
        private void FillFirstDataGrid()
        {
            dataGridView1.Rows.Clear();
            DataTable ds;
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                string select = "SELECT login FROM users WHERE is_admin = 0 OR is_admin IS NULL";
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@login", login_id);
                ds = new DataTable();
                da.Fill(ds);
            }
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(ds.Rows[i].ItemArray[0], "Надати права адміна");
                dataGridView1.Rows[i].Height = 45;
            }
        }
        private void FillSecondDataGrid()
        {
            dataGridView2.Rows.Clear();
            DataTable ds;
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                string select = "SELECT login FROM users WHERE is_admin = 1 AND login <> 'admin'";
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@login", login_id);
                ds = new DataTable();
                da.Fill(ds);
            }
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                dataGridView2.Rows.Add(ds.Rows[i].ItemArray[0], "Забрати права адміна");
                dataGridView2.Rows[i].Height = 45;
            }
        }
        private void FillThirdDataGrid()
        {
            dataGridView3.Rows.Clear();
            DataTable ds;
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                string select = "SELECT login FROM users WHERE login <> 'admin'";
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                ds = new DataTable();
                da.Fill(ds);
            }
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                dataGridView3.Rows.Add(ds.Rows[i].ItemArray[0], "Видалити");
                dataGridView3.Rows[i].Height = 45;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show($"Ви точно хочете забрати права адміністратора в користувача \"{dataGridView2.Rows[e.RowIndex].Cells[0].Value}\"?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    string select = "UPDATE users SET is_admin = 0 WHERE login = @login";
                    SqlDataAdapter da = new SqlDataAdapter(select, c);
                    da.SelectCommand.Parameters.AddWithValue("@login", dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                }
                FillFirstDataGrid();
                FillSecondDataGrid();
                MessageBox.Show("Права успішно забрано!");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show($"Ви точно хочете видалити користувача \"{dataGridView3.Rows[e.RowIndex].Cells[0].Value}\"?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    string select = "DELETE FROM users WHERE login = @login";
                    SqlDataAdapter da = new SqlDataAdapter(select, c);
                    da.SelectCommand.Parameters.AddWithValue("@login", dataGridView3.Rows[e.RowIndex].Cells[0].Value);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                }
                FillFirstDataGrid();
                FillSecondDataGrid();
                FillThirdDataGrid();
                MessageBox.Show("Користувача успішно видалено!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM dishes";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SqlConnection c = new SqlConnection(textBox4.Text))
                {
                    SqlDataAdapter da = new SqlDataAdapter(select, c);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    select = "SELECT * FROM ingredients";
                    da = new SqlDataAdapter(select, c);
                    ds = new DataTable();
                    da.Fill(ds);
                    select = "SELECT * FROM order_items";
                    da = new SqlDataAdapter(select, c);
                    ds = new DataTable();
                    da.Fill(ds);
                    select = "SELECT * FROM orders";
                    da = new SqlDataAdapter(select, c);
                    ds = new DataTable();
                    da.Fill(ds);
                    select = "SELECT * FROM products";
                    da = new SqlDataAdapter(select, c);
                    ds = new DataTable();
                    da.Fill(ds);
                    select = "SELECT * FROM specials";
                    da = new SqlDataAdapter(select, c);
                    ds = new DataTable();
                    da.Fill(ds);
                    select = "SELECT * FROM types_of_products";
                    da = new SqlDataAdapter(select, c);
                    ds = new DataTable();
                    da.Fill(ds);
                    select = "SELECT * FROM users";
                    da = new SqlDataAdapter(select, c);
                    ds = new DataTable();
                    da.Fill(ds);
                }
            }
            catch
            {
                MessageBox.Show("Рядок підключення введено у хибному форматі, або стосується іншої бази даних");
                return;
            }
            Cursor.Current = Cursors.Default;
            string file_path = Application.StartupPath + "\\conn.txt";
            using (StreamWriter writer = new StreamWriter(file_path))
            {
                writer.WriteLine(textBox4.Text);
            }
            parent_Form.connectionstring = textBox4.Text;
            MessageBox.Show("Рядок підключення успішно збережено!");
            textBox4.Text = "";
        }
    }
}
