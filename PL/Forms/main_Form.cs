using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace chef
{
    public partial class main_Form : Form
    {
        string login = "";
        public string connectionstring = "";
        public main_Form()
        {
            InitializeComponent();
        }

        private void types_of_productsButton_Click(object sender, EventArgs e)
        {
            new types_of_products_Form(connectionstring).ShowDialog();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            new products_Form(connectionstring).ShowDialog();
        }

        private void dishesButton_Click(object sender, EventArgs e)
        {
            new dishes_Form(connectionstring).ShowDialog();
        }

        private void specialsButton_Click(object sender, EventArgs e)
        {
            new specials_Form(connectionstring).ShowDialog();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            new orders_Form(connectionstring).ShowDialog();
        }

        private void queriesButton_Click(object sender, EventArgs e)
        {
            new queries_Form(connectionstring).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new do_query_Form(login, connectionstring).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new login_Form(this, connectionstring).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new user_management_Form(login, this, connectionstring).ShowDialog();
        }
        public void ShowGreeting(string login, bool is_admin = false)
        {
            button5.Visible = true;
            if (!is_admin)
            {
                if (login != "")
                {
                    this.login = login;
                    login_label.Text = login;
                    label1.Visible = true;
                    login_label.Visible = true;
                    button4.Visible = true;
                    button3.Visible = true;
                }
                else
                {
                    label1.Visible = false;
                    login_label.Visible = false;
                    this.login = "";
                    button5.Visible = false;
                    button4.Visible = false;
                    button3.Visible = false;
                }
                button1.Visible = false;
                ordersButton.Visible = false;
                dishesButton.Visible = false;
                productsButton.Visible = false;
                queriesButton.Visible = false;
                specialsButton.Visible = false;
                types_of_productsButton.Visible = false;

                return;
            }
            this.login = login;
            login_label.Text = login;
            label1.Visible = true;
            login_label.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            ordersButton.Visible = true;
            dishesButton.Visible = true;
            productsButton.Visible = true;
            queriesButton.Visible = true;
            specialsButton.Visible = true;
            types_of_productsButton.Visible = true;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new orders_AddEdit_Form(connectionstring).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Ви точно хочете вийти з акаунту?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            ShowGreeting("");
        }

        private void main_Form_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string readText = File.ReadAllText(Application.StartupPath + "\\conn.txt").Replace(Environment.NewLine, " ");
                string select = "SELECT * FROM dishes";
                using (SqlConnection c = new SqlConnection(readText))
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
                Cursor.Current = Cursors.Default;
                connectionstring = readText;
                return;
            }
            catch
            {
                Cursor.Current = Cursors.Default;
                new connection_form(this).ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
