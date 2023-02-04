
namespace chef
{
    partial class orders_AddEdit_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders_AddEdit_Form));
            this.saveButon = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.type_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ingredient_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesLabel = new System.Windows.Forms.Label();
            this.add_rowButton = new System.Windows.Forms.Button();
            this.delete_rowButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.is_completedCheckBox = new System.Windows.Forms.CheckBox();
            this.order_dateLabel = new System.Windows.Forms.Label();
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.is_completedLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButon
            // 
            this.saveButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.saveButon.FlatAppearance.BorderSize = 2;
            this.saveButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButon.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButon.Location = new System.Drawing.Point(79, 658);
            this.saveButon.Name = "saveButon";
            this.saveButon.Size = new System.Drawing.Size(145, 61);
            this.saveButon.TabIndex = 3;
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
            this.cancelButton.Location = new System.Drawing.Point(261, 658);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 61);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type_id,
            this.ingredient_amount,
            this.warning,
            this.multiplicity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(20, 74);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(452, 382);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.dataGridView_Validating);
            // 
            // type_id
            // 
            this.type_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.type_id.FillWeight = 120F;
            this.type_id.HeaderText = "Страва";
            this.type_id.MinimumWidth = 6;
            this.type_id.Name = "type_id";
            this.type_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ingredient_amount
            // 
            this.ingredient_amount.FillWeight = 80F;
            this.ingredient_amount.HeaderText = "Кількість порцій";
            this.ingredient_amount.MinimumWidth = 6;
            this.ingredient_amount.Name = "ingredient_amount";
            this.ingredient_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // warning
            // 
            this.warning.FillWeight = 25F;
            this.warning.HeaderText = "";
            this.warning.MinimumWidth = 6;
            this.warning.Name = "warning";
            this.warning.ReadOnly = true;
            this.warning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // multiplicity
            // 
            this.multiplicity.HeaderText = "Column1";
            this.multiplicity.MinimumWidth = 6;
            this.multiplicity.Name = "multiplicity";
            this.multiplicity.Visible = false;
            // 
            // dishesLabel
            // 
            this.dishesLabel.AutoSize = true;
            this.dishesLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.dishesLabel.Location = new System.Drawing.Point(200, 42);
            this.dishesLabel.Name = "dishesLabel";
            this.dishesLabel.Size = new System.Drawing.Size(85, 29);
            this.dishesLabel.TabIndex = 0;
            this.dishesLabel.Text = "Страви";
            // 
            // add_rowButton
            // 
            this.add_rowButton.BackgroundImage = global::chef.Properties.Resources.add;
            this.add_rowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_rowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_rowButton.FlatAppearance.BorderSize = 0;
            this.add_rowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_rowButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_rowButton.Location = new System.Drawing.Point(165, 487);
            this.add_rowButton.Name = "add_rowButton";
            this.add_rowButton.Size = new System.Drawing.Size(54, 54);
            this.add_rowButton.TabIndex = 6;
            this.add_rowButton.UseVisualStyleBackColor = true;
            this.add_rowButton.Click += new System.EventHandler(this.add_rowButton_Click);
            // 
            // delete_rowButton
            // 
            this.delete_rowButton.BackgroundImage = global::chef.Properties.Resources.del1;
            this.delete_rowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_rowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_rowButton.FlatAppearance.BorderSize = 0;
            this.delete_rowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_rowButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_rowButton.Location = new System.Drawing.Point(266, 487);
            this.delete_rowButton.Name = "delete_rowButton";
            this.delete_rowButton.Size = new System.Drawing.Size(54, 54);
            this.delete_rowButton.TabIndex = 7;
            this.delete_rowButton.UseVisualStyleBackColor = true;
            this.delete_rowButton.Click += new System.EventHandler(this.delete_rowButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Calibri", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(46)))), ((int)(((byte)(5)))));
            this.warningLabel.Location = new System.Drawing.Point(20, 459);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(452, 24);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.Text = "* введено неповні, або некоректні дані";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningLabel.Visible = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.headerLabel.Location = new System.Drawing.Point(20, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(452, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Нове замовлення";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // is_completedCheckBox
            // 
            this.is_completedCheckBox.AutoSize = true;
            this.is_completedCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_completedCheckBox.Location = new System.Drawing.Point(215, 610);
            this.is_completedCheckBox.Name = "is_completedCheckBox";
            this.is_completedCheckBox.Size = new System.Drawing.Size(131, 33);
            this.is_completedCheckBox.TabIndex = 2;
            this.is_completedCheckBox.Text = "виконане";
            this.is_completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // order_dateLabel
            // 
            this.order_dateLabel.AutoSize = true;
            this.order_dateLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.order_dateLabel.Location = new System.Drawing.Point(15, 564);
            this.order_dateLabel.Name = "order_dateLabel";
            this.order_dateLabel.Size = new System.Drawing.Size(177, 29);
            this.order_dateLabel.TabIndex = 0;
            this.order_dateLabel.Text = "Час замовлення";
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.CalendarFont = new System.Drawing.Font("Calibri", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_dateDateTimePicker.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(215, 558);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(257, 36);
            this.order_dateDateTimePicker.TabIndex = 1;
            // 
            // is_completedLabel
            // 
            this.is_completedLabel.AutoSize = true;
            this.is_completedLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_completedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.is_completedLabel.Location = new System.Drawing.Point(15, 610);
            this.is_completedLabel.Name = "is_completedLabel";
            this.is_completedLabel.Size = new System.Drawing.Size(193, 29);
            this.is_completedLabel.TabIndex = 20;
            this.is_completedLabel.Text = "Статус виконання";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(336, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 29);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
            // 
            // orders_AddEdit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(484, 729);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.is_completedLabel);
            this.Controls.Add(this.order_dateDateTimePicker);
            this.Controls.Add(this.is_completedCheckBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.delete_rowButton);
            this.Controls.Add(this.add_rowButton);
            this.Controls.Add(this.saveButon);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.order_dateLabel);
            this.Controls.Add(this.dishesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "orders_AddEdit_Form";
            this.Text = "orders_AddEdit_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orders_AddEdit_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButon;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label dishesLabel;
        private System.Windows.Forms.Button add_rowButton;
        private System.Windows.Forms.Button delete_rowButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.DataGridViewComboBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn warning;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.CheckBox is_completedCheckBox;
        private System.Windows.Forms.Label order_dateLabel;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.Label is_completedLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplicity;
    }
}