using System;
using System.Windows.Forms;

namespace chef
{
    public class TwoIntsFilterRow : TwoValuesFilterRow<int>
    {
        public TwoIntsFilterRow(string fieldName, int minDefaultValue,
            int maxDefaultValue, CheckBox checkBox, TextBox minTextBox,
            TextBox maxTextBox, Action updateDataTable)
                : base(fieldName, minDefaultValue, maxDefaultValue,
                      checkBox, minTextBox, maxTextBox, updateDataTable,
                      int.TryParse, x => x.ToString())
        { }
    }
}
