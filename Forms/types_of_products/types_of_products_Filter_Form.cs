using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chef
{
    public partial class types_of_products_Filter_Form : Form
    {
        types_of_products_Form parent_Form;
        
        public string units_of_measurement
        {
            get
            {
                if (units_of_measurementCheckBox.Checked == false || units_of_measurementComboBox.SelectedIndex == -1)
                    return "";
                else
                {
                    return units_of_measurementComboBox.SelectedItem.ToString();
                }
            }
        }
        public float proteins_min
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(proteinsTextBox1.Text, out num);
                if(proteinsCheckBox.Checked == false || string.IsNullOrWhiteSpace(proteinsTextBox1.Text) || !isFloat)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public float proteins_max
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(proteinsTextBox2.Text, out num);
                if (proteinsCheckBox.Checked == false || string.IsNullOrWhiteSpace(proteinsTextBox2.Text) || !isFloat)
                {
                    return 100;
                }
                else
                {
                    return num;
                }
            }
        }
        public float fats_min
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(fatsTextBox1.Text, out num);
                if (fatsCheckBox.Checked == false || string.IsNullOrWhiteSpace(fatsTextBox1.Text) || !isFloat)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public float fats_max
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(fatsTextBox2.Text, out num);
                if (fatsCheckBox.Checked == false || string.IsNullOrWhiteSpace(fatsTextBox2.Text) || !isFloat)
                {
                    return 100;
                }
                else
                {
                    return num;
                }
            }
        }
        public float carbohydrates_min
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(carbohydratesTextBox1.Text, out num);
                if (carbohydratesCheckBox.Checked == false || string.IsNullOrWhiteSpace(carbohydratesTextBox1.Text) || !isFloat)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public float carbohydrates_max
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(carbohydratesTextBox2.Text, out num);
                if (carbohydratesCheckBox.Checked == false || string.IsNullOrWhiteSpace(carbohydratesTextBox2.Text) || !isFloat)
                {
                    return 100;
                }
                else
                {
                    return num;
                }
            }
        }
        public float energy_value_min
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(energy_valueTextBox1.Text, out num);
                if (energy_valueCheckBox.Checked == false || string.IsNullOrWhiteSpace(energy_valueTextBox1.Text) || !isFloat)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
        }
        public float energy_value_max
        {
            get
            {
                float num = 0;
                bool isFloat = float.TryParse(energy_valueTextBox2.Text, out num);
                if (energy_valueCheckBox.Checked == false || string.IsNullOrWhiteSpace(energy_valueTextBox2.Text) || !isFloat)
                {
                    return 1000;
                }
                else
                {
                    return num;
                }
            }
        }
        public types_of_products_Filter_Form(types_of_products_Form parent_Form)
        {
            InitializeComponent();
            this.parent_Form = parent_Form;
        }

        private void units_of_measurementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(units_of_measurementCheckBox.Checked)
            {
                units_of_measurementComboBox.Enabled = true;
            }
            else
            {
                units_of_measurementComboBox.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void proteinsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (proteinsCheckBox.Checked)
            {
                proteinsTextBox1.Enabled = true;
                proteinsTextBox2.Enabled = true;
            }
            else
            {
                proteinsTextBox1.Enabled = false;
                proteinsTextBox2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void fatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fatsCheckBox.Checked)
            {
                fatsTextBox1.Enabled = true;
                fatsTextBox2.Enabled = true;
            }
            else
            {
                fatsTextBox1.Enabled = false;
                fatsTextBox2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void carbohydratesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (carbohydratesCheckBox.Checked)
            {
                carbohydratesTextBox1.Enabled = true;
                carbohydratesTextBox2.Enabled = true;
            }
            else
            {
                carbohydratesTextBox1.Enabled = false;
                carbohydratesTextBox2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void energy_valueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (energy_valueCheckBox.Checked)
            {
                energy_valueTextBox1.Enabled = true;
                energy_valueTextBox2.Enabled = true;
            }
            else
            {
                energy_valueTextBox1.Enabled = false;
                energy_valueTextBox2.Enabled = false;
            }
            parent_Form.sortAndFilter();
        }

        private void cancel_filtrationButton_Click(object sender, EventArgs e)
        {
            units_of_measurementCheckBox.Checked = false;
            proteinsCheckBox.Checked = false;
            fatsCheckBox.Checked = false;
            carbohydratesCheckBox.Checked = false;
            energy_valueCheckBox.Checked = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void proteinsTextBox1_TextChanged(object sender, EventArgs e)
        {
            parent_Form.sortAndFilter();
        }

        private void types_of_products_Filter_Form_Leave(object sender, EventArgs e)
        {
            Hide();
        }

        private void types_of_products_Filter_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
