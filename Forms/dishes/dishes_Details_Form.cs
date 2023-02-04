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
    public partial class dishes_Details_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        int dish_id;
        public dishes_Details_Form(int dish_id, string connectionstring)
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

            this.dish_id = dish_id;
            dish_nameTextBox.Text = dish_name;
            dish_portionsTextBox.Text = dish_portions.ToString();
            cooking_timeTextBox.Text = cooking_time.ToString();
            massTextBox.Text = mass.ToString();
            recipeTextBox.Text = recipe;
            menu_sectionTextBox.Text = menu_section;
            dish_priceTextBox.Text = dish_price.ToString();

            this.Text = "Перегляд страви";

            string query = "SELECT types_of_products.type_name, ingredients.ingredient_amount, types_of_products.units_of_measurement FROM types_of_products JOIN ingredients ON types_of_products.type_id = ingredients.type_id WHERE ingredients.dish_id = @dish_id";
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
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new dish_card(dish_id, connectionstring).ShowDialog();
        }
    }
}
