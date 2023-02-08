
namespace chef
{
    partial class products_Filter_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products_Filter_Form));
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.manufacturerCheckBox = new System.Windows.Forms.CheckBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.amountCheckBox = new System.Windows.Forms.CheckBox();
            this.expiredCheckBox = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancel_filtrationButton = new System.Windows.Forms.Button();
            this.price1 = new System.Windows.Forms.TextBox();
            this.amount1 = new System.Windows.Forms.TextBox();
            this.expired1 = new System.Windows.Forms.TextBox();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.amount2 = new System.Windows.Forms.TextBox();
            this.expired2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCheckBox.Location = new System.Drawing.Point(12, 12);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(166, 33);
            this.typeCheckBox.TabIndex = 2;
            this.typeCheckBox.Text = "Тип продукту";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.units_of_measurementCheckBox_CheckedChanged);
            // 
            // manufacturerCheckBox
            // 
            this.manufacturerCheckBox.AutoSize = true;
            this.manufacturerCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerCheckBox.Location = new System.Drawing.Point(12, 58);
            this.manufacturerCheckBox.Name = "manufacturerCheckBox";
            this.manufacturerCheckBox.Size = new System.Drawing.Size(134, 33);
            this.manufacturerCheckBox.TabIndex = 2;
            this.manufacturerCheckBox.Text = "Виробник";
            this.manufacturerCheckBox.UseVisualStyleBackColor = true;
            this.manufacturerCheckBox.CheckedChanged += new System.EventHandler(this.proteinsCheckBox_CheckedChanged);
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCheckBox.Location = new System.Drawing.Point(12, 104);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(78, 33);
            this.priceCheckBox.TabIndex = 2;
            this.priceCheckBox.Text = "Ціна";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            this.priceCheckBox.CheckedChanged += new System.EventHandler(this.fatsCheckBox_CheckedChanged);
            // 
            // amountCheckBox
            // 
            this.amountCheckBox.AutoSize = true;
            this.amountCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountCheckBox.Location = new System.Drawing.Point(12, 150);
            this.amountCheckBox.Name = "amountCheckBox";
            this.amountCheckBox.Size = new System.Drawing.Size(121, 33);
            this.amountCheckBox.TabIndex = 2;
            this.amountCheckBox.Text = "Кількість";
            this.amountCheckBox.UseVisualStyleBackColor = true;
            this.amountCheckBox.CheckedChanged += new System.EventHandler(this.carbohydratesCheckBox_CheckedChanged);
            // 
            // expiredCheckBox
            // 
            this.expiredCheckBox.AutoSize = true;
            this.expiredCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiredCheckBox.Location = new System.Drawing.Point(12, 196);
            this.expiredCheckBox.Name = "expiredCheckBox";
            this.expiredCheckBox.Size = new System.Drawing.Size(220, 33);
            this.expiredCheckBox.TabIndex = 2;
            this.expiredCheckBox.Text = "Строк придатності";
            this.expiredCheckBox.UseVisualStyleBackColor = true;
            this.expiredCheckBox.CheckedChanged += new System.EventHandler(this.energy_valueCheckBox_CheckedChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Enabled = false;
            this.typeComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "кг",
            "г",
            "шт",
            "л"});
            this.typeComboBox.Location = new System.Drawing.Point(275, 10);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(363, 36);
            this.typeComboBox.TabIndex = 3;
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label3.Location = new System.Drawing.Point(270, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "від";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label4.Location = new System.Drawing.Point(460, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label5.Location = new System.Drawing.Point(270, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "від";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label6.Location = new System.Drawing.Point(460, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "до";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label7.Location = new System.Drawing.Point(270, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "від";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label8.Location = new System.Drawing.Point(460, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "до";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.okButton.FlatAppearance.BorderSize = 2;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(141, 248);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 51);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancel_filtrationButton
            // 
            this.cancel_filtrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.cancel_filtrationButton.FlatAppearance.BorderSize = 2;
            this.cancel_filtrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_filtrationButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_filtrationButton.Location = new System.Drawing.Point(252, 248);
            this.cancel_filtrationButton.Name = "cancel_filtrationButton";
            this.cancel_filtrationButton.Size = new System.Drawing.Size(257, 51);
            this.cancel_filtrationButton.TabIndex = 7;
            this.cancel_filtrationButton.Text = "Скинути фільтрацію";
            this.cancel_filtrationButton.UseVisualStyleBackColor = false;
            this.cancel_filtrationButton.Click += new System.EventHandler(this.cancel_filtrationButton_Click);
            // 
            // price1
            // 
            this.price1.Enabled = false;
            this.price1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.price1.Location = new System.Drawing.Point(317, 102);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(137, 36);
            this.price1.TabIndex = 8;
            this.price1.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // amount1
            // 
            this.amount1.Enabled = false;
            this.amount1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.amount1.Location = new System.Drawing.Point(317, 148);
            this.amount1.Name = "amount1";
            this.amount1.Size = new System.Drawing.Size(137, 36);
            this.amount1.TabIndex = 8;
            this.amount1.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // expired1
            // 
            this.expired1.Enabled = false;
            this.expired1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.expired1.Location = new System.Drawing.Point(317, 194);
            this.expired1.Name = "expired1";
            this.expired1.Size = new System.Drawing.Size(137, 36);
            this.expired1.TabIndex = 8;
            this.expired1.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.Enabled = false;
            this.manufacturerComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Items.AddRange(new object[] {
            "кг",
            "г",
            "шт",
            "л"});
            this.manufacturerComboBox.Location = new System.Drawing.Point(275, 56);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(363, 36);
            this.manufacturerComboBox.TabIndex = 3;
            this.manufacturerComboBox.SelectedValueChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // price2
            // 
            this.price2.Enabled = false;
            this.price2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.price2.Location = new System.Drawing.Point(501, 101);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(137, 36);
            this.price2.TabIndex = 8;
            this.price2.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // amount2
            // 
            this.amount2.Enabled = false;
            this.amount2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.amount2.Location = new System.Drawing.Point(501, 147);
            this.amount2.Name = "amount2";
            this.amount2.Size = new System.Drawing.Size(137, 36);
            this.amount2.TabIndex = 8;
            this.amount2.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // expired2
            // 
            this.expired2.Enabled = false;
            this.expired2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.expired2.Location = new System.Drawing.Point(501, 193);
            this.expired2.Name = "expired2";
            this.expired2.Size = new System.Drawing.Size(137, 36);
            this.expired2.TabIndex = 8;
            this.expired2.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // products_Filter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(650, 320);
            this.Controls.Add(this.expired2);
            this.Controls.Add(this.expired1);
            this.Controls.Add(this.amount2);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.amount1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.cancel_filtrationButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.expiredCheckBox);
            this.Controls.Add(this.amountCheckBox);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.manufacturerCheckBox);
            this.Controls.Add(this.typeCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "products_Filter_Form";
            this.Text = "Фільтрування";
            this.Deactivate += new System.EventHandler(this.types_of_products_Filter_Form_Leave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.types_of_products_Filter_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox manufacturerCheckBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.CheckBox amountCheckBox;
        private System.Windows.Forms.CheckBox expiredCheckBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancel_filtrationButton;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.TextBox amount1;
        private System.Windows.Forms.TextBox expired1;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.TextBox amount2;
        private System.Windows.Forms.TextBox expired2;
    }
}