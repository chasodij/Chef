using Microsoft.Office.Interop.Word;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace chef
{
    public partial class invoice : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        public invoice(int order_id, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            dataGridView.Columns.Add("num", "Номер");
            dataGridView.Columns.Add("name", "Назва");
            dataGridView.Columns.Add("amount", "Кількість");
            dataGridView.Columns.Add("units", "Одиниця виміру");
            dataGridView.Columns.Add("price", "Ціна");
            dataGridView.Columns.Add("total", "Сума");
            string countNeededAmount = "SELECT orders.order_id, SUM(CAST(order_items.order_item_portions AS float)/dishes.dish_portions * ingredients.ingredient_amount) AS SumAmount, " +
                        "ingredients.type_id " +
                        "FROM orders JOIN order_items ON orders.order_id = order_items.order_id " +
                        "JOIN dishes ON order_items.dish_id = dishes.dish_id " +
                        "JOIN ingredients ON dishes.dish_id = ingredients.dish_id " +
                        "WHERE orders.order_id = @order_id " +
                        "GROUP BY orders.order_id, ingredients.type_id " +
                        "ORDER BY ingredients.type_id";
            string countAvailableProducts = "SELECT products.type_id, products.product_name, types_of_products.units_of_measurement, product_price, products.product_amount FROM products JOIN types_of_products ON products.type_id = types_of_products.type_id ORDER BY products.type_id, product_price";
            System.Data.DataTable countedNeededAmount = new System.Data.DataTable();
            System.Data.DataTable countedAvailableProducts = new System.Data.DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(countNeededAmount, c);
                da.SelectCommand.Parameters.AddWithValue("@order_id", order_id);
                da.Fill(countedNeededAmount);

                da = new SqlDataAdapter(countAvailableProducts, c);
                da.Fill(countedAvailableProducts);
            }

            float total = 0;

            for (int i = 0; i < countedNeededAmount.Rows.Count; i++)
            {
                float neededAmount = float.Parse(countedNeededAmount.Rows[i].ItemArray[1].ToString());

                for (int j = 0; j < countedAvailableProducts.Rows.Count; j++)
                {
                    if (countedNeededAmount.Rows[i].ItemArray[2].ToString() == countedAvailableProducts.Rows[j].ItemArray[0].ToString())
                    {
                        int number = dataGridView.Rows.Count + 1;
                        string name = countedAvailableProducts.Rows[j].ItemArray[1].ToString();
                        string units = countedAvailableProducts.Rows[j].ItemArray[2].ToString();
                        float price = float.Parse(countedAvailableProducts.Rows[j].ItemArray[3].ToString());
                        float availableAmount = float.Parse(countedAvailableProducts.Rows[j].ItemArray[4].ToString());

                        if (neededAmount <= float.Parse(countedAvailableProducts.Rows[j].ItemArray[4].ToString()))
                        {
                            dataGridView.Rows.Add(number, name, neededAmount, units, price, Math.Round(neededAmount * price, 2));
                            total += neededAmount * price;
                            break;
                        }

                        dataGridView.Rows.Add(number, name, availableAmount, units, price, Math.Round(availableAmount * price, 2));
                        total += availableAmount * price;
                        neededAmount -= availableAmount;
                        countedAvailableProducts.Rows[j].ItemArray[4] = 0;
                    }
                }
            }
            dateLabel.Text = $"за {DateTime.Now.ToString("D")}";
            totalLabel.Text = $"Всього відпущено {dataGridView.Rows.Count} найменувань, на суму {Math.Round(total, 2)} грн.";
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void CreateDocument()
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
            winword.ShowAnimation = false;
            winword.Visible = false;
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            document.Content.SetRange(0, 0);
            Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
            para1.Range.Text = headerLabel.Text + numTextBox.Text;
            para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            para1.Range.Font.Bold = 1;
            para1.Range.InsertParagraphAfter();

            Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
            para2.Range.Text = dateLabel.Text;
            para2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            para1.Range.Font.Bold = 0;
            para2.Range.InsertParagraphAfter();

            Table firstTable = document.Tables.Add(para1.Range, dataGridView.Rows.Count + 1, dataGridView.Columns.Count, ref missing, ref missing);

            firstTable.Borders.Enable = 1;
            for (int i = 0; i < firstTable.Rows.Count; i++)
            {
                for (int j = 0; j < firstTable.Columns.Count; j++)
                {
                    Cell cell = firstTable.Rows[i + 1].Cells[j + 1];
                    if (i == 0)
                    {
                        cell.Range.Text = dataGridView.Columns[j].HeaderText;
                        cell.Range.Font.Bold = 1;
                        cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else
                    {
                        cell.Range.Text = dataGridView.Rows[i - 1].Cells[j].Value.ToString();
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                }
            }
            Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
            para3.Range.Text = totalLabel.Text;
            para3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            para3.Range.InsertParagraphAfter();

            Paragraph para4 = document.Content.Paragraphs.Add(ref missing);
            para4.Range.Text = textLabel1.Text + " " + textBox1.Text;
            para4.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            para4.Range.InsertParagraphAfter();

            Paragraph para5 = document.Content.Paragraphs.Add(ref missing);
            para5.Range.Text = textLabel2.Text + " " + textBox2.Text;
            para5.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            para5.Range.InsertParagraphAfter();

            Paragraph para6 = document.Content.Paragraphs.Add(ref missing);
            para6.Range.Text = textLabel3.Text + " " + textBox3.Text;
            para6.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            para6.Range.InsertParagraphAfter();

            Cursor.Current = Cursors.Default;
            saveFileDialog1.Filter = "MS Word files(*.docx)|*.docx";
            saveFileDialog1.FileName = $"Накладна-вимога №{numTextBox.Text}.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            object filename = saveFileDialog1.FileName;
            document.SaveAs2(ref filename);
            document.Close(ref missing, ref missing, ref missing);
            document = null;
            winword.Quit(ref missing, ref missing, ref missing);
            winword = null;
            MessageBox.Show("Документ успішно збережено!");
            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CreateDocument();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
