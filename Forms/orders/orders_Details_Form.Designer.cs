
namespace chef
{
    partial class orders_Details_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders_Details_Form));
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredient_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesLabel = new System.Windows.Forms.Label();
            this.is_completedLabel = new System.Windows.Forms.Label();
            this.order_dateLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.order_dateTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.is_completedTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.make_invoiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(310, 580);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 61);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Вийти";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
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
            this.ingredient_amount});
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
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(452, 359);
            this.dataGridView.TabIndex = 17;
            // 
            // type_id
            // 
            this.type_id.FillWeight = 120F;
            this.type_id.HeaderText = "Страва";
            this.type_id.MinimumWidth = 6;
            this.type_id.Name = "type_id";
            this.type_id.ReadOnly = true;
            this.type_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ingredient_amount
            // 
            this.ingredient_amount.FillWeight = 80F;
            this.ingredient_amount.HeaderText = "Кількість порцій";
            this.ingredient_amount.MinimumWidth = 6;
            this.ingredient_amount.Name = "ingredient_amount";
            this.ingredient_amount.ReadOnly = true;
            this.ingredient_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // is_completedLabel
            // 
            this.is_completedLabel.AutoSize = true;
            this.is_completedLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_completedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.is_completedLabel.Location = new System.Drawing.Point(42, 526);
            this.is_completedLabel.Name = "is_completedLabel";
            this.is_completedLabel.Size = new System.Drawing.Size(193, 29);
            this.is_completedLabel.TabIndex = 22;
            this.is_completedLabel.Text = "Статус виконання";
            // 
            // order_dateLabel
            // 
            this.order_dateLabel.AutoSize = true;
            this.order_dateLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.order_dateLabel.Location = new System.Drawing.Point(58, 484);
            this.order_dateLabel.Name = "order_dateLabel";
            this.order_dateLabel.Size = new System.Drawing.Size(177, 29);
            this.order_dateLabel.TabIndex = 21;
            this.order_dateLabel.Text = "Час замовлення";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.totalLabel.Location = new System.Drawing.Point(170, 442);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(65, 29);
            this.totalLabel.TabIndex = 21;
            this.totalLabel.Text = "Сума";
            // 
            // order_dateTextBox
            // 
            this.order_dateTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_dateTextBox.Location = new System.Drawing.Point(241, 481);
            this.order_dateTextBox.Name = "order_dateTextBox";
            this.order_dateTextBox.ReadOnly = true;
            this.order_dateTextBox.Size = new System.Drawing.Size(231, 36);
            this.order_dateTextBox.TabIndex = 23;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTextBox.Location = new System.Drawing.Point(241, 439);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(231, 36);
            this.totalTextBox.TabIndex = 23;
            // 
            // is_completedTextBox
            // 
            this.is_completedTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_completedTextBox.Location = new System.Drawing.Point(241, 523);
            this.is_completedTextBox.Name = "is_completedTextBox";
            this.is_completedTextBox.ReadOnly = true;
            this.is_completedTextBox.Size = new System.Drawing.Size(231, 36);
            this.is_completedTextBox.TabIndex = 23;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.headerLabel.Location = new System.Drawing.Point(20, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(452, 29);
            this.headerLabel.TabIndex = 24;
            this.headerLabel.Text = "Нове замовлення";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // make_invoiceButton
            // 
            this.make_invoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.make_invoiceButton.FlatAppearance.BorderSize = 2;
            this.make_invoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.make_invoiceButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.make_invoiceButton.Location = new System.Drawing.Point(30, 580);
            this.make_invoiceButton.Name = "make_invoiceButton";
            this.make_invoiceButton.Size = new System.Drawing.Size(264, 61);
            this.make_invoiceButton.TabIndex = 8;
            this.make_invoiceButton.Text = "Сформувати накладну";
            this.make_invoiceButton.UseVisualStyleBackColor = false;
            this.make_invoiceButton.Click += new System.EventHandler(this.make_invoiceButton_Click);
            // 
            // orders_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(484, 653);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.is_completedTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.order_dateTextBox);
            this.Controls.Add(this.is_completedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.order_dateLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.make_invoiceButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dishesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "orders_Details_Form";
            this.Text = "orders_Details_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label dishesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient_amount;
        private System.Windows.Forms.Label is_completedLabel;
        private System.Windows.Forms.Label order_dateLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox order_dateTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox is_completedTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button make_invoiceButton;
    }
}