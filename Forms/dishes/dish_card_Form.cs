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
using Microsoft.Office.Interop.Word;

namespace chef
{
    public partial class dish_card : Form
    {
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        public dish_card(int dish_id, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;

            dataGridView.Columns.Add("name", "Назва");
            dataGridView.Columns.Add("amount", "Кількість");
            dataGridView.Columns.Add("units", "Одиниця виміру");
            dataGridView.Columns.Add("proteins", "Білки, г");
            dataGridView.Columns.Add("fats", "Жири, г");
            dataGridView.Columns.Add("carbohydrates", "Вуглеводи, г");
            dataGridView.Columns.Add("energy_value", "Енергетична цінність, ккал");

            string select = "SELECT dishes.dish_name, types_of_products.type_name, ingredients.ingredient_amount, types_of_products.units_of_measurement, " +
                                        "types_of_products.proteins * 10 * ingredients.ingredient_amount, types_of_products.fats * 10 * ingredients.ingredient_amount, " +
                                        "types_of_products.carbohydrates * 10 * ingredients.ingredient_amount, types_of_products.energy_value * 10 * ingredients.ingredient_amount, dishes.mass " +
                                        "FROM dishes JOIN ingredients ON dishes.dish_id = ingredients.dish_id JOIN types_of_products ON ingredients.type_id = types_of_products.type_id " +
                                        "WHERE dishes.dish_id = @dish_id";

            System.Data.DataTable dt = new System.Data.DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@dish_id", dish_id);
                da.Fill(dt);
            }

            dish_nameLabel.Text += " " + dt.Rows[0].ItemArray[0].ToString();
            massLabel.Text += " " + dt.Rows[0].ItemArray[8].ToString() + " г";

            float total_proteins = 0;
            float total_fats = 0;
            float total_carbohydrates = 0;
            float total_energy_value = 0;

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i].ItemArray[1].ToString();
                string amount = dt.Rows[i].ItemArray[2].ToString();
                string units = dt.Rows[i].ItemArray[3].ToString();
                string proteins = dt.Rows[i].ItemArray[4].ToString();
                string fats = dt.Rows[i].ItemArray[5].ToString();
                string carbohydrates = dt.Rows[i].ItemArray[6].ToString();
                string energy = dt.Rows[i].ItemArray[7].ToString();
                dataGridView.Rows.Add(name, amount, units, proteins, fats, carbohydrates, energy);
                total_proteins += float.Parse(proteins);
                total_fats += float.Parse(fats);
                total_carbohydrates += float.Parse(carbohydrates);
                total_energy_value += float.Parse(energy);
            }
            dataGridView.Rows.Add();
            dataGridView.Rows.Add("", "", "Підсумок:", total_proteins, total_fats, total_carbohydrates, total_energy_value);
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
            Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            document.Content.SetRange(0, 0);
            Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
            para1.Range.Text = headerLabel.Text;
            para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            para1.Range.Font.Bold = 1;
            para1.Range.InsertParagraphAfter();

            Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
            para2.Range.Text = dish_nameLabel.Text;
            para2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            para1.Range.Font.Bold = 0;
            para2.Range.InsertParagraphAfter();

            Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
            para3.Range.Text = massLabel.Text;
            para3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            para3.Range.InsertParagraphAfter();

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
                    else if(dataGridView.Rows[i - 1].Cells[j].Value != null)
                    {
                        cell.Range.Text = dataGridView.Rows[i - 1].Cells[j].Value.ToString();
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                }
            }

            Cursor.Current = Cursors.Default;
            saveFileDialog1.Filter = "MS Word files(*.docx)|*.docx";
            saveFileDialog1.FileName = $"Розкладка {dish_nameLabel.Text.Substring(dish_nameLabel.Text.IndexOf(":") + 2, dish_nameLabel.Text.Length - dish_nameLabel.Text.IndexOf(":") - 2)}.docx";
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
