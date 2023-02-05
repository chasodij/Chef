
namespace chef
{
    partial class specials_Filter_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(specials_Filter_Form));
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancel_filtrationButton = new System.Windows.Forms.Button();
            this.price1 = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCheckBox.Location = new System.Drawing.Point(12, 12);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(78, 33);
            this.priceCheckBox.TabIndex = 2;
            this.priceCheckBox.Text = "Ціна";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            this.priceCheckBox.CheckedChanged += new System.EventHandler(this.fatsCheckBox_CheckedChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckBox.Location = new System.Drawing.Point(12, 58);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(80, 33);
            this.dateCheckBox.TabIndex = 2;
            this.dateCheckBox.Text = "Дата";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.carbohydratesCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label3.Location = new System.Drawing.Point(160, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "від";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label4.Location = new System.Drawing.Point(388, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label5.Location = new System.Drawing.Point(160, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "від";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label6.Location = new System.Drawing.Point(388, 61);
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
            this.okButton.Location = new System.Drawing.Point(130, 109);
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
            this.cancel_filtrationButton.Location = new System.Drawing.Point(241, 109);
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
            this.price1.Location = new System.Drawing.Point(207, 11);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(180, 36);
            this.price1.TabIndex = 8;
            this.price1.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // date1
            // 
            this.date1.Enabled = false;
            this.date1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.date1.Location = new System.Drawing.Point(207, 57);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(180, 36);
            this.date1.TabIndex = 8;
            this.date1.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // price2
            // 
            this.price2.Enabled = false;
            this.price2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.price2.Location = new System.Drawing.Point(429, 11);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(180, 36);
            this.price2.TabIndex = 8;
            this.price2.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // date2
            // 
            this.date2.Enabled = false;
            this.date2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.date2.Location = new System.Drawing.Point(429, 57);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(180, 36);
            this.date2.TabIndex = 8;
            this.date2.TextChanged += new System.EventHandler(this.proteinsTextBox1_TextChanged);
            // 
            // specials_Filter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(628, 182);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.cancel_filtrationButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.priceCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "specials_Filter_Form";
            this.Text = "Фільтрування";
            this.Deactivate += new System.EventHandler(this.types_of_products_Filter_Form_Leave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.types_of_products_Filter_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancel_filtrationButton;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.TextBox date1;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.TextBox date2;
    }
}