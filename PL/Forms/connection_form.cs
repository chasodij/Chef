using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace chef
{
    public partial class connection_form : Form
    {
        main_Form parent;
        public connection_form(main_Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM dishes";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SqlConnection c = new SqlConnection(textBox1.Text))
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
                writer.WriteLine(textBox1.Text);
            }
            parent.connectionstring = textBox1.Text;
            MessageBox.Show("Рядок підключення успішно збережено!");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.Close();
            Close();
        }
    }
}
