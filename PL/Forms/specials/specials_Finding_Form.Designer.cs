
namespace chef
{
    partial class specials_Finding_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(specials_Finding_Form));
            this.menu_sectionComboBox = new System.Windows.Forms.ComboBox();
            this.find_specialButton = new System.Windows.Forms.Button();
            this.check_storageCheckBox = new System.Windows.Forms.CheckBox();
            this.check_recentlyCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceTextBox1 = new System.Windows.Forms.NumericUpDown();
            this.priceTextBox2 = new System.Windows.Forms.NumericUpDown();
            this.priceTextBox3 = new System.Windows.Forms.NumericUpDown();
            this.dishButton3 = new System.Windows.Forms.Button();
            this.dishButton2 = new System.Windows.Forms.Button();
            this.dishButton1 = new System.Windows.Forms.Button();
            this.dishHeaderLabel = new System.Windows.Forms.Label();
            this.priceHeaderLabel = new System.Windows.Forms.Label();
            this.dishLabel3 = new System.Windows.Forms.Label();
            this.dishLabel2 = new System.Windows.Forms.Label();
            this.dishLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_sectionComboBox
            // 
            this.menu_sectionComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.menu_sectionComboBox.Location = new System.Drawing.Point(42, 81);
            this.menu_sectionComboBox.Name = "menu_sectionComboBox";
            this.menu_sectionComboBox.Size = new System.Drawing.Size(244, 36);
            this.menu_sectionComboBox.TabIndex = 0;
            // 
            // find_specialButton
            // 
            this.find_specialButton.FlatAppearance.BorderSize = 2;
            this.find_specialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_specialButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_specialButton.Location = new System.Drawing.Point(69, 273);
            this.find_specialButton.Name = "find_specialButton";
            this.find_specialButton.Size = new System.Drawing.Size(190, 108);
            this.find_specialButton.TabIndex = 1;
            this.find_specialButton.Text = "Підібрати страву дня на сьогодні";
            this.find_specialButton.UseVisualStyleBackColor = true;
            this.find_specialButton.Click += new System.EventHandler(this.find_specialButton_Click);
            // 
            // check_storageCheckBox
            // 
            this.check_storageCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_storageCheckBox.Location = new System.Drawing.Point(42, 123);
            this.check_storageCheckBox.Name = "check_storageCheckBox";
            this.check_storageCheckBox.Size = new System.Drawing.Size(244, 69);
            this.check_storageCheckBox.TabIndex = 2;
            this.check_storageCheckBox.Text = "зважати на наявність продуктів на складі";
            this.check_storageCheckBox.UseVisualStyleBackColor = true;
            // 
            // check_recentlyCheckBox
            // 
            this.check_recentlyCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_recentlyCheckBox.Location = new System.Drawing.Point(42, 198);
            this.check_recentlyCheckBox.Name = "check_recentlyCheckBox";
            this.check_recentlyCheckBox.Size = new System.Drawing.Size(244, 69);
            this.check_recentlyCheckBox.TabIndex = 2;
            this.check_recentlyCheckBox.Text = "зважати на нещодавні страви дня";
            this.check_recentlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceTextBox1);
            this.panel1.Controls.Add(this.priceTextBox2);
            this.panel1.Controls.Add(this.priceTextBox3);
            this.panel1.Controls.Add(this.dishButton3);
            this.panel1.Controls.Add(this.dishButton2);
            this.panel1.Controls.Add(this.dishButton1);
            this.panel1.Controls.Add(this.dishHeaderLabel);
            this.panel1.Controls.Add(this.priceHeaderLabel);
            this.panel1.Controls.Add(this.dishLabel3);
            this.panel1.Controls.Add(this.dishLabel2);
            this.panel1.Controls.Add(this.dishLabel1);
            this.panel1.Location = new System.Drawing.Point(338, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 358);
            this.panel1.TabIndex = 3;
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.DecimalPlaces = 2;
            this.priceTextBox1.Enabled = false;
            this.priceTextBox1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceTextBox1.Location = new System.Drawing.Point(243, 63);
            this.priceTextBox1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(124, 36);
            this.priceTextBox1.TabIndex = 3;
            this.priceTextBox1.Visible = false;
            // 
            // priceTextBox2
            // 
            this.priceTextBox2.DecimalPlaces = 2;
            this.priceTextBox2.Enabled = false;
            this.priceTextBox2.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceTextBox2.Location = new System.Drawing.Point(243, 161);
            this.priceTextBox2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceTextBox2.Name = "priceTextBox2";
            this.priceTextBox2.Size = new System.Drawing.Size(124, 36);
            this.priceTextBox2.TabIndex = 3;
            this.priceTextBox2.Visible = false;
            // 
            // priceTextBox3
            // 
            this.priceTextBox3.DecimalPlaces = 2;
            this.priceTextBox3.Enabled = false;
            this.priceTextBox3.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceTextBox3.Location = new System.Drawing.Point(243, 258);
            this.priceTextBox3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceTextBox3.Name = "priceTextBox3";
            this.priceTextBox3.Size = new System.Drawing.Size(124, 36);
            this.priceTextBox3.TabIndex = 3;
            this.priceTextBox3.Visible = false;
            // 
            // dishButton3
            // 
            this.dishButton3.Enabled = false;
            this.dishButton3.FlatAppearance.BorderSize = 2;
            this.dishButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishButton3.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishButton3.Location = new System.Drawing.Point(373, 253);
            this.dishButton3.Name = "dishButton3";
            this.dishButton3.Size = new System.Drawing.Size(114, 47);
            this.dishButton3.TabIndex = 2;
            this.dishButton3.Text = "Обрати";
            this.dishButton3.UseVisualStyleBackColor = true;
            this.dishButton3.Visible = false;
            this.dishButton3.Click += new System.EventHandler(this.dishButton3_Click);
            // 
            // dishButton2
            // 
            this.dishButton2.Enabled = false;
            this.dishButton2.FlatAppearance.BorderSize = 2;
            this.dishButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishButton2.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishButton2.Location = new System.Drawing.Point(373, 156);
            this.dishButton2.Name = "dishButton2";
            this.dishButton2.Size = new System.Drawing.Size(114, 47);
            this.dishButton2.TabIndex = 2;
            this.dishButton2.Text = "Обрати";
            this.dishButton2.UseVisualStyleBackColor = true;
            this.dishButton2.Visible = false;
            this.dishButton2.Click += new System.EventHandler(this.dishButton2_Click);
            // 
            // dishButton1
            // 
            this.dishButton1.Enabled = false;
            this.dishButton1.FlatAppearance.BorderSize = 2;
            this.dishButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishButton1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishButton1.Location = new System.Drawing.Point(373, 58);
            this.dishButton1.Name = "dishButton1";
            this.dishButton1.Size = new System.Drawing.Size(114, 47);
            this.dishButton1.TabIndex = 2;
            this.dishButton1.Text = "Обрати";
            this.dishButton1.UseVisualStyleBackColor = true;
            this.dishButton1.Visible = false;
            this.dishButton1.Click += new System.EventHandler(this.dishButton1_Click);
            // 
            // dishHeaderLabel
            // 
            this.dishHeaderLabel.Enabled = false;
            this.dishHeaderLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishHeaderLabel.Location = new System.Drawing.Point(40, 9);
            this.dishHeaderLabel.Name = "dishHeaderLabel";
            this.dishHeaderLabel.Size = new System.Drawing.Size(160, 28);
            this.dishHeaderLabel.TabIndex = 1;
            this.dishHeaderLabel.Text = "Назва страви";
            this.dishHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dishHeaderLabel.Visible = false;
            // 
            // priceHeaderLabel
            // 
            this.priceHeaderLabel.Enabled = false;
            this.priceHeaderLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceHeaderLabel.Location = new System.Drawing.Point(243, 9);
            this.priceHeaderLabel.Name = "priceHeaderLabel";
            this.priceHeaderLabel.Size = new System.Drawing.Size(124, 28);
            this.priceHeaderLabel.TabIndex = 1;
            this.priceHeaderLabel.Text = "Ціна";
            this.priceHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceHeaderLabel.Visible = false;
            // 
            // dishLabel3
            // 
            this.dishLabel3.Enabled = false;
            this.dishLabel3.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishLabel3.Location = new System.Drawing.Point(3, 258);
            this.dishLabel3.Name = "dishLabel3";
            this.dishLabel3.Size = new System.Drawing.Size(234, 36);
            this.dishLabel3.TabIndex = 1;
            this.dishLabel3.Text = "label1";
            this.dishLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dishLabel3.Visible = false;
            // 
            // dishLabel2
            // 
            this.dishLabel2.Enabled = false;
            this.dishLabel2.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishLabel2.Location = new System.Drawing.Point(3, 161);
            this.dishLabel2.Name = "dishLabel2";
            this.dishLabel2.Size = new System.Drawing.Size(234, 36);
            this.dishLabel2.TabIndex = 1;
            this.dishLabel2.Text = "label1";
            this.dishLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dishLabel2.Visible = false;
            // 
            // dishLabel1
            // 
            this.dishLabel1.Enabled = false;
            this.dishLabel1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishLabel1.Location = new System.Drawing.Point(3, 63);
            this.dishLabel1.Name = "dishLabel1";
            this.dishLabel1.Size = new System.Drawing.Size(234, 36);
            this.dishLabel1.TabIndex = 1;
            this.dishLabel1.Text = "label1";
            this.dishLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dishLabel1.Visible = false;
            // 
            // specials_Finding_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.check_recentlyCheckBox);
            this.Controls.Add(this.check_storageCheckBox);
            this.Controls.Add(this.find_specialButton);
            this.Controls.Add(this.menu_sectionComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "specials_Finding_Form";
            this.Text = "Визначення страви дня";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTextBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox menu_sectionComboBox;
        private System.Windows.Forms.Button find_specialButton;
        private System.Windows.Forms.CheckBox check_storageCheckBox;
        private System.Windows.Forms.CheckBox check_recentlyCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dishButton3;
        private System.Windows.Forms.Button dishButton2;
        private System.Windows.Forms.Button dishButton1;
        private System.Windows.Forms.Label dishHeaderLabel;
        private System.Windows.Forms.Label priceHeaderLabel;
        private System.Windows.Forms.Label dishLabel3;
        private System.Windows.Forms.Label dishLabel2;
        private System.Windows.Forms.Label dishLabel1;
        private System.Windows.Forms.NumericUpDown priceTextBox1;
        private System.Windows.Forms.NumericUpDown priceTextBox2;
        private System.Windows.Forms.NumericUpDown priceTextBox3;
    }
}