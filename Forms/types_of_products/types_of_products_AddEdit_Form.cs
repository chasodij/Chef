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
    public partial class types_of_products_AddEdit_Form : Form
    {
        readonly int type_id;
        readonly bool edit = false;
        readonly string connectionstring = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
        bool saved = false;

        public types_of_products_AddEdit_Form(string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            saveButon.Text = "Додати";
            this.Text = "Додавання типу інгредієнту";
            AutoValidate = AutoValidate.Disable;
        }
        public types_of_products_AddEdit_Form(int type_id, string connectionstring)
        {
            InitializeComponent();
            this.connectionstring = connectionstring;
            string select = "SELECT * FROM types_of_products WHERE type_id = @type_id";
            DataTable ds = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, c);
                da.SelectCommand.Parameters.AddWithValue("@type_id", type_id);
                da.Fill(ds);
            }

            string type_name = ds.Rows[0].ItemArray[1].ToString();
            float proteins = float.Parse(ds.Rows[0].ItemArray[2].ToString());
            float fats = float.Parse(ds.Rows[0].ItemArray[3].ToString());
            float carbohydrates = float.Parse(ds.Rows[0].ItemArray[4].ToString());
            float energy_value = float.Parse(ds.Rows[0].ItemArray[5].ToString());
            string units_of_measurement = ds.Rows[0].ItemArray[6].ToString();


            edit = true;
            this.type_id = type_id;
            type_nameTextBox.Text = type_name;
            proteinsTextBox.Value = (decimal)proteins;
            fatsTextBox.Value = (decimal)fats;
            carbohydratesTextBox.Value = (decimal)carbohydrates;
            energy_valueTextBox.Value = (decimal)energy_value;
            units_of_measurementComboBox.SelectedItem = units_of_measurement;
            saveButon.Text = "Зберегти";
            this.Text = "Редагування типу інгредієнту";
            AutoValidate = AutoValidate.Disable;
        }

        private void saveButon_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;
            string query;
            if(edit)
            {
                query = "UPDATE types_of_products SET type_name = @type_name, proteins = @proteins, fats = @fats, carbohydrates = @carbohydrates, energy_value = @energy_value, units_of_measurement = @units_of_measurement WHERE type_id = @type_id";
            }
            else
            {
                query = $"INSERT INTO types_of_products (type_name, proteins, fats, carbohydrates, energy_value, units_of_measurement) VALUES (@type_name, @proteins, @fats, @carbohydrates, @energy_value, @units_of_measurement);";
            }
            using (SqlConnection c = new SqlConnection(connectionstring))
            using (var cmd = c.CreateCommand())
            {
                c.Open();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@type_name", type_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@proteins", proteinsTextBox.Value);
                cmd.Parameters.AddWithValue("@fats", fatsTextBox.Value);
                cmd.Parameters.AddWithValue("@carbohydrates", carbohydratesTextBox.Value);
                cmd.Parameters.AddWithValue("@energy_value", energy_valueTextBox.Value);
                cmd.Parameters.AddWithValue("@units_of_measurement", units_of_measurementComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@type_id", type_id);
                cmd.ExecuteNonQuery();
            }
            saved = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void types_of_products_AddEdit_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && MessageBox.Show($"Ви дійсно бажаєте закрити це вікно? В такому разі ваші зміни не буде збережено.", "Вихід", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void type_nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(type_nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(type_nameTextBox, "Поле не повинно бути пустим");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(type_nameTextBox, "");
            }
        }

        private void units_of_measurementComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (units_of_measurementComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(units_of_measurementComboBox, "Оберіть одну з одиниць вимірювання");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(units_of_measurementComboBox, "");
            }
        }

        private void types_of_products_AddEdit_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
