using System;
using System.Windows.Forms;

namespace chef
{
    public class TwoFloatsFilterRow : TwoValuesFilterRow<float>
    {
        public TwoFloatsFilterRow(string fieldName, float minDefaultValue,
            float maxDefaultValue, CheckBox checkBox, TextBox minTextBox,
            TextBox maxTextBox, Action updateDataTable)
                : base(fieldName, minDefaultValue, maxDefaultValue,
                      checkBox, minTextBox, maxTextBox, updateDataTable,
                      float.TryParse, x => x.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture))
        { }
    }
}
