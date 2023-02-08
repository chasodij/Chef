
namespace chef
{
    partial class types_of_products_AddEdit_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(types_of_products_AddEdit_Form));
            this.type_nameLabel = new System.Windows.Forms.Label();
            this.type_nameTextBox = new System.Windows.Forms.TextBox();
            this.proteinsLabel = new System.Windows.Forms.Label();
            this.proteinsTextBox = new System.Windows.Forms.NumericUpDown();
            this.fatsTextBox = new System.Windows.Forms.NumericUpDown();
            this.fatsLabel = new System.Windows.Forms.Label();
            this.carbohydratesTextBox = new System.Windows.Forms.NumericUpDown();
            this.carbohydratesLabel = new System.Windows.Forms.Label();
            this.energy_valueLabel = new System.Windows.Forms.Label();
            this.energy_valueTextBox = new System.Windows.Forms.NumericUpDown();
            this.energy_valueLabel1 = new System.Windows.Forms.Label();
            this.units_of_measurementLabel = new System.Windows.Forms.Label();
            this.saveButon = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.units_of_measurementComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.proteinsTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbohydratesTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energy_valueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // type_nameLabel
            // 
            this.type_nameLabel.AutoSize = true;
            this.type_nameLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.type_nameLabel.Location = new System.Drawing.Point(28, 19);
            this.type_nameLabel.Name = "type_nameLabel";
            this.type_nameLabel.Size = new System.Drawing.Size(74, 29);
            this.type_nameLabel.TabIndex = 0;
            this.type_nameLabel.Text = "Назва";
            // 
            // type_nameTextBox
            // 
            this.type_nameTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_nameTextBox.Location = new System.Drawing.Point(180, 16);
            this.type_nameTextBox.Name = "type_nameTextBox";
            this.type_nameTextBox.Size = new System.Drawing.Size(247, 36);
            this.type_nameTextBox.TabIndex = 1;
            this.type_nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.type_nameTextBox_Validating);
            // 
            // proteinsLabel
            // 
            this.proteinsLabel.AutoSize = true;
            this.proteinsLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proteinsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.proteinsLabel.Location = new System.Drawing.Point(28, 71);
            this.proteinsLabel.Name = "proteinsLabel";
            this.proteinsLabel.Size = new System.Drawing.Size(68, 29);
            this.proteinsLabel.TabIndex = 2;
            this.proteinsLabel.Text = "Білки";
            // 
            // proteinsTextBox
            // 
            this.proteinsTextBox.DecimalPlaces = 2;
            this.proteinsTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proteinsTextBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.proteinsTextBox.Location = new System.Drawing.Point(180, 69);
            this.proteinsTextBox.Name = "proteinsTextBox";
            this.proteinsTextBox.Size = new System.Drawing.Size(188, 36);
            this.proteinsTextBox.TabIndex = 2;
            // 
            // fatsTextBox
            // 
            this.fatsTextBox.DecimalPlaces = 2;
            this.fatsTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatsTextBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fatsTextBox.Location = new System.Drawing.Point(180, 117);
            this.fatsTextBox.Name = "fatsTextBox";
            this.fatsTextBox.Size = new System.Drawing.Size(188, 36);
            this.fatsTextBox.TabIndex = 3;
            // 
            // fatsLabel
            // 
            this.fatsLabel.AutoSize = true;
            this.fatsLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.fatsLabel.Location = new System.Drawing.Point(28, 119);
            this.fatsLabel.Name = "fatsLabel";
            this.fatsLabel.Size = new System.Drawing.Size(71, 29);
            this.fatsLabel.TabIndex = 5;
            this.fatsLabel.Text = "Жири";
            // 
            // carbohydratesTextBox
            // 
            this.carbohydratesTextBox.DecimalPlaces = 2;
            this.carbohydratesTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carbohydratesTextBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.carbohydratesTextBox.Location = new System.Drawing.Point(180, 164);
            this.carbohydratesTextBox.Name = "carbohydratesTextBox";
            this.carbohydratesTextBox.Size = new System.Drawing.Size(188, 36);
            this.carbohydratesTextBox.TabIndex = 4;
            // 
            // carbohydratesLabel
            // 
            this.carbohydratesLabel.AutoSize = true;
            this.carbohydratesLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carbohydratesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.carbohydratesLabel.Location = new System.Drawing.Point(28, 166);
            this.carbohydratesLabel.Name = "carbohydratesLabel";
            this.carbohydratesLabel.Size = new System.Drawing.Size(118, 29);
            this.carbohydratesLabel.TabIndex = 7;
            this.carbohydratesLabel.Text = "Вуглеводи";
            // 
            // energy_valueLabel
            // 
            this.energy_valueLabel.AutoSize = true;
            this.energy_valueLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.energy_valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.energy_valueLabel.Location = new System.Drawing.Point(28, 216);
            this.energy_valueLabel.Name = "energy_valueLabel";
            this.energy_valueLabel.Size = new System.Drawing.Size(141, 58);
            this.energy_valueLabel.TabIndex = 9;
            this.energy_valueLabel.Text = "Енергетична\r\nцінність";
            // 
            // energy_valueTextBox
            // 
            this.energy_valueTextBox.DecimalPlaces = 2;
            this.energy_valueTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.energy_valueTextBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.energy_valueTextBox.Location = new System.Drawing.Point(181, 227);
            this.energy_valueTextBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.energy_valueTextBox.Name = "energy_valueTextBox";
            this.energy_valueTextBox.Size = new System.Drawing.Size(187, 36);
            this.energy_valueTextBox.TabIndex = 5;
            // 
            // energy_valueLabel1
            // 
            this.energy_valueLabel1.AutoSize = true;
            this.energy_valueLabel1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.energy_valueLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.energy_valueLabel1.Location = new System.Drawing.Point(368, 229);
            this.energy_valueLabel1.Name = "energy_valueLabel1";
            this.energy_valueLabel1.Size = new System.Drawing.Size(59, 29);
            this.energy_valueLabel1.TabIndex = 11;
            this.energy_valueLabel1.Text = "ккал";
            // 
            // units_of_measurementLabel
            // 
            this.units_of_measurementLabel.AutoSize = true;
            this.units_of_measurementLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.units_of_measurementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.units_of_measurementLabel.Location = new System.Drawing.Point(28, 288);
            this.units_of_measurementLabel.Name = "units_of_measurementLabel";
            this.units_of_measurementLabel.Size = new System.Drawing.Size(99, 58);
            this.units_of_measurementLabel.TabIndex = 0;
            this.units_of_measurementLabel.Text = "Одиниці\r\nвиміру";
            // 
            // saveButon
            // 
            this.saveButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.saveButon.FlatAppearance.BorderSize = 2;
            this.saveButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButon.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButon.Location = new System.Drawing.Point(76, 364);
            this.saveButon.Name = "saveButon";
            this.saveButon.Size = new System.Drawing.Size(145, 61);
            this.saveButon.TabIndex = 7;
            this.saveButon.Text = "button1";
            this.saveButon.UseVisualStyleBackColor = false;
            this.saveButon.Click += new System.EventHandler(this.saveButon_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(243, 364);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 61);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // units_of_measurementComboBox
            // 
            this.units_of_measurementComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.units_of_measurementComboBox.FormattingEnabled = true;
            this.units_of_measurementComboBox.Items.AddRange(new object[] {
            "кг",
            "г",
            "шт",
            "л"});
            this.units_of_measurementComboBox.Location = new System.Drawing.Point(180, 299);
            this.units_of_measurementComboBox.Name = "units_of_measurementComboBox";
            this.units_of_measurementComboBox.Size = new System.Drawing.Size(188, 36);
            this.units_of_measurementComboBox.TabIndex = 6;
            this.units_of_measurementComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.units_of_measurementComboBox_Validating);
            // 
            // types_of_products_AddEdit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(465, 449);
            this.Controls.Add(this.units_of_measurementComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButon);
            this.Controls.Add(this.energy_valueLabel1);
            this.Controls.Add(this.energy_valueTextBox);
            this.Controls.Add(this.energy_valueLabel);
            this.Controls.Add(this.carbohydratesTextBox);
            this.Controls.Add(this.carbohydratesLabel);
            this.Controls.Add(this.fatsTextBox);
            this.Controls.Add(this.fatsLabel);
            this.Controls.Add(this.proteinsTextBox);
            this.Controls.Add(this.proteinsLabel);
            this.Controls.Add(this.units_of_measurementLabel);
            this.Controls.Add(this.type_nameTextBox);
            this.Controls.Add(this.type_nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "types_of_products_AddEdit_Form";
            this.Text = "types_of_products_AddEdit_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.types_of_products_AddEdit_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.proteinsTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbohydratesTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energy_valueTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type_nameLabel;
        private System.Windows.Forms.TextBox type_nameTextBox;
        private System.Windows.Forms.Label proteinsLabel;
        private System.Windows.Forms.NumericUpDown proteinsTextBox;
        private System.Windows.Forms.NumericUpDown fatsTextBox;
        private System.Windows.Forms.Label fatsLabel;
        private System.Windows.Forms.NumericUpDown carbohydratesTextBox;
        private System.Windows.Forms.Label carbohydratesLabel;
        private System.Windows.Forms.Label energy_valueLabel;
        private System.Windows.Forms.NumericUpDown energy_valueTextBox;
        private System.Windows.Forms.Label energy_valueLabel1;
        private System.Windows.Forms.Label units_of_measurementLabel;
        private System.Windows.Forms.Button saveButon;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox units_of_measurementComboBox;
    }
}