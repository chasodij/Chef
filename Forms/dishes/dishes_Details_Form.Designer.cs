
namespace chef
{
    partial class dishes_Details_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dishes_Details_Form));
            this.dish_nameLabel = new System.Windows.Forms.Label();
            this.dish_nameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menu_sectionLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredient_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units_of_measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dish_portionsLabel = new System.Windows.Forms.Label();
            this.cooking_timeLabel = new System.Windows.Forms.Label();
            this.cooking_timeLabel1 = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.dish_priceLabel = new System.Windows.Forms.Label();
            this.dish_priceLabel1 = new System.Windows.Forms.Label();
            this.massLabel1 = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.recipeTextBox = new System.Windows.Forms.RichTextBox();
            this.menu_sectionTextBox = new System.Windows.Forms.TextBox();
            this.dish_portionsTextBox = new System.Windows.Forms.TextBox();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.cooking_timeTextBox = new System.Windows.Forms.TextBox();
            this.dish_priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dish_nameLabel
            // 
            this.dish_nameLabel.AutoSize = true;
            this.dish_nameLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.dish_nameLabel.Location = new System.Drawing.Point(506, 24);
            this.dish_nameLabel.Name = "dish_nameLabel";
            this.dish_nameLabel.Size = new System.Drawing.Size(74, 29);
            this.dish_nameLabel.TabIndex = 0;
            this.dish_nameLabel.Text = "Назва";
            // 
            // dish_nameTextBox
            // 
            this.dish_nameTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_nameTextBox.Location = new System.Drawing.Point(584, 21);
            this.dish_nameTextBox.Name = "dish_nameTextBox";
            this.dish_nameTextBox.ReadOnly = true;
            this.dish_nameTextBox.Size = new System.Drawing.Size(427, 36);
            this.dish_nameTextBox.TabIndex = 99;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(669, 538);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 61);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Вийти";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // menu_sectionLabel
            // 
            this.menu_sectionLabel.AutoSize = true;
            this.menu_sectionLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_sectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.menu_sectionLabel.Location = new System.Drawing.Point(438, 76);
            this.menu_sectionLabel.Name = "menu_sectionLabel";
            this.menu_sectionLabel.Size = new System.Drawing.Size(142, 29);
            this.menu_sectionLabel.TabIndex = 13;
            this.menu_sectionLabel.Text = "Розділ меню";
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
            this.ingredient_amount,
            this.units_of_measurement});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(12, 56);
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
            this.dataGridView.Size = new System.Drawing.Size(368, 476);
            this.dataGridView.TabIndex = 17;
            // 
            // type_id
            // 
            this.type_id.FillWeight = 120F;
            this.type_id.HeaderText = "Інгредієнт";
            this.type_id.MinimumWidth = 6;
            this.type_id.Name = "type_id";
            this.type_id.ReadOnly = true;
            this.type_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ingredient_amount
            // 
            this.ingredient_amount.FillWeight = 80F;
            this.ingredient_amount.HeaderText = "Кількість";
            this.ingredient_amount.MinimumWidth = 6;
            this.ingredient_amount.Name = "ingredient_amount";
            this.ingredient_amount.ReadOnly = true;
            this.ingredient_amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // units_of_measurement
            // 
            this.units_of_measurement.FillWeight = 25F;
            this.units_of_measurement.HeaderText = "";
            this.units_of_measurement.MinimumWidth = 6;
            this.units_of_measurement.Name = "units_of_measurement";
            this.units_of_measurement.ReadOnly = true;
            this.units_of_measurement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dish_portionsLabel
            // 
            this.dish_portionsLabel.AutoSize = true;
            this.dish_portionsLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_portionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.dish_portionsLabel.Location = new System.Drawing.Point(402, 126);
            this.dish_portionsLabel.Name = "dish_portionsLabel";
            this.dish_portionsLabel.Size = new System.Drawing.Size(178, 29);
            this.dish_portionsLabel.TabIndex = 7;
            this.dish_portionsLabel.Text = "Кількість порцій";
            // 
            // cooking_timeLabel
            // 
            this.cooking_timeLabel.AutoSize = true;
            this.cooking_timeLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cooking_timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.cooking_timeLabel.Location = new System.Drawing.Point(386, 177);
            this.cooking_timeLabel.Name = "cooking_timeLabel";
            this.cooking_timeLabel.Size = new System.Drawing.Size(194, 29);
            this.cooking_timeLabel.TabIndex = 7;
            this.cooking_timeLabel.Text = "Час приготування";
            // 
            // cooking_timeLabel1
            // 
            this.cooking_timeLabel1.AutoSize = true;
            this.cooking_timeLabel1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cooking_timeLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.cooking_timeLabel1.Location = new System.Drawing.Point(763, 178);
            this.cooking_timeLabel1.Name = "cooking_timeLabel1";
            this.cooking_timeLabel1.Size = new System.Drawing.Size(35, 29);
            this.cooking_timeLabel1.TabIndex = 14;
            this.cooking_timeLabel1.Text = "хв";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.massLabel.Location = new System.Drawing.Point(776, 127);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(169, 29);
            this.massLabel.TabIndex = 7;
            this.massLabel.Text = "Маса на виході";
            // 
            // dish_priceLabel
            // 
            this.dish_priceLabel.AutoSize = true;
            this.dish_priceLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.dish_priceLabel.Location = new System.Drawing.Point(883, 178);
            this.dish_priceLabel.Name = "dish_priceLabel";
            this.dish_priceLabel.Size = new System.Drawing.Size(59, 29);
            this.dish_priceLabel.TabIndex = 2;
            this.dish_priceLabel.Text = "Ціна";
            // 
            // dish_priceLabel1
            // 
            this.dish_priceLabel1.AutoSize = true;
            this.dish_priceLabel1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_priceLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.dish_priceLabel1.Location = new System.Drawing.Point(1123, 178);
            this.dish_priceLabel1.Name = "dish_priceLabel1";
            this.dish_priceLabel1.Size = new System.Drawing.Size(47, 29);
            this.dish_priceLabel1.TabIndex = 14;
            this.dish_priceLabel1.Text = "грн";
            // 
            // massLabel1
            // 
            this.massLabel1.AutoSize = true;
            this.massLabel1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.massLabel1.Location = new System.Drawing.Point(1120, 127);
            this.massLabel1.Name = "massLabel1";
            this.massLabel1.Size = new System.Drawing.Size(21, 29);
            this.massLabel1.TabIndex = 14;
            this.massLabel1.Text = "г";
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.recipeLabel.Location = new System.Drawing.Point(496, 228);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(84, 29);
            this.recipeLabel.TabIndex = 7;
            this.recipeLabel.Text = "Рецепт";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(49)))), ((int)(((byte)(7)))));
            this.ingredientsLabel.Location = new System.Drawing.Point(131, 24);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(130, 29);
            this.ingredientsLabel.TabIndex = 0;
            this.ingredientsLabel.Text = "Інгредієнти";
            // 
            // recipeTextBox
            // 
            this.recipeTextBox.Font = new System.Drawing.Font("Calibri", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeTextBox.Location = new System.Drawing.Point(584, 226);
            this.recipeTextBox.Name = "recipeTextBox";
            this.recipeTextBox.ReadOnly = true;
            this.recipeTextBox.Size = new System.Drawing.Size(537, 306);
            this.recipeTextBox.TabIndex = 18;
            this.recipeTextBox.Text = "";
            // 
            // menu_sectionTextBox
            // 
            this.menu_sectionTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_sectionTextBox.Location = new System.Drawing.Point(584, 76);
            this.menu_sectionTextBox.Name = "menu_sectionTextBox";
            this.menu_sectionTextBox.ReadOnly = true;
            this.menu_sectionTextBox.Size = new System.Drawing.Size(273, 36);
            this.menu_sectionTextBox.TabIndex = 19;
            // 
            // dish_portionsTextBox
            // 
            this.dish_portionsTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_portionsTextBox.Location = new System.Drawing.Point(584, 124);
            this.dish_portionsTextBox.Name = "dish_portionsTextBox";
            this.dish_portionsTextBox.ReadOnly = true;
            this.dish_portionsTextBox.Size = new System.Drawing.Size(173, 36);
            this.dish_portionsTextBox.TabIndex = 20;
            // 
            // massTextBox
            // 
            this.massTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massTextBox.Location = new System.Drawing.Point(948, 123);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.ReadOnly = true;
            this.massTextBox.Size = new System.Drawing.Size(173, 36);
            this.massTextBox.TabIndex = 21;
            // 
            // cooking_timeTextBox
            // 
            this.cooking_timeTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cooking_timeTextBox.Location = new System.Drawing.Point(584, 177);
            this.cooking_timeTextBox.Name = "cooking_timeTextBox";
            this.cooking_timeTextBox.ReadOnly = true;
            this.cooking_timeTextBox.Size = new System.Drawing.Size(173, 36);
            this.cooking_timeTextBox.TabIndex = 22;
            // 
            // dish_priceTextBox
            // 
            this.dish_priceTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_priceTextBox.Location = new System.Drawing.Point(948, 174);
            this.dish_priceTextBox.Name = "dish_priceTextBox";
            this.dish_priceTextBox.ReadOnly = true;
            this.dish_priceTextBox.Size = new System.Drawing.Size(173, 36);
            this.dish_priceTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(362, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Переглянути розкладку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dishes_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1177, 611);
            this.Controls.Add(this.dish_priceTextBox);
            this.Controls.Add(this.cooking_timeTextBox);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.dish_portionsTextBox);
            this.Controls.Add(this.menu_sectionTextBox);
            this.Controls.Add(this.recipeTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.massLabel1);
            this.Controls.Add(this.cooking_timeLabel1);
            this.Controls.Add(this.dish_priceLabel1);
            this.Controls.Add(this.menu_sectionLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.cooking_timeLabel);
            this.Controls.Add(this.recipeLabel);
            this.Controls.Add(this.massLabel);
            this.Controls.Add(this.dish_portionsLabel);
            this.Controls.Add(this.dish_priceLabel);
            this.Controls.Add(this.dish_nameTextBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.dish_nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dishes_Details_Form";
            this.Text = "dishes_Details_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dish_nameLabel;
        private System.Windows.Forms.TextBox dish_nameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label menu_sectionLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label dish_portionsLabel;
        private System.Windows.Forms.Label cooking_timeLabel;
        private System.Windows.Forms.Label cooking_timeLabel1;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.Label dish_priceLabel;
        private System.Windows.Forms.Label dish_priceLabel1;
        private System.Windows.Forms.Label massLabel1;
        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.RichTextBox recipeTextBox;
        private System.Windows.Forms.TextBox menu_sectionTextBox;
        private System.Windows.Forms.TextBox dish_portionsTextBox;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TextBox cooking_timeTextBox;
        private System.Windows.Forms.TextBox dish_priceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn units_of_measurement;
        private System.Windows.Forms.Button button1;
    }
}