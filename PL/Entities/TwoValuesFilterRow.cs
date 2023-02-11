using System;
using System.Windows.Forms;
using static chef.DAL.Delegates;

namespace chef
{
    public abstract class TwoValuesFilterRow<T> : IFilterRow
    {
        private readonly string _fieldName;

        private readonly T _minDefaultValue;
        private readonly T _maxDefaultValue;

        private readonly TextBox _minTextBox;
        private readonly TextBox _maxTextBox;

        private readonly TryParseDelegate<T> _tryParse;
        private readonly ConvertToStringDelegate<T> _convertToString;

        public CheckBox CheckBox { get; }

        public string GetStatement
        {
            get
            {
                var minValue = GetParameter(_minTextBox.Text, _minDefaultValue, CheckBox.Checked, _tryParse);
                var maxValue = GetParameter(_maxTextBox.Text, _maxDefaultValue, CheckBox.Checked, _tryParse);

                return $"{_fieldName} BETWEEN {_convertToString(minValue)} AND {_convertToString(maxValue)}";
            }
        }

        public TwoValuesFilterRow(string fieldName, T minDefaultValue,
            T maxDefaultValue, CheckBox checkBox, TextBox minTextBox,
            TextBox maxTextBox, Action updateDataTable,
            TryParseDelegate<T> tryParse, ConvertToStringDelegate<T> convertToString)
        {
            _fieldName = fieldName;
            _minDefaultValue = minDefaultValue;
            _maxDefaultValue = maxDefaultValue;
            CheckBox = checkBox;
            _minTextBox = minTextBox;
            _maxTextBox = maxTextBox;
            _tryParse = tryParse;
            _convertToString = convertToString;

            CheckBox.CheckedChanged += (sender, e) =>
            {
                _minTextBox.Enabled = CheckBox.Checked;
                _maxTextBox.Enabled = CheckBox.Checked;

                updateDataTable();
            };
        }

        private T GetParameter(string text, T defaultValue, bool isChecked, TryParseDelegate<T> TryParse)
        {
            bool isDesiredType = TryParse(text, out T num);
            if (!isChecked || string.IsNullOrWhiteSpace(text) || !isDesiredType)
            {
                return defaultValue;
            }
            else
            {
                return num;
            }
        }

        public void CancelFiltration()
        {
            CheckBox.Checked = false;
        }
    }
}
