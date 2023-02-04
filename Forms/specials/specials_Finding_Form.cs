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
    public partial class specials_Finding_Form : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        int dish_id1 = -1;
        int dish_id2 = -1;
        int dish_id3 = -1;
        public specials_Finding_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
        }

        private void find_specialButton_Click(object sender, EventArgs e)
        {
            if(menu_sectionComboBox.SelectedIndex == -1)
            {
                return;
            }
            dishLabel1.Visible = false;
            dishLabel2.Visible = false;
            dishLabel3.Visible = false;

            dishLabel1.Enabled = false;
            dishLabel2.Enabled = false;
            dishLabel3.Enabled = false;

            priceTextBox1.Visible = false;
            priceTextBox2.Visible = false;
            priceTextBox3.Visible = false;

            priceTextBox1.Enabled = false;
            priceTextBox2.Enabled = false;
            priceTextBox3.Enabled = false;

            dishButton1.Enabled = false;
            dishButton2.Enabled = false;
            dishButton3.Enabled = false;

            dishButton1.Visible = false;
            dishButton2.Visible = false;
            dishButton3.Visible = false;

            string countSoldPortions = "SELECT dishes.dish_id, SUM(order_items.order_item_portions) AS CountedOrders FROM order_items JOIN dishes ON order_items.dish_id = dishes.dish_id WHERE dishes.menu_section = @menu_section GROUP BY dishes.dish_id ORDER BY CountedOrders";
            DataTable countedSoldPortions = new DataTable();

            string countContributionMargin = "SELECT dishes.dish_id, CASE WHEN dishes.dish_price - SUM(Q1.AveragePrice) IS NULL THEN 0 ELSE dishes.dish_price - SUM(Q1.AveragePrice) END AS Margin " +
                                            "FROM(SELECT dishes.dish_id, AVG(products.product_price) * ingredients.ingredient_amount AS AveragePrice " +
                                            "FROM dishes JOIN ingredients ON dishes.dish_id = ingredients.dish_id "+
                                            "LEFT JOIN products ON ingredients.type_id = products.type_id "+
                                            "GROUP BY dishes.dish_id, ingredients.type_id, ingredients.ingredient_amount) Q1 " +
                                            "JOIN dishes ON Q1.dish_id = dishes.dish_id "+
                                            "WHERE dishes.menu_section = @menu_section "+
                                            "GROUP BY dishes.dish_id, dishes.dish_price "+
                                            "ORDER BY Margin DESC";
            DataTable countedContributionMargin = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(countSoldPortions, c);
                da.SelectCommand.Parameters.AddWithValue("@menu_section", menu_sectionComboBox.SelectedItem);
                da.Fill(countedSoldPortions);

                da = new SqlDataAdapter(countContributionMargin, c);
                da.SelectCommand.Parameters.AddWithValue("@menu_section", menu_sectionComboBox.SelectedItem);
                da.Fill(countedContributionMargin);
            }
            List<float[]> CountedPoints = new List<float[]>(); 
            for (int i = 0; i < countedSoldPortions.Rows.Count; i++)
            {
                for (int j = 0; j < countedContributionMargin.Rows.Count; j++)
                {
                    if (countedSoldPortions.Rows[i].ItemArray[0].ToString() == countedContributionMargin.Rows[j].ItemArray[0].ToString())
                    {
                        CountedPoints.Add(new float[] { Convert.ToInt32(countedSoldPortions.Rows[i].ItemArray[0]), ((float)(countedSoldPortions.Rows.Count - i) / (float)countedSoldPortions.Rows.Count) * ((float)(countedContributionMargin.Rows.Count - j) / (float)countedContributionMargin.Rows.Count) });
                    }
                }
            }
            if(check_storageCheckBox.Checked)
            {
                string countAvailablePortions = "SELECT dishes.dish_id, MIN(Q1.PortionsAvailable) AS Portions " +
                                        "FROM(SELECT dishes.dish_id, ingredients.type_id, " +
                                        "CASE WHEN SUM(products.product_amount) / ingredients.ingredient_amount IS NULL THEN 0 ELSE SUM(products.product_amount) / ingredients.ingredient_amount END AS PortionsAvailable " +
                                        "FROM dishes JOIN ingredients ON dishes.dish_id = ingredients.dish_id " +
                                        "LEFT JOIN products ON ingredients.type_id = products.type_id " +
                                        "GROUP BY dishes.dish_id, ingredients.type_id, ingredient_amount) Q1 " +
                                        "JOIN dishes ON Q1.dish_id = dishes.dish_id " +
                                        "WHERE dishes.menu_section = @menu_section " +
                                        "GROUP BY dishes.dish_id " +
                                        "ORDER BY Portions DESC ";
                DataTable countedAvailablePortions = new DataTable();
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter da = new SqlDataAdapter(countAvailablePortions, c);
                    da.SelectCommand.Parameters.AddWithValue("@menu_section", menu_sectionComboBox.SelectedItem);
                    da.Fill(countedAvailablePortions);
                }
                for (int i = 0; i < CountedPoints.Count; i++)
                {
                    for (int j = 0; j < countedAvailablePortions.Rows.Count; j++)
                    {
                        if (CountedPoints[i][0] == Convert.ToInt32(countedAvailablePortions.Rows[j].ItemArray[0]))
                        {
                            if (Convert.ToInt32(countedAvailablePortions.Rows[j].ItemArray[1]) == 0)
                            {
                                CountedPoints[i][1] = 0;
                                break;
                            }
                            CountedPoints[i][1] *= (countedAvailablePortions.Rows.Count - (float)j) / (float)countedAvailablePortions.Rows.Count;
                        }
                    }
                }
            }
            if (check_recentlyCheckBox.Checked)
            {
                string countRecentSpecials = "SELECT dishes.dish_id FROM dishes JOIN specials ON dishes.dish_id = specials.dish_id " +
                                                "WHERE specials.special_date BETWEEN DATEADD(day, -7, GETDATE()) AND GETDATE()";
                DataTable countedRecentSpecials = new DataTable();
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter da = new SqlDataAdapter(countRecentSpecials, c);
                    da.Fill(countedRecentSpecials);
                }
                for (int i = 0; i < CountedPoints.Count; i++)
                {
                    for (int j = 0; j < countedRecentSpecials.Rows.Count; j++)
                    {
                        if (CountedPoints[i][0] == Convert.ToInt32(countedRecentSpecials.Rows[j].ItemArray[0]))
                        {
                            CountedPoints[i][1] = 0;
                        }
                    }
                }
            }
            CountedPoints = CountedPoints.OrderByDescending(x => x[1]).ToList();

            if (CountedPoints.Count > 0)
            {
                if (CountedPoints[0][1] == 0)
                    return;
                dishHeaderLabel.Visible = true;
                priceHeaderLabel.Visible = true;
                string select1 = "SELECT dish_id, dish_name, dish_price FROM dishes WHERE dish_id = @dish_id";
                DataTable selected1 = new DataTable();
                using (SqlConnection c = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter da = new SqlDataAdapter(select1, c);
                    da.SelectCommand.Parameters.AddWithValue("dish_id", CountedPoints[0][0]);
                    da.Fill(selected1);
                }
                dish_id1 = Convert.ToInt32(selected1.Rows[0].ItemArray[0]);
                dishLabel1.Text = selected1.Rows[0].ItemArray[1].ToString();
                int i = 0;
                for (i = 0; i < countedContributionMargin.Rows.Count; i++)
                {
                    if (float.Parse(countedContributionMargin.Rows[i].ItemArray[0].ToString()) == CountedPoints[0][0])
                    {
                        break;
                    }
                }
                priceTextBox1.Value = Math.Round(decimal.Parse(selected1.Rows[0].ItemArray[2].ToString()) - decimal.Parse(countedContributionMargin.Rows[i].ItemArray[1].ToString()) * (decimal)0.8, 2);
                dishLabel1.Visible = true;
                dishLabel1.Enabled = true;
                priceTextBox1.Visible = true;
                priceTextBox1.Enabled = true;
                dishButton1.Enabled = true;
                dishButton1.Visible = true;
                if (CountedPoints.Count > 1)
                {
                    if (CountedPoints[1][1] == 0)
                        return;
                    DataTable selected2 = new DataTable();
                    using (SqlConnection c = new SqlConnection(connectionstring))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select1, c);
                        da.SelectCommand.Parameters.AddWithValue("dish_id", CountedPoints[1][0]);
                        da.Fill(selected2);
                    }
                    dish_id2 = Convert.ToInt32(selected2.Rows[0].ItemArray[0]);
                    dishLabel2.Text = selected2.Rows[0].ItemArray[1].ToString();
                    i = 0;
                    for (i = 0; i < countedContributionMargin.Rows.Count; i++)
                    {
                        if (float.Parse(countedContributionMargin.Rows[i].ItemArray[0].ToString()) == CountedPoints[1][0])
                        {
                            break;
                        }
                    }
                    priceTextBox2.Value = Math.Round(decimal.Parse(selected2.Rows[0].ItemArray[2].ToString()) - decimal.Parse(countedContributionMargin.Rows[i].ItemArray[1].ToString()) * (decimal)0.8, 2);
                    dishLabel2.Visible = true;
                    dishLabel2.Enabled = true;
                    priceTextBox2.Visible = true;
                    priceTextBox2.Enabled = true;
                    dishButton2.Enabled = true;
                    dishButton2.Visible = true;
                    if(CountedPoints.Count > 2)
                    {
                        if (CountedPoints[2][1] == 0)
                            return;
                        DataTable selected3 = new DataTable();
                        using (SqlConnection c = new SqlConnection(connectionstring))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(select1, c);
                            da.SelectCommand.Parameters.AddWithValue("dish_id", CountedPoints[2][0]);
                            da.Fill(selected3);
                        }
                        dish_id3 = Convert.ToInt32(selected3.Rows[0].ItemArray[0]);
                        dishLabel3.Text = selected3.Rows[0].ItemArray[1].ToString();
                        i = 0;
                        for (i = 0; i < countedContributionMargin.Rows.Count; i++)
                        {
                            if (float.Parse(countedContributionMargin.Rows[i].ItemArray[0].ToString()) == CountedPoints[2][0])
                            {
                                break;
                            }
                        }
                        decimal a = Math.Round(decimal.Parse(selected3.Rows[0].ItemArray[2].ToString()) - decimal.Parse(countedContributionMargin.Rows[i].ItemArray[1].ToString()) * (decimal)0.8, 2);
                        if (a > 0)
                        {
                            priceTextBox3.Value = a;
                        }
                        else
                        {
                            priceTextBox3.Value = decimal.Parse(selected3.Rows[0].ItemArray[2].ToString());
                        }
                        dishLabel3.Visible = true;
                        dishLabel3.Enabled = true;
                        priceTextBox3.Visible = true;
                        priceTextBox3.Enabled = true;
                        dishButton3.Enabled = true;
                        dishButton3.Visible = true;
                    }
                }
            }
        }

        private void dishButton1_Click(object sender, EventArgs e)
        {
            dishButton2.Enabled = false;
            dishButton3.Enabled = false;
            string query = "INSERT INTO specials (dish_id, special_price, special_date) VALUES (@dish_id, @special_price, @special_date)";
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                if (c.State != ConnectionState.Open)
                {
                    c.Open();
                }
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@dish_id", dish_id1);
                cmd.Parameters.AddWithValue("@special_price", priceTextBox1.Value);
                cmd.Parameters.AddWithValue("@special_date", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
            Close();
        }
        private void dishButton2_Click(object sender, EventArgs e)
        {
            dishButton1.Enabled = false;
            dishButton3.Enabled = false;
            string query = "INSERT INTO specials (dish_id, special_price, special_date) VALUES (@dish_id, @special_price, @special_date)";
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                if (c.State != ConnectionState.Open)
                {
                    c.Open();
                }
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@dish_id", dish_id2);
                cmd.Parameters.AddWithValue("@special_price", priceTextBox2.Value);
                cmd.Parameters.AddWithValue("@special_date", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
            Close();
        }
        private void dishButton3_Click(object sender, EventArgs e)
        {
            dishButton1.Enabled = false;
            dishButton2.Enabled = false;
            string query = "INSERT INTO specials (dish_id, special_price, special_date) VALUES (@dish_id, @special_price, @special_date)";
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                if (c.State != ConnectionState.Open)
                {
                    c.Open();
                }
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@dish_id", dish_id3);
                cmd.Parameters.AddWithValue("@special_price", priceTextBox3.Value);
                cmd.Parameters.AddWithValue("@special_date", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
            Close();
        }
    }
}
