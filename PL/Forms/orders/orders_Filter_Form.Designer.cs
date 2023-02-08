
namespace chef
{
    partial class orders_Filter_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders_Filter_Form));
            this.is_completedCheckBox = new System.Windows.Forms.CheckBox();
            this.totalCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.is_completedComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancel_filtrationButton = new System.Windows.Forms.Button();
            this.total1 = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.TextBox();
            this.total2 = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // is_completedCheckBox
            // 
            this.is_completedCheckBox.AutoSize = true;
            this.is_completedCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_completedCheckBox.Location = new System.Drawing.Point(12, 12);
            this.is_completedCheckBox.Name = "is_completedCheckBox";
            this.is_completedCheckBox.Size = new System.Drawing.Size(156, 62);
            this.is_completedCheckBox.TabIndex = 2;
            this.is_completedCheckBox.Text = "Статус\r\nзамовлення";
            this.is_completedCheckBox.UseVisualStyleBackColor = true;
            this.is_completedCheckBox.CheckedChanged += new System.EventHandler(this.units_of_measurementCheckBox_CheckedChanged);
            // 
            // totalCheckBox
            // 
            this.totalCheckBox.AutoSize = true;
            this.totalCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCheckBox.Location = new System.Drawing.Point(12, 79);
            this.totalCheckBox.Name = "totalCheckBox";
            this.totalCheckBox.Size = new System.Drawing.Size(84, 33);
            this.totalCheckBox.TabIndex = 2;
            this.totalCheckBox.Text = "Сума";
            this.totalCheckBox.UseVisualStyleBackColor = true;
            this.totalCheckBox.CheckedChanged += new System.EventHandler(this.fatsCheckBox_CheckedChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckBox.Location = new System.Drawing.Point(12, 125);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(80, 33);
            this.dateCheckBox.TabIndex = 2;
            this.dateCheckBox.Text = "Дата";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.carbohydratesCheckBox_CheckedChanged);
            // 
            // is_completedComboBox
            // 
            this.is_completedComboBox.Enabled = false;
            this.is_completedComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.is_completedComboBox.FormattingEnabled = true;
            this.is_completedComboBox.Items.AddRange(new object[] {
            "не виконане",
            "виконане"});
            this.is_completedComboBox.Location = new System.Drawing.Point(174, 25);
            this.is_completedComboBox.Name = "is_completedComboBox";
            this.is_completedComboBox.Size = new System.Drawing.Size(435, 36);
            this.is_completedComboBox.TabIndex = 3;
            this.is_completedComboBox.SelectedValueChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label3.Location = new System.Drawing.Point(160, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "від";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label4.Location = new System.Drawing.Point(388, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label5.Location = new System.Drawing.Point(160, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "від";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label6.Location = new System.Drawing.Point(388, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "до";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.okButton.FlatAppearance.BorderSize = 2;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(130, 175);
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
            this.cancel_filtrationButton.Location = new System.Drawing.Point(241, 175);
            this.cancel_filtrationButton.Name = "cancel_filtrationButton";
            this.cancel_filtrationButton.Size = new System.Drawing.Size(257, 51);
            this.cancel_filtrationButton.TabIndex = 7;
            this.cancel_filtrationButton.Text = "Скинути фільтрацію";
            this.cancel_filtrationButton.UseVisualStyleBackColor = false;
            this.cancel_filtrationButton.Click += new System.EventHandler(this.cancel_filtrationButton_Click);
            // 
            // total1
            // 
            this.total1.Enabled = false;
            this.total1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.total1.Location = new System.Drawing.Point(207, 78);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(180, 36);
            this.total1.TabIndex = 8;
            this.total1.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // date1
            // 
            this.date1.Enabled = false;
            this.date1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.date1.Location = new System.Drawing.Point(207, 124);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(180, 36);
            this.date1.TabIndex = 8;
            this.date1.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // total2
            // 
            this.total2.Enabled = false;
            this.total2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.total2.Location = new System.Drawing.Point(429, 78);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(180, 36);
            this.total2.TabIndex = 8;
            this.total2.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // date2
            // 
            this.date2.Enabled = false;
            this.date2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.date2.Location = new System.Drawing.Point(429, 124);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(180, 36);
            this.date2.TabIndex = 8;
            this.date2.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // orders_Filter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(628, 245);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.total2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.total1);
            this.Controls.Add(this.cancel_filtrationButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.is_completedComboBox);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.totalCheckBox);
            this.Controls.Add(this.is_completedCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "orders_Filter_Form";
            this.Text = "Фільтрування";
            this.Deactivate += new System.EventHandler(this.types_of_products_Filter_Form_Leave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.types_of_products_Filter_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox is_completedCheckBox;
        private System.Windows.Forms.CheckBox totalCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.ComboBox is_completedComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancel_filtrationButton;
        private System.Windows.Forms.TextBox total1;
        private System.Windows.Forms.TextBox date1;
        private System.Windows.Forms.TextBox total2;
        private System.Windows.Forms.TextBox date2;
    }
}