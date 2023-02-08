
namespace chef
{
    partial class dishes_Filter_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dishes_Filter_Form));
            this.menuSectionCheckBox = new System.Windows.Forms.CheckBox();
            this.energyCategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.portionsCheckBox = new System.Windows.Forms.CheckBox();
            this.cookingTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.weightCheckBox = new System.Windows.Forms.CheckBox();
            this.menu_sectionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancel_filtrationButton = new System.Windows.Forms.Button();
            this.portions1TextBox = new System.Windows.Forms.TextBox();
            this.cookingTime1 = new System.Windows.Forms.TextBox();
            this.weight1 = new System.Windows.Forms.TextBox();
            this.energy_categoryComboBox = new System.Windows.Forms.ComboBox();
            this.portions2TextBox = new System.Windows.Forms.TextBox();
            this.cookingTime2 = new System.Windows.Forms.TextBox();
            this.weight2 = new System.Windows.Forms.TextBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // menu_sectionCheckBox
            // 
            this.menuSectionCheckBox.AutoSize = true;
            this.menuSectionCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuSectionCheckBox.Location = new System.Drawing.Point(12, 12);
            this.menuSectionCheckBox.Name = "menu_sectionCheckBox";
            this.menuSectionCheckBox.Size = new System.Drawing.Size(161, 33);
            this.menuSectionCheckBox.TabIndex = 2;
            this.menuSectionCheckBox.Text = "Розділ меню";
            this.menuSectionCheckBox.UseVisualStyleBackColor = true;
            this.menuSectionCheckBox.CheckedChanged += new System.EventHandler(this.units_of_measurementCheckBox_CheckedChanged);
            // 
            // energy_categoryCheckBox
            // 
            this.energyCategoryCheckBox.AutoSize = true;
            this.energyCategoryCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.energyCategoryCheckBox.Location = new System.Drawing.Point(12, 58);
            this.energyCategoryCheckBox.Name = "energy_categoryCheckBox";
            this.energyCategoryCheckBox.Size = new System.Drawing.Size(260, 33);
            this.energyCategoryCheckBox.TabIndex = 2;
            this.energyCategoryCheckBox.Text = "Енергетична категорія";
            this.energyCategoryCheckBox.UseVisualStyleBackColor = true;
            this.energyCategoryCheckBox.CheckedChanged += new System.EventHandler(this.proteinsCheckBox_CheckedChanged);
            // 
            // portionsCheckBox
            // 
            this.portionsCheckBox.AutoSize = true;
            this.portionsCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portionsCheckBox.Location = new System.Drawing.Point(12, 104);
            this.portionsCheckBox.Name = "portionsCheckBox";
            this.portionsCheckBox.Size = new System.Drawing.Size(197, 33);
            this.portionsCheckBox.TabIndex = 2;
            this.portionsCheckBox.Text = "Кількість порцій";
            this.portionsCheckBox.UseVisualStyleBackColor = true;
            this.portionsCheckBox.CheckedChanged += new System.EventHandler(this.fatsCheckBox_CheckedChanged);
            // 
            // cooking_timeCheckBox
            // 
            this.cookingTimeCheckBox.AutoSize = true;
            this.cookingTimeCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookingTimeCheckBox.Location = new System.Drawing.Point(12, 150);
            this.cookingTimeCheckBox.Name = "cooking_timeCheckBox";
            this.cookingTimeCheckBox.Size = new System.Drawing.Size(213, 33);
            this.cookingTimeCheckBox.TabIndex = 2;
            this.cookingTimeCheckBox.Text = "Час приготування";
            this.cookingTimeCheckBox.UseVisualStyleBackColor = true;
            this.cookingTimeCheckBox.CheckedChanged += new System.EventHandler(this.carbohydratesCheckBox_CheckedChanged);
            // 
            // massCheckBox
            // 
            this.weightCheckBox.AutoSize = true;
            this.weightCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightCheckBox.Location = new System.Drawing.Point(12, 196);
            this.weightCheckBox.Name = "massCheckBox";
            this.weightCheckBox.Size = new System.Drawing.Size(188, 33);
            this.weightCheckBox.TabIndex = 2;
            this.weightCheckBox.Text = "Маса на виході";
            this.weightCheckBox.UseVisualStyleBackColor = true;
            this.weightCheckBox.CheckedChanged += new System.EventHandler(this.energy_valueCheckBox_CheckedChanged);
            // 
            // menu_sectionComboBox
            // 
            this.menu_sectionComboBox.Enabled = false;
            this.menu_sectionComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.menu_sectionComboBox.FormattingEnabled = true;
            this.menu_sectionComboBox.Items.AddRange(new object[] {
            "Холодні страви та закуски",
            "Гарячі закуски",
            "Перші страви",
            "Другі страви",
            "Гарніри",
            "Хлібобулочні вироби",
            "Десерти",
            "Безалкогольні напої",
            "Алкогольні напої"});
            this.menu_sectionComboBox.Location = new System.Drawing.Point(275, 10);
            this.menu_sectionComboBox.Name = "menu_sectionComboBox";
            this.menu_sectionComboBox.Size = new System.Drawing.Size(363, 36);
            this.menu_sectionComboBox.TabIndex = 3;
            this.menu_sectionComboBox.SelectedValueChanged += new System.EventHandler(this.filterValue_ValueChanged);
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
            this.okButton.Location = new System.Drawing.Point(141, 291);
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
            this.cancel_filtrationButton.Location = new System.Drawing.Point(252, 291);
            this.cancel_filtrationButton.Name = "cancel_filtrationButton";
            this.cancel_filtrationButton.Size = new System.Drawing.Size(257, 51);
            this.cancel_filtrationButton.TabIndex = 7;
            this.cancel_filtrationButton.Text = "Скинути фільтрацію";
            this.cancel_filtrationButton.UseVisualStyleBackColor = false;
            this.cancel_filtrationButton.Click += new System.EventHandler(this.cancel_filtrationButton_Click);
            // 
            // portions1
            // 
            this.portions1TextBox.Enabled = false;
            this.portions1TextBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.portions1TextBox.Location = new System.Drawing.Point(317, 102);
            this.portions1TextBox.Name = "portions1";
            this.portions1TextBox.Size = new System.Drawing.Size(137, 36);
            this.portions1TextBox.TabIndex = 8;
            this.portions1TextBox.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // cooking_time1
            // 
            this.cookingTime1.Enabled = false;
            this.cookingTime1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.cookingTime1.Location = new System.Drawing.Point(317, 148);
            this.cookingTime1.Name = "cooking_time1";
            this.cookingTime1.Size = new System.Drawing.Size(137, 36);
            this.cookingTime1.TabIndex = 8;
            this.cookingTime1.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // mass1
            // 
            this.weight1.Enabled = false;
            this.weight1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.weight1.Location = new System.Drawing.Point(317, 194);
            this.weight1.Name = "mass1";
            this.weight1.Size = new System.Drawing.Size(137, 36);
            this.weight1.TabIndex = 8;
            this.weight1.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // energy_categoryComboBox
            // 
            this.energy_categoryComboBox.Enabled = false;
            this.energy_categoryComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.energy_categoryComboBox.FormattingEnabled = true;
            this.energy_categoryComboBox.Items.AddRange(new object[] {
            "низька",
            "середня",
            "висока"});
            this.energy_categoryComboBox.Location = new System.Drawing.Point(275, 56);
            this.energy_categoryComboBox.Name = "energy_categoryComboBox";
            this.energy_categoryComboBox.Size = new System.Drawing.Size(363, 36);
            this.energy_categoryComboBox.TabIndex = 3;
            this.energy_categoryComboBox.SelectedValueChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // portions2
            // 
            this.portions2TextBox.Enabled = false;
            this.portions2TextBox.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.portions2TextBox.Location = new System.Drawing.Point(501, 101);
            this.portions2TextBox.Name = "portions2";
            this.portions2TextBox.Size = new System.Drawing.Size(137, 36);
            this.portions2TextBox.TabIndex = 8;
            this.portions2TextBox.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // cooking_time2
            // 
            this.cookingTime2.Enabled = false;
            this.cookingTime2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.cookingTime2.Location = new System.Drawing.Point(501, 147);
            this.cookingTime2.Name = "cooking_time2";
            this.cookingTime2.Size = new System.Drawing.Size(137, 36);
            this.cookingTime2.TabIndex = 8;
            this.cookingTime2.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // mass2
            // 
            this.weight2.Enabled = false;
            this.weight2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.weight2.Location = new System.Drawing.Point(501, 193);
            this.weight2.Name = "mass2";
            this.weight2.Size = new System.Drawing.Size(137, 36);
            this.weight2.TabIndex = 8;
            this.weight2.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCheckBox.Location = new System.Drawing.Point(12, 243);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(78, 33);
            this.priceCheckBox.TabIndex = 2;
            this.priceCheckBox.Text = "Ціна";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            this.priceCheckBox.CheckedChanged += new System.EventHandler(this.priceCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label1.Location = new System.Drawing.Point(270, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "від";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.label2.Location = new System.Drawing.Point(460, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "до";
            // 
            // price1
            // 
            this.price1.Enabled = false;
            this.price1.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.price1.Location = new System.Drawing.Point(317, 241);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(137, 36);
            this.price1.TabIndex = 8;
            this.price1.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // price2
            // 
            this.price2.Enabled = false;
            this.price2.Font = new System.Drawing.Font("Calibri", 13.91597F);
            this.price2.Location = new System.Drawing.Point(501, 240);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(137, 36);
            this.price2.TabIndex = 8;
            this.price2.TextChanged += new System.EventHandler(this.filterValue_ValueChanged);
            // 
            // dishes_Filter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(650, 359);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.weight2);
            this.Controls.Add(this.weight1);
            this.Controls.Add(this.cookingTime2);
            this.Controls.Add(this.portions2TextBox);
            this.Controls.Add(this.cookingTime1);
            this.Controls.Add(this.portions1TextBox);
            this.Controls.Add(this.cancel_filtrationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.energy_categoryComboBox);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.menu_sectionComboBox);
            this.Controls.Add(this.weightCheckBox);
            this.Controls.Add(this.cookingTimeCheckBox);
            this.Controls.Add(this.portionsCheckBox);
            this.Controls.Add(this.energyCategoryCheckBox);
            this.Controls.Add(this.menuSectionCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dishes_Filter_Form";
            this.Text = "Фільтрування";
            this.Deactivate += new System.EventHandler(this.types_of_products_Filter_Form_Leave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.types_of_products_Filter_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox menuSectionCheckBox;
        private System.Windows.Forms.CheckBox energyCategoryCheckBox;
        private System.Windows.Forms.CheckBox portionsCheckBox;
        private System.Windows.Forms.CheckBox cookingTimeCheckBox;
        private System.Windows.Forms.CheckBox weightCheckBox;
        private System.Windows.Forms.ComboBox menu_sectionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancel_filtrationButton;
        private System.Windows.Forms.TextBox portions1TextBox;
        private System.Windows.Forms.TextBox cookingTime1;
        private System.Windows.Forms.TextBox weight1;
        private System.Windows.Forms.ComboBox energy_categoryComboBox;
        private System.Windows.Forms.TextBox portions2TextBox;
        private System.Windows.Forms.TextBox cookingTime2;
        private System.Windows.Forms.TextBox weight2;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.TextBox price2;
    }
}