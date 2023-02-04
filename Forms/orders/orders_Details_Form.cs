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
    public partial class orders_Details_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        readonly int order_id;
        public orders_Details_Form(int order_id, float order_total, DateTime order_date, bool is_completed, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            this.order_id = order_id;
            headerLabel.Text = $"Замовлення №{order_id}";
            totalTextBox.Text = order_total.ToString();
            order_dateTextBox.Text = order_date.ToString("g");
            if(is_completed)
            {
                is_completedTextBox.Text = "Виконане";
            }
            else
            {
                is_completedTextBox.Text = "Не виконане";
            }

            this.Text = "Перегляд замовлення";

            string query = "SELECT dishes.dish_name, order_items.order_item_portions FROM order_items JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE order_items.order_id = @order_id";
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
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void make_invoiceButton_Click(object sender, EventArgs e)
        {
            //Знаходить чи достатньо для даного замовлення товарів на складі
            string select = "SELECT orders.order_id, MIN(S1.SumAmount) FROM orders JOIN "+
                            "(SELECT orders.order_id, " +
                            "(CASE WHEN SUM(CAST(order_items.order_item_portions AS float) / dishes.dish_portions * ingredients.ingredient_amount) > T1.AvailableAmount " +
                            "THEN 0 ELSE SUM(CAST(order_items.order_item_portions AS float) / dishes.dish_portions * ingredients.ingredient_amount) END) AS SumAmount, " +
                            "ingredients.type_id " +
                            "FROM orders JOIN order_items ON orders.order_id = order_items.order_id " +
                            "JOIN dishes ON order_items.dish_id = dishes.dish_id " +
                            "JOIN ingredients ON dishes.dish_id = ingredients.dish_id " +
                            "JOIN(SELECT types_of_products.type_id, " +
                            "(CASE WHEN SUM(products.product_amount) IS NULL THEN 0 ELSE SUM(products.product_amount) END) AS AvailableAmount " +
                            "FROM types_of_products LEFT JOIN products ON types_of_products.type_id = products.type_id " +
                            "GROUP BY types_of_products.type_id) AS T1 ON ingredients.type_id = T1.type_id " +
                            "GROUP BY orders.order_id, ingredients.type_id, T1.AvailableAmount) " +
                            "AS S1 ON orders.order_id = S1.order_id " +
                            "WHERE orders.order_id = @order_id " +
                            "GROUP BY orders.order_id " +
                            "HAVING MIN(S1.SumAmount) = 0";
            DataTable dt = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@order_id", order_id);
                da.Fill(dt);
            } 
            if(dt.Rows.Count == 0)
            {
                new invoice(order_id, connectionstring).ShowDialog();
                return;
            }
            MessageBox.Show("Для даного замовлення неможливо сформувати накладну, адже на складі недостатньо продуктів", "", MessageBoxButtons.OK);
        }
    }
}
