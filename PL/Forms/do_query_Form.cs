using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace chef
{
    public partial class do_query_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        string login;
        public do_query_Form(string login, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            this.login = login;
        }

        private void do_query_Form_Load(object sender, EventArgs e)
        {
            FillTreeView();
        }
        private void FillTreeView()
        {
            treeView1.Nodes.Clear();
            DataTable dt;
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                dt = conn.GetSchema("Columns");
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray[2].ToString() == "sysdiagrams")
                    continue;
                if (login != "admin" && dt.Rows[i].ItemArray[2].ToString() == "users")
                    continue;
                if (i == 0 || dt.Rows[i].ItemArray[2].ToString() != dt.Rows[i - 1].ItemArray[2].ToString())
                {
                    treeView1.Nodes.Add(dt.Rows[i].ItemArray[2].ToString());
                }
                treeView1.Nodes[treeView1.Nodes.Count - 1].Nodes.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        private void do_queryButton_Click(object sender, EventArgs e)
        {
            try
            {
                Regex rg = new Regex(".*users.*", RegexOptions.IgnoreCase);
                if (rg.IsMatch(richTextBox1.Text) && login != "admin")
                {
                    label1.Text = "Ви не маєте права доступу до таблиці users";
                    return;
                }
                string select = richTextBox1.Text;

                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter da = new SqlDataAdapter(select, c);

                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                }
                FillTreeView();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
