using System;
using System.Windows.Forms;

namespace chef
{
    public class TwoDateTimesFilterRow : TwoValuesFilterRow<DateTime>
    {
        public TwoDateTimesFilterRow(string fieldName, DateTime minDefaultValue,
            DateTime maxDefaultValue, CheckBox checkBox, TextBox minTextBox,
            TextBox maxTextBox, Action updateDataTable)
                : base(fieldName, minDefaultValue, maxDefaultValue,
                      checkBox, minTextBox, maxTextBox, updateDataTable,
                      DateTime.TryParse, x => x.ToString("MM/dd/yyyy"))
        { }
    }
}
