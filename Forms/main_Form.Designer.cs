
namespace chef
{
    partial class main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Form));
            this.button2 = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.queriesButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.specialsButton = new System.Windows.Forms.Button();
            this.dishesButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.types_of_productsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(711, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "Вхід/Реєстрація";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Calibri", 15.73109F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(115, 33);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(104, 32);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "chasodij";
            this.login_label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.73109F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вітаємо,";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 100);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::chef.Properties.Resources.settings;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(649, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 56);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::chef.Properties.Resources.exit;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(920, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 56);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(37)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 10);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::chef.Properties.Resources.query;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(539, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 194);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // queriesButton
            // 
            this.queriesButton.BackgroundImage = global::chef.Properties.Resources.stat;
            this.queriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.queriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queriesButton.FlatAppearance.BorderSize = 0;
            this.queriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queriesButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queriesButton.Location = new System.Drawing.Point(307, 363);
            this.queriesButton.Name = "queriesButton";
            this.queriesButton.Size = new System.Drawing.Size(194, 194);
            this.queriesButton.TabIndex = 0;
            this.queriesButton.UseVisualStyleBackColor = true;
            this.queriesButton.Visible = false;
            this.queriesButton.Click += new System.EventHandler(this.queriesButton_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::chef.Properties.Resources.create_order;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(75, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 194);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackgroundImage = global::chef.Properties.Resources.orders;
            this.ordersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ordersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersButton.FlatAppearance.BorderSize = 0;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersButton.Location = new System.Drawing.Point(765, 130);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(194, 194);
            this.ordersButton.TabIndex = 0;
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Visible = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // specialsButton
            // 
            this.specialsButton.BackgroundImage = global::chef.Properties.Resources.specials;
            this.specialsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.specialsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specialsButton.FlatAppearance.BorderSize = 0;
            this.specialsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialsButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialsButton.Location = new System.Drawing.Point(75, 363);
            this.specialsButton.Name = "specialsButton";
            this.specialsButton.Size = new System.Drawing.Size(194, 194);
            this.specialsButton.TabIndex = 0;
            this.specialsButton.UseVisualStyleBackColor = true;
            this.specialsButton.Visible = false;
            this.specialsButton.Click += new System.EventHandler(this.specialsButton_Click);
            // 
            // dishesButton
            // 
            this.dishesButton.BackgroundImage = global::chef.Properties.Resources.see_dishes1;
            this.dishesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dishesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dishesButton.FlatAppearance.BorderSize = 0;
            this.dishesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dishesButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishesButton.Location = new System.Drawing.Point(539, 130);
            this.dishesButton.Name = "dishesButton";
            this.dishesButton.Size = new System.Drawing.Size(194, 194);
            this.dishesButton.TabIndex = 0;
            this.dishesButton.UseVisualStyleBackColor = true;
            this.dishesButton.Visible = false;
            this.dishesButton.Click += new System.EventHandler(this.dishesButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackgroundImage = global::chef.Properties.Resources.products1;
            this.productsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsButton.Location = new System.Drawing.Point(307, 130);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(194, 194);
            this.productsButton.TabIndex = 0;
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Visible = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // types_of_productsButton
            // 
            this.types_of_productsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.types_of_productsButton.BackgroundImage = global::chef.Properties.Resources.types1;
            this.types_of_productsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.types_of_productsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.types_of_productsButton.FlatAppearance.BorderSize = 0;
            this.types_of_productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.types_of_productsButton.Font = new System.Drawing.Font("Calibri", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.types_of_productsButton.Location = new System.Drawing.Point(75, 130);
            this.types_of_productsButton.Name = "types_of_productsButton";
            this.types_of_productsButton.Size = new System.Drawing.Size(194, 194);
            this.types_of_productsButton.TabIndex = 0;
            this.types_of_productsButton.UseVisualStyleBackColor = false;
            this.types_of_productsButton.Visible = false;
            this.types_of_productsButton.Click += new System.EventHandler(this.types_of_productsButton_Click);
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(988, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.queriesButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.specialsButton);
            this.Controls.Add(this.dishesButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.types_of_productsButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_Form";
            this.Text = "Chef";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button types_of_productsButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button dishesButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button queriesButton;
        private System.Windows.Forms.Button specialsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}