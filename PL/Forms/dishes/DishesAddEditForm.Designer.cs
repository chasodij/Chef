
namespace chef
{
    partial class DishesAddEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishesAddEditForm));
            this.dish_nameLabel = new System.Windows.Forms.Label();
            this.dishNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButon = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuSectionComboBox = new System.Windows.Forms.ComboBox();
            this.menu_sectionLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.type_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ingredient_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units_of_measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEdited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dish_portionsLabel = new System.Windows.Forms.Label();
            this.dishPortionsTextBox = new System.Windows.Forms.NumericUpDown();
            this.cooking_timeLabel = new System.Windows.Forms.Label();
            this.cookingTimeTextBox = new System.Windows.Forms.NumericUpDown();
            this.cooking_timeLabel1 = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.NumericUpDown();
            this.dish_priceLabel = new System.Windows.Forms.Label();
            this.dishPriceTextBox = new System.Windows.Forms.NumericUpDown();
            this.dish_priceLabel1 = new System.Windows.Forms.Label();
            this.massLabel1 = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.recipeTextBox = new System.Windows.Forms.RichTextBox();
            this.add_rowButton = new System.Windows.Forms.Button();
            this.delete_rowButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPortionsTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingTimeTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPriceTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.dishNameTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishNameTextBox.Location = new System.Drawing.Point(584, 21);
            this.dishNameTextBox.Name = "dish_nameTextBox";
            this.dishNameTextBox.Size = new System.Drawing.Size(427, 36);
            this.dishNameTextBox.TabIndex = 1;
            this.dishNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DishNameTextBox_Validating);
            // 
            // saveButon
            // 
            this.saveButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.saveButon.FlatAppearance.BorderSize = 2;
            this.saveButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButon.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButon.Location = new System.Drawing.Point(653, 538);
            this.saveButon.Name = "saveButon";
            this.saveButon.Size = new System.Drawing.Size(145, 61);
            this.saveButon.TabIndex = 8;
            this.saveButon.Text = "button1";
            this.saveButon.UseVisualStyleBackColor = false;
            this.saveButon.Click += new System.EventHandler(this.SaveButon_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(925, 538);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(145, 61);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // menu_sectionComboBox
            // 
            this.menuSectionComboBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuSectionComboBox.FormattingEnabled = true;
            this.menuSectionComboBox.Items.AddRange(new object[] {
            "Холодні страви та закуски",
            "Гарячі закуски",
            "Перші страви",
            "Другі страви",
            "Гарніри",
            "Хлібобулочні вироби",
            "Десерти",
            "Безалкогольні напої",
            "Алкогольні напої"});
            this.menuSectionComboBox.Location = new System.Drawing.Point(584, 73);
            this.menuSectionComboBox.Name = "menu_sectionComboBox";
            this.menuSectionComboBox.Size = new System.Drawing.Size(262, 36);
            this.menuSectionComboBox.TabIndex = 2;
            this.menuSectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.MenuSectionComboBox_Validating);
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
            this.units_of_measurement,
            this.warning,
            this.isEdited});
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
            this.dataGridView.Size = new System.Drawing.Size(368, 450);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            this.dataGridView.Validating += new System.ComponentModel.CancelEventHandler(this.DataGridView_Validating);
            // 
            // type_id
            // 
            this.type_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.type_id.FillWeight = 120F;
            this.type_id.HeaderText = "Інгредієнт";
            this.type_id.MinimumWidth = 6;
            this.type_id.Name = "type_id";
            this.type_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ingredient_amount
            // 
            this.ingredient_amount.FillWeight = 80F;
            this.ingredient_amount.HeaderText = "Кількість";
            this.ingredient_amount.MinimumWidth = 6;
            this.ingredient_amount.Name = "ingredient_amount";
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
            // warning
            // 
            this.warning.FillWeight = 25F;
            this.warning.HeaderText = "";
            this.warning.MinimumWidth = 6;
            this.warning.Name = "warning";
            this.warning.ReadOnly = true;
            this.warning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // isEdited
            // 
            this.isEdited.HeaderText = "";
            this.isEdited.MinimumWidth = 6;
            this.isEdited.Name = "isEdited";
            this.isEdited.ReadOnly = true;
            this.isEdited.Visible = false;
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
            // dish_portionsTextBox
            // 
            this.dishPortionsTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishPortionsTextBox.Location = new System.Drawing.Point(584, 123);
            this.dishPortionsTextBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dishPortionsTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dishPortionsTextBox.Name = "dish_portionsTextBox";
            this.dishPortionsTextBox.Size = new System.Drawing.Size(173, 36);
            this.dishPortionsTextBox.TabIndex = 3;
            this.dishPortionsTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // cooking_timeTextBox
            // 
            this.cookingTimeTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cookingTimeTextBox.Location = new System.Drawing.Point(584, 174);
            this.cookingTimeTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cookingTimeTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cookingTimeTextBox.Name = "cooking_timeTextBox";
            this.cookingTimeTextBox.Size = new System.Drawing.Size(173, 36);
            this.cookingTimeTextBox.TabIndex = 5;
            this.cookingTimeTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // massTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightTextBox.Location = new System.Drawing.Point(948, 123);
            this.weightTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.weightTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightTextBox.Name = "massTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(173, 36);
            this.weightTextBox.TabIndex = 4;
            this.weightTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // dish_priceTextBox
            // 
            this.dishPriceTextBox.DecimalPlaces = 2;
            this.dishPriceTextBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishPriceTextBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.dishPriceTextBox.Location = new System.Drawing.Point(948, 174);
            this.dishPriceTextBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dishPriceTextBox.Name = "dish_priceTextBox";
            this.dishPriceTextBox.Size = new System.Drawing.Size(173, 36);
            this.dishPriceTextBox.TabIndex = 6;
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
            this.recipeTextBox.Size = new System.Drawing.Size(537, 306);
            this.recipeTextBox.TabIndex = 7;
            this.recipeTextBox.Text = "";
            // 
            // add_rowButton
            // 
            this.add_rowButton.BackColor = System.Drawing.Color.Transparent;
            this.add_rowButton.BackgroundImage = global::chef.Properties.Resources.add;
            this.add_rowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_rowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_rowButton.FlatAppearance.BorderSize = 0;
            this.add_rowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_rowButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_rowButton.Location = new System.Drawing.Point(98, 538);
            this.add_rowButton.Name = "add_rowButton";
            this.add_rowButton.Size = new System.Drawing.Size(61, 61);
            this.add_rowButton.TabIndex = 10;
            this.add_rowButton.UseVisualStyleBackColor = false;
            this.add_rowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // delete_rowButton
            // 
            this.delete_rowButton.BackColor = System.Drawing.Color.Transparent;
            this.delete_rowButton.BackgroundImage = global::chef.Properties.Resources.del1;
            this.delete_rowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_rowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_rowButton.FlatAppearance.BorderSize = 0;
            this.delete_rowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_rowButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_rowButton.Location = new System.Drawing.Point(229, 538);
            this.delete_rowButton.Name = "delete_rowButton";
            this.delete_rowButton.Size = new System.Drawing.Size(61, 61);
            this.delete_rowButton.TabIndex = 11;
            this.delete_rowButton.UseVisualStyleBackColor = false;
            this.delete_rowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Calibri", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(46)))), ((int)(((byte)(5)))));
            this.warningLabel.Location = new System.Drawing.Point(12, 509);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(368, 26);
            this.warningLabel.TabIndex = 18;
            this.warningLabel.Text = "* введено неповні, або некоректні дані";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warningLabel.Visible = false;
            // 
            // dishes_AddEdit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1177, 611);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.recipeTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.massLabel1);
            this.Controls.Add(this.cooking_timeLabel1);
            this.Controls.Add(this.dish_priceLabel1);
            this.Controls.Add(this.menu_sectionLabel);
            this.Controls.Add(this.menuSectionComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.delete_rowButton);
            this.Controls.Add(this.add_rowButton);
            this.Controls.Add(this.saveButon);
            this.Controls.Add(this.cookingTimeTextBox);
            this.Controls.Add(this.cooking_timeLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.recipeLabel);
            this.Controls.Add(this.massLabel);
            this.Controls.Add(this.dishPortionsTextBox);
            this.Controls.Add(this.dish_portionsLabel);
            this.Controls.Add(this.dishPriceTextBox);
            this.Controls.Add(this.dish_priceLabel);
            this.Controls.Add(this.dishNameTextBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.dish_nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dishes_AddEdit_Form";
            this.Text = "dishes_AddEdit_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DishesAddEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPortionsTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookingTimeTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPriceTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dish_nameLabel;
        private System.Windows.Forms.TextBox dishNameTextBox;
        private System.Windows.Forms.Button saveButon;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox menuSectionComboBox;
        private System.Windows.Forms.Label menu_sectionLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label dish_portionsLabel;
        private System.Windows.Forms.NumericUpDown dishPortionsTextBox;
        private System.Windows.Forms.Label cooking_timeLabel;
        private System.Windows.Forms.NumericUpDown cookingTimeTextBox;
        private System.Windows.Forms.Label cooking_timeLabel1;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.NumericUpDown weightTextBox;
        private System.Windows.Forms.Label dish_priceLabel;
        private System.Windows.Forms.NumericUpDown dishPriceTextBox;
        private System.Windows.Forms.Label dish_priceLabel1;
        private System.Windows.Forms.Label massLabel1;
        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.RichTextBox recipeTextBox;
        private System.Windows.Forms.Button add_rowButton;
        private System.Windows.Forms.Button delete_rowButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn units_of_measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn isEdited;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label warningLabel;
    }
}