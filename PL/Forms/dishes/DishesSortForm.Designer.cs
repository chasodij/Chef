
namespace chef
{
    partial class DishesSortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishesSortForm));
            this.massCheckBox = new System.Windows.Forms.CheckBox();
            this.cooking_timeCheckBox = new System.Windows.Forms.CheckBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.portionsCheckBox = new System.Windows.Forms.CheckBox();
            this.type_nameCheckBox = new System.Windows.Forms.CheckBox();
            this.mass2 = new System.Windows.Forms.PictureBox();
            this.mass1 = new System.Windows.Forms.PictureBox();
            this.cooking_time2 = new System.Windows.Forms.PictureBox();
            this.cooking_time1 = new System.Windows.Forms.PictureBox();
            this.price2 = new System.Windows.Forms.PictureBox();
            this.price1 = new System.Windows.Forms.PictureBox();
            this.portions2 = new System.Windows.Forms.PictureBox();
            this.portions1 = new System.Windows.Forms.PictureBox();
            this.name2 = new System.Windows.Forms.PictureBox();
            this.name1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooking_time2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooking_time1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portions2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portions1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name1)).BeginInit();
            this.SuspendLayout();
            // 
            // massCheckBox
            // 
            this.massCheckBox.AutoSize = true;
            this.massCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massCheckBox.Location = new System.Drawing.Point(36, 228);
            this.massCheckBox.Name = "massCheckBox";
            this.massCheckBox.Size = new System.Drawing.Size(117, 62);
            this.massCheckBox.TabIndex = 3;
            this.massCheckBox.Text = "Маса на\r\nвиході";
            this.massCheckBox.UseVisualStyleBackColor = true;
            this.massCheckBox.CheckedChanged += new System.EventHandler(this.SortRowCheckBox_CheckedChanged);
            // 
            // cooking_timeCheckBox
            // 
            this.cooking_timeCheckBox.AutoSize = true;
            this.cooking_timeCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cooking_timeCheckBox.Location = new System.Drawing.Point(36, 189);
            this.cooking_timeCheckBox.Name = "cooking_timeCheckBox";
            this.cooking_timeCheckBox.Size = new System.Drawing.Size(213, 33);
            this.cooking_timeCheckBox.TabIndex = 4;
            this.cooking_timeCheckBox.Text = "Час приготування";
            this.cooking_timeCheckBox.UseVisualStyleBackColor = true;
            this.cooking_timeCheckBox.CheckedChanged += new System.EventHandler(this.SortRowCheckBox_CheckedChanged);
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCheckBox.Location = new System.Drawing.Point(36, 136);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(78, 33);
            this.priceCheckBox.TabIndex = 5;
            this.priceCheckBox.Text = "Ціна";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            this.priceCheckBox.CheckedChanged += new System.EventHandler(this.SortRowCheckBox_CheckedChanged);
            // 
            // portionsCheckBox
            // 
            this.portionsCheckBox.AutoSize = true;
            this.portionsCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portionsCheckBox.Location = new System.Drawing.Point(36, 83);
            this.portionsCheckBox.Name = "portionsCheckBox";
            this.portionsCheckBox.Size = new System.Drawing.Size(197, 33);
            this.portionsCheckBox.TabIndex = 6;
            this.portionsCheckBox.Text = "Кількість порцій";
            this.portionsCheckBox.UseVisualStyleBackColor = true;
            this.portionsCheckBox.CheckedChanged += new System.EventHandler(this.SortRowCheckBox_CheckedChanged);
            // 
            // type_nameCheckBox
            // 
            this.type_nameCheckBox.AutoSize = true;
            this.type_nameCheckBox.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_nameCheckBox.Location = new System.Drawing.Point(36, 29);
            this.type_nameCheckBox.Name = "type_nameCheckBox";
            this.type_nameCheckBox.Size = new System.Drawing.Size(93, 33);
            this.type_nameCheckBox.TabIndex = 6;
            this.type_nameCheckBox.Text = "Назва";
            this.type_nameCheckBox.UseVisualStyleBackColor = true;
            this.type_nameCheckBox.CheckedChanged += new System.EventHandler(this.SortRowCheckBox_CheckedChanged);
            // 
            // mass2
            // 
            this.mass2.Cursor = System.Windows.Forms.Cursors.Default;
            this.mass2.Image = ((System.Drawing.Image)(resources.GetObject("mass2.Image")));
            this.mass2.Location = new System.Drawing.Point(321, 235);
            this.mass2.Name = "mass2";
            this.mass2.Size = new System.Drawing.Size(47, 47);
            this.mass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mass2.TabIndex = 7;
            this.mass2.TabStop = false;
            this.mass2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // mass1
            // 
            this.mass1.Cursor = System.Windows.Forms.Cursors.Default;
            this.mass1.Image = ((System.Drawing.Image)(resources.GetObject("mass1.Image")));
            this.mass1.Location = new System.Drawing.Point(253, 235);
            this.mass1.Name = "mass1";
            this.mass1.Size = new System.Drawing.Size(47, 47);
            this.mass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mass1.TabIndex = 7;
            this.mass1.TabStop = false;
            this.mass1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // cooking_time2
            // 
            this.cooking_time2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cooking_time2.Image = ((System.Drawing.Image)(resources.GetObject("cooking_time2.Image")));
            this.cooking_time2.Location = new System.Drawing.Point(321, 182);
            this.cooking_time2.Name = "cooking_time2";
            this.cooking_time2.Size = new System.Drawing.Size(47, 47);
            this.cooking_time2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cooking_time2.TabIndex = 7;
            this.cooking_time2.TabStop = false;
            this.cooking_time2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // cooking_time1
            // 
            this.cooking_time1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cooking_time1.Image = ((System.Drawing.Image)(resources.GetObject("cooking_time1.Image")));
            this.cooking_time1.Location = new System.Drawing.Point(253, 182);
            this.cooking_time1.Name = "cooking_time1";
            this.cooking_time1.Size = new System.Drawing.Size(47, 47);
            this.cooking_time1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cooking_time1.TabIndex = 7;
            this.cooking_time1.TabStop = false;
            this.cooking_time1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // price2
            // 
            this.price2.Cursor = System.Windows.Forms.Cursors.Default;
            this.price2.Image = ((System.Drawing.Image)(resources.GetObject("price2.Image")));
            this.price2.Location = new System.Drawing.Point(321, 129);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(47, 47);
            this.price2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.price2.TabIndex = 7;
            this.price2.TabStop = false;
            this.price2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // price1
            // 
            this.price1.Cursor = System.Windows.Forms.Cursors.Default;
            this.price1.Image = ((System.Drawing.Image)(resources.GetObject("price1.Image")));
            this.price1.Location = new System.Drawing.Point(253, 129);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(47, 47);
            this.price1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.price1.TabIndex = 7;
            this.price1.TabStop = false;
            this.price1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // portions2
            // 
            this.portions2.Cursor = System.Windows.Forms.Cursors.Default;
            this.portions2.Image = ((System.Drawing.Image)(resources.GetObject("portions2.Image")));
            this.portions2.Location = new System.Drawing.Point(321, 76);
            this.portions2.Name = "portions2";
            this.portions2.Size = new System.Drawing.Size(47, 47);
            this.portions2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portions2.TabIndex = 7;
            this.portions2.TabStop = false;
            this.portions2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // portions1
            // 
            this.portions1.Cursor = System.Windows.Forms.Cursors.Default;
            this.portions1.Image = ((System.Drawing.Image)(resources.GetObject("portions1.Image")));
            this.portions1.Location = new System.Drawing.Point(253, 76);
            this.portions1.Name = "portions1";
            this.portions1.Size = new System.Drawing.Size(47, 47);
            this.portions1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portions1.TabIndex = 7;
            this.portions1.TabStop = false;
            this.portions1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // name2
            // 
            this.name2.Cursor = System.Windows.Forms.Cursors.Default;
            this.name2.Image = ((System.Drawing.Image)(resources.GetObject("name2.Image")));
            this.name2.Location = new System.Drawing.Point(321, 22);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(47, 47);
            this.name2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.name2.TabIndex = 7;
            this.name2.TabStop = false;
            this.name2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // name1
            // 
            this.name1.Cursor = System.Windows.Forms.Cursors.Default;
            this.name1.Image = ((System.Drawing.Image)(resources.GetObject("name1.Image")));
            this.name1.Location = new System.Drawing.Point(253, 22);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(47, 47);
            this.name1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.name1.TabIndex = 7;
            this.name1.TabStop = false;
            this.name1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(65, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HideForm);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(172, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 71);
            this.button2.TabIndex = 8;
            this.button2.Text = "Скасувати\r\nсортування";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearSortingButton_Click);
            // 
            // dishes_Sort_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(218)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(413, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mass2);
            this.Controls.Add(this.mass1);
            this.Controls.Add(this.cooking_time2);
            this.Controls.Add(this.cooking_time1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.portions2);
            this.Controls.Add(this.portions1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.massCheckBox);
            this.Controls.Add(this.cooking_timeCheckBox);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.type_nameCheckBox);
            this.Controls.Add(this.portionsCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dishes_Sort_Form";
            this.Text = "Сортування";
            this.Deactivate += new System.EventHandler(this.HideForm);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            ((System.ComponentModel.ISupportInitialize)(this.mass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooking_time2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooking_time1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portions2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portions1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox massCheckBox;
        private System.Windows.Forms.CheckBox cooking_timeCheckBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.CheckBox portionsCheckBox;
        private System.Windows.Forms.CheckBox type_nameCheckBox;
        private System.Windows.Forms.PictureBox name1;
        private System.Windows.Forms.PictureBox name2;
        private System.Windows.Forms.PictureBox portions1;
        private System.Windows.Forms.PictureBox portions2;
        private System.Windows.Forms.PictureBox price1;
        private System.Windows.Forms.PictureBox price2;
        private System.Windows.Forms.PictureBox cooking_time1;
        private System.Windows.Forms.PictureBox cooking_time2;
        private System.Windows.Forms.PictureBox mass1;
        private System.Windows.Forms.PictureBox mass2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}