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

namespace chef
{
    public partial class queries_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";

        public queries_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    doFirstQuery();
                    break;
                case 1:
                    doSecondQuery();
                    break;
                case 2:
                    doThirdQuery();
                    break;
                case 3:
                    doFourthQuery();
                    break;
            }
            label1.Visible = false;
        }
        private void doFirstQuery()
        {
            chart1.Visible = false;
            string select = "SELECT D1.dish_name, D1.mass, D1.menu_section, SUM(order_items.order_item_portions), " +
                "CAST(SUM(order_items.order_item_portions) AS float(1)) * CAST(D1.mass AS float(1)) / CAST(D1.dish_portions AS float(1)) " +
                "FROM order_items JOIN dishes D1 ON order_items.dish_id = D1.dish_id " +
                "GROUP BY D1.dish_name, D1.mass, D1.menu_section, D1.dish_portions " +
                "HAVING SUM(order_items.order_item_portions) >= ALL(SELECT SUM(order_items.order_item_portions) FROM order_items JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE dishes.menu_section = D1.menu_section GROUP BY dishes.dish_name)";

            fillDataGrid(select, out DataTable ds);

            dataGridView.Columns[0].HeaderText = "Назва страви";
            dataGridView.Columns[1].HeaderText = "Маса, г";
            dataGridView.Columns[2].HeaderText = "Розділ меню";
            dataGridView.Columns[3].HeaderText = "Кількість проданих порцій";
            dataGridView.Columns[4].HeaderText = "Вага проданих порцій";

            dataGridView.Columns[1].FillWeight = dataGridView.Columns[0].FillWeight / 3;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void doSecondQuery()
        {
            chart1.Visible = false;
            string select = "SELECT dishes.dish_name, COUNT(DISTINCT Q2.special_id), ROUND(SUM(Q2.Price), 2) AS TotalMargin FROM dishes JOIN ( " +
                            "SELECT specials.special_id, specials.dish_id,  " +
                            "ROUND((specials.special_price - SUM(Q1.AveragePrice))/ dishes.dish_portions * order_items.order_item_portions * COUNT(DISTINCT order_items.order_id), 2) AS Price FROM( " +
                            "SELECT dishes.dish_id, AVG(products.product_price) * ingredients.ingredient_amount AS AveragePrice " +
                            "FROM dishes JOIN ingredients ON dishes.dish_id = ingredients.dish_id " +
                            "LEFT JOIN products ON ingredients.type_id = products.type_id " +
                            "GROUP BY dishes.dish_id, ingredients.type_id, ingredients.ingredient_amount " +
                            ") Q1 JOIN specials ON Q1.dish_id = specials.dish_id " +
                            "JOIN dishes ON dishes.dish_id = specials.dish_id " +
                            "JOIN order_items ON order_items.dish_id = dishes.dish_id " +
                            "JOIN orders ON orders.order_id = order_items.order_id " +
                            "WHERE CONVERT(date, orders.order_date, 101) = CONVERT(date, specials.special_date, 101) " +
                            "GROUP BY specials.dish_id, specials.special_price, dishes.dish_portions, order_items.order_item_portions, specials.special_id " +
                            ") Q2 ON dishes.dish_id = Q2.dish_id " +
                            "GROUP BY dishes.dish_name " +
                            "ORDER BY MAX(Q2.Price) DESC";
            fillDataGrid(select, out DataTable ds);

            dataGridView.Columns[0].HeaderText = "Назва страви";
            dataGridView.Columns[1].HeaderText = "Була стравою дня, рази";
            dataGridView.Columns[2].HeaderText = "Загальний виторг";
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void doThirdQuery()
        {
            Cursor.Current = Cursors.WaitCursor;
            chart1.Visible = true;
            string select = "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '00:00-03:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 0 AND 2 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 0 AND 2 GROUP BY dishes.menu_section) " +
                            "UNION " +
                            "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '03:00-06:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 3 AND 5 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 3 AND 5 GROUP BY dishes.menu_section) " +
                            "UNION " +
                            "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '06:00-09:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 6 AND 8 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 6 AND 8 GROUP BY dishes.menu_section) " +
                            "UNION " +
                            "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '09:00-12:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 9 AND 11 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 9 AND 11 GROUP BY dishes.menu_section) " +
                            "UNION " +
                            "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '12:00-15:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 12 AND 14 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 12 AND 14 GROUP BY dishes.menu_section) " +
                            "UNION " +
                            "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '15:00-18:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 15 AND 17 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 15 AND 17 GROUP BY dishes.menu_section) " +
                            "UNION " +
                            "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '18:00-21:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 18 AND 20 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 18 AND 20 GROUP BY dishes.menu_section) " +
                            "UNION " +
                            "SELECT TOP 1 dishes.menu_section, COUNT(DISTINCT orders.order_id) AS ordersCount, '21:00-24:00' AS time FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 21 AND 23 GROUP BY dishes.menu_section " +
                            "HAVING COUNT(DISTINCT orders.order_id) >= ALL(SELECT COUNT(DISTINCT orders.order_id) FROM orders JOIN order_items ON orders.order_id = order_items.order_id JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE DATEPART(hh, orders.order_date) BETWEEN 21 AND 23 GROUP BY dishes.menu_section) " +
                            "ORDER BY time ";

            fillDataGrid(select, out DataTable ds);

            dataGridView.Columns[0].HeaderText = "Розділ меню";
            dataGridView.Columns[1].HeaderText = "Кількість замовлень";
            dataGridView.Columns[2].HeaderText = "Часовий проміжок";

            dataGridView.Columns[1].FillWeight = dataGridView.Columns[0].FillWeight / 2;


            chart1.Series.Clear();
            chart1.DataSource = ds;
            chart1.Series.Add("ordersCount");
            chart1.Series["ordersCount"].YValueMembers = "ordersCount";
            chart1.Series["ordersCount"].XValueMember = "time";
            chart1.Series["ordersCount"].LegendText = "Кількість замовлень";
            chart1.Series["ordersCount"].IsVisibleInLegend = false;
            chart1.Series["ordersCount"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            Cursor.Current = Cursors.Default;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void doFourthQuery()
        {
            Cursor.Current = Cursors.WaitCursor;
            chart1.Visible = true;
            string select = "SELECT TOP 6 types_of_products.type_name, COUNT(DISTINCT order_items.order_id) AS ordersCount, ROUND(SUM(ingredients.ingredient_amount), 2) AS total_mass, types_of_products.units_of_measurement " +
                "FROM types_of_products JOIN ingredients ON types_of_products.type_id = ingredients.type_id " +
                "JOIN dishes ON ingredients.dish_id = dishes.dish_id JOIN order_items ON dishes.dish_id = order_items.dish_id " +
                "GROUP BY types_of_products.type_name, types_of_products.units_of_measurement " +
                "ORDER BY COUNT(DISTINCT order_items.order_id) DESC";

            fillDataGrid(select, out DataTable ds);

            dataGridView.Columns[0].HeaderText = "Інгредієнт";
            dataGridView.Columns[1].HeaderText = "Кількість замовлень";
            dataGridView.Columns[2].HeaderText = "Кількість";
            dataGridView.Columns[3].HeaderText = "Одиниці вимірювання";

            dataGridView.Columns[1].FillWeight = dataGridView.Columns[0].FillWeight / 2;

            chart1.Series.Clear();
            chart1.DataSource = ds;
            chart1.Series.Add("ordersCount");
            chart1.Series["ordersCount"].YValueMembers = "ordersCount";
            chart1.Series["ordersCount"].XValueMember = "type_name";
            chart1.Series["ordersCount"].LabelForeColor = Color.White;
            chart1.Series["ordersCount"].Font = new Font("verdana", 11, FontStyle.Bold);
            chart1.Series["ordersCount"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Cursor.Current = Cursors.Default;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void fillDataGrid(string query, out DataTable ds)
        {
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, c);
                ds = new DataTable();
                da.Fill(ds);
                dataGridView.DataSource = ds;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
