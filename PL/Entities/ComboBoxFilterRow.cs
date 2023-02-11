using System;
using System.Windows.Forms;

namespace chef
{
    public class ComboBoxFilterRow : IFilterRow
    {
        private readonly string _fieldName;

        private readonly ComboBox _comboBox;

        public CheckBox CheckBox { get; }

        public string GetStatement
        {
            get
            {
                if (!CheckBox.Checked || _comboBox.SelectedIndex == -1)
                {
                    return string.Empty;
                }
                else
                {
                    return $"{_fieldName} = '{_comboBox.SelectedItem}'";
                }
            }
        }

        public ComboBoxFilterRow(string fieldName, ComboBox comboBox,
            CheckBox checkBox, Action updateDataTable)
        {
            _fieldName = fieldName;
            _comboBox = comboBox;
            CheckBox = checkBox;

            CheckBox.CheckedChanged += (sender, e) =>
            {
                _comboBox.Enabled = CheckBox.Checked;

                updateDataTable();
            };
        }

        public void CancelFiltration()
        {
            CheckBox.Checked = false;
        }
    }
}
