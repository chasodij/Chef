
namespace chef
{
    partial class products_AddEdit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products_AddEdit_Form));
            this.product_nameLabel = new System.Windows.Forms.Label();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_priceLabel = new System.Windows.Forms.Label();
            this.product_priceTextBox = new System.Windows.Forms.NumericUpDown();
            this.product_amountTextBox = new System.Windows.Forms.NumericUpDown();
            this.product_amountLabel = new System.Windows.Forms.Label();
            this.saveButon = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.type_idComboBox = new System.Windows.Forms.ComboBox();
            this.type_idLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.product_priceLabel1 = new System.Windows.Forms.Label();
            this.expiration_dateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expiration_dateLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.product_priceTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_amountTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_nameLabel
            // 
            this.product_nameLabel.AutoSize = true;
            this.product_nameLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.product_nameLabel.Location = new System.Drawing.Point(32, 29);
            this.product_nameLabel.Name = "product_nameLabel";
            this.product_nameLabel.Size = new System.Drawing.Size(74, 29);
            this.product_nameLabel.TabIndex = 0;
            this.product_nameLabel.Text = "Назва";
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_nameTextBox.Location = new System.Drawing.Point(201, 26);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(260, 36);
            this.product_nameTextBox.TabIndex = 1;
            this.product_nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.product_nameTextBox_Validating);
            // 
            // product_priceLabel
            // 
            this.product_priceLabel.AutoSize = true;
            this.product_priceLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.product_priceLabel.Location = new System.Drawing.Point(32, 177);
            this.product_priceLabel.Name = "product_priceLabel";
            this.product_priceLabel.Size = new System.Drawing.Size(59, 29);
            this.product_priceLabel.TabIndex = 2;
            this.product_priceLabel.Text = "Ціна";
            // 
            // product_priceTextBox
            // 
            this.product_priceTextBox.DecimalPlaces = 2;
            this.product_priceTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_priceTextBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.product_priceTextBox.Location = new System.Drawing.Point(201, 175);
            this.product_priceTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.product_priceTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.product_priceTextBox.Name = "product_priceTextBox";
            this.product_priceTextBox.Size = new System.Drawing.Size(173, 36);
            this.product_priceTextBox.TabIndex = 4;
            this.product_priceTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // product_amountTextBox
            // 
            this.product_amountTextBox.DecimalPlaces = 2;
            this.product_amountTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_amountTextBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.product_amountTextBox.Location = new System.Drawing.Point(201, 223);
            this.product_amountTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.product_amountTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.product_amountTextBox.Name = "product_amountTextBox";
            this.product_amountTextBox.Size = new System.Drawing.Size(173, 36);
            this.product_amountTextBox.TabIndex = 5;
            this.product_amountTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // product_amountLabel
            // 
            this.product_amountLabel.AutoSize = true;
            this.product_amountLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.product_amountLabel.Location = new System.Drawing.Point(32, 225);
            this.product_amountLabel.Name = "product_amountLabel";
            this.product_amountLabel.Size = new System.Drawing.Size(102, 29);
            this.product_amountLabel.TabIndex = 7;
            this.product_amountLabel.Text = "Кількість";
            // 
            // saveButon
            // 
            this.saveButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.saveButon.FlatAppearance.BorderSize = 2;
            this.saveButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButon.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButon.Location = new System.Drawing.Point(96, 327);
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
            this.cancelButton.Location = new System.Drawing.Point(261, 327);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 61);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // type_idComboBox
            // 
            this.type_idComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_idComboBox.FormattingEnabled = true;
            this.type_idComboBox.Location = new System.Drawing.Point(201, 75);
            this.type_idComboBox.Name = "type_idComboBox";
            this.type_idComboBox.Size = new System.Drawing.Size(260, 36);
            this.type_idComboBox.TabIndex = 2;
            this.type_idComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.type_idComboBox_Validating);
            // 
            // type_idLabel
            // 
            this.type_idLabel.AutoSize = true;
            this.type_idLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.type_idLabel.Location = new System.Drawing.Point(32, 78);
            this.type_idLabel.Name = "type_idLabel";
            this.type_idLabel.Size = new System.Drawing.Size(147, 29);
            this.type_idLabel.TabIndex = 13;
            this.type_idLabel.Text = "Тип продукту";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.manufacturerLabel.Location = new System.Drawing.Point(32, 126);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(115, 29);
            this.manufacturerLabel.TabIndex = 0;
            this.manufacturerLabel.Text = "Виробник";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerTextBox.Location = new System.Drawing.Point(201, 123);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(260, 36);
            this.manufacturerTextBox.TabIndex = 3;
            this.manufacturerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.manufacturerTextBox_Validating);
            // 
            // product_priceLabel1
            // 
            this.product_priceLabel1.AutoSize = true;
            this.product_priceLabel1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_priceLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.product_priceLabel1.Location = new System.Drawing.Point(378, 177);
            this.product_priceLabel1.Name = "product_priceLabel1";
            this.product_priceLabel1.Size = new System.Drawing.Size(47, 29);
            this.product_priceLabel1.TabIndex = 14;
            this.product_priceLabel1.Text = "грн";
            // 
            // expiration_dateDatePicker
            // 
            this.expiration_dateDatePicker.CalendarFont = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiration_dateDatePicker.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiration_dateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiration_dateDatePicker.Location = new System.Drawing.Point(201, 271);
            this.expiration_dateDatePicker.Name = "expiration_dateDatePicker";
            this.expiration_dateDatePicker.Size = new System.Drawing.Size(173, 36);
            this.expiration_dateDatePicker.TabIndex = 6;
            // 
            // expiration_dateLabel
            // 
            this.expiration_dateLabel.AutoSize = true;
            this.expiration_dateLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiration_dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.expiration_dateLabel.Location = new System.Drawing.Point(32, 271);
            this.expiration_dateLabel.Name = "expiration_dateLabel";
            this.expiration_dateLabel.Size = new System.Drawing.Size(158, 29);
            this.expiration_dateLabel.TabIndex = 16;
            this.expiration_dateLabel.Text = "Придатний до";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // products_AddEdit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(502, 412);
            this.Controls.Add(this.expiration_dateLabel);
            this.Controls.Add(this.expiration_dateDatePicker);
            this.Controls.Add(this.product_priceLabel1);
            this.Controls.Add(this.type_idLabel);
            this.Controls.Add(this.type_idComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButon);
            this.Controls.Add(this.product_amountTextBox);
            this.Controls.Add(this.product_amountLabel);
            this.Controls.Add(this.product_priceTextBox);
            this.Controls.Add(this.product_priceLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(this.product_nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "products_AddEdit_Form";
            this.Text = "products_AddEdit_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.products_AddEdit_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.product_priceTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_amountTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_nameLabel;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.Label product_priceLabel;
        private System.Windows.Forms.NumericUpDown product_priceTextBox;
        private System.Windows.Forms.NumericUpDown product_amountTextBox;
        private System.Windows.Forms.Label product_amountLabel;
        private System.Windows.Forms.Button saveButon;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox type_idComboBox;
        private System.Windows.Forms.Label type_idLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.Label product_priceLabel1;
        private System.Windows.Forms.DateTimePicker expiration_dateDatePicker;
        private System.Windows.Forms.Label expiration_dateLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}