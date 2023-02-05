using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace chef
{
    public partial class login_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool isLogin = true;
        readonly main_Form parent_Form;
        public login_Form(main_Form parent_Form, string connectionstring)
        {
            InitializeComponent();
            this.parent_Form = parent_Form;
            this.connectionstring = connectionstring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                if (isLogin)
                {
                    label4.Visible = false;
                    string select = "SELECT login, password, is_admin FROM users WHERE login = @login";
                    using (SqlConnection c = new SqlConnection(connectionstring))
                    {
                        DataTable ds;
                        SqlDataAdapter da = new SqlDataAdapter(select, c);
                        da.SelectCommand.Parameters.AddWithValue("@login", textBox1.Text);
                        ds = new DataTable();
                        da.Fill(ds);
                        if (ds.Rows.Count == 0)
                        {
                            label4.Text = "Хибний логін";
                            label4.Visible = true;
                            return;
                        }
                        if (ds.Rows[0].ItemArray[1].ToString() != textBox2.Text)
                        {
                            label4.Text = "Хибний пароль";
                            label4.Visible = true;
                            return;
                        }
                        bool is_admin = false;
                        if (ds.Rows[0].ItemArray[2].ToString() == "True")
                            is_admin = true;
                        MessageBox.Show("Успішний вхід!");
                        parent_Form.ShowGreeting(textBox1.Text, is_admin);
                        Close();
                    }
                }
                else
                {
                    label5.Visible = false;
                    string select = "SELECT login FROM users WHERE login = @login";
                    using (SqlConnection c = new SqlConnection(connectionstring))
                    {
                        DataTable ds;
                        SqlDataAdapter da = new SqlDataAdapter(select, c);
                        da.SelectCommand.Parameters.AddWithValue("@login", textBox1.Text);
                        ds = new DataTable();
                        da.Fill(ds);
                        if (ds.Rows.Count > 0)
                        {
                            label5.Text = "Такий логін вже зайнятий";
                            label5.Visible = true;
                            return;
                        }
                        if (textBox2.Text != textBox3.Text)
                        {
                            label5.Text = "Введені паролі відрізняються";
                            label5.Visible = true;
                            return;
                        }
                        select = "INSERT INTO users (login, password) VALUES(@login, @password)";
                        da = new SqlDataAdapter(select, c);
                        da.SelectCommand.Parameters.AddWithValue("@login", textBox1.Text);
                        da.SelectCommand.Parameters.AddWithValue("@password", textBox2.Text);
                        ds = new DataTable();
                        da.Fill(ds);
                        MessageBox.Show("Вас успішно зареєстровано!");
                        ChangeMode();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeMode();
        }
        private void ChangeMode()
        {
            if (isLogin)
            {
                this.Height = 395;
                linkLabel1.Text = "Ви хочете увійти?";
                button1.Text = "Зареєструватися";
                button1.AutoSize = true;
                button1.AutoEllipsis = false;
                button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button1.Location = new Point(this.Width / 2 - button1.Width / 2, 241);
                linkLabel1.Location = new Point(linkLabel1.Location.X, 305);
                label4.Visible = false;
                label3.Visible = true;
                textBox3.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                isLogin = false;
            }
            else
            {
                this.Height = 330;
                linkLabel1.Text = "Ви хочете зареєструватися?";
                button1.Text = "Увійти";
                button1.Location = new Point(this.Width / 2 - button1.Width / 2, 172);
                linkLabel1.Location = new Point(linkLabel1.Location.X, 238);
                label5.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                isLogin = true;
            }
        }
        bool ValidateTextBoxes()
        {
            errorProvider1.Clear();
            bool is_valid = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Логін не може бути пустим чи складатися з пробілів");
                is_valid = false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Пароль не може бути пустим чи складатися з пробілів");
                is_valid = false;
            }
            return is_valid;
        }
    }
}
