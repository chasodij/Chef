using chef.BLL.DTOs;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace chef.BLL.Services
{
    public class MsWordService : IMsWordService
    {
        public void CreateDishCardFile(DishCardDTO dishCardDTO, string path)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            _Application oWord;
            _Document oDoc;
            oWord = new Word.Application
            {
                Visible = false
            };
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);

            Paragraph oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "КАРТА-РОЗКЛАДКА";
            oPara1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            oPara1.Range.Font.Bold = 1;
            oPara1.Range.InsertParagraphAfter();

            Paragraph oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara2.Range.Text = $"Найменування страви: {dishCardDTO.DishName}";
            oPara2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            oPara2.Range.Font.Bold = 0;
            oPara2.Range.InsertParagraphAfter();

            Paragraph oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara3.Range.Text = $"Вага готової страви: {dishCardDTO.Weight}";
            oPara3.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            oPara3.Range.InsertParagraphAfter();

            Table table = oDoc.Tables.Add(oPara1.Range,
                dishCardDTO.Ingredients.Count + 3, 7,
                ref oMissing, ref oMissing);
            table.Borders.Enable = 1;

            var headers = new string[] {
                "Назва",
                "Кількість",
                "Одиниці виміру",
                "Білки, г",
                "Жири, г",
                "Вуглеводи, г",
                "Енергетична цінність, ккал"
            };

            for (int j = 0; j < 7; j++)
            {
                CreateHeaderCell(table.Rows[1].Cells[j + 1], headers[j]);
            }

            var summary = new string[] {
                "", "", "Підсумок:",
                dishCardDTO.TotalProteinsInGrams.ToString(),
                dishCardDTO.TotalFatsInGrams.ToString(),
                dishCardDTO.TotalCarbohydratesInGrams.ToString(),
                dishCardDTO.TotalCalories.ToString()
            };

            for (int j = 0; j < 7; j++)
            {
                CreateHeaderCell(table.Rows[dishCardDTO.Ingredients.Count + 3].Cells[j + 1], summary[j]);
            }

            for (int i = 0; i < dishCardDTO.Ingredients.Count; i++)
            {
                var row = table.Rows[i + 2];

                CreateCell(row.Cells[1], dishCardDTO.Ingredients[i].Name);
                CreateCell(row.Cells[2], dishCardDTO.Ingredients[i].AmountInUnits.ToString());
                CreateCell(row.Cells[3], dishCardDTO.Ingredients[i].UnitsOfMeasurement);
                CreateCell(row.Cells[4], dishCardDTO.Ingredients[i].ProteinsInGrams.ToString());
                CreateCell(row.Cells[5], dishCardDTO.Ingredients[i].FatsInGrams.ToString());
                CreateCell(row.Cells[6], dishCardDTO.Ingredients[i].CarbohydratesInGrams.ToString());
                CreateCell(row.Cells[7], dishCardDTO.Ingredients[i].Calories.ToString());
            }

            oDoc.SaveAs2(path);
            oWord.Quit();
        }

        public void CreateHeaderCell(Cell cell, string text)
        {
            cell.Range.Text = text;
            cell.Range.Font.Bold = 1;
            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        }

        public void CreateCell(Cell cell, string text)
        {
            cell.Range.Text = text;
            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        }
    }
}
