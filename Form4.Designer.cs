namespace Fresh_Tomatoes_APP
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lb_products = new System.Windows.Forms.ListBox();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_orber_by = new System.Windows.Forms.Label();
            this.cbb_order_by = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_min_stars = new System.Windows.Forms.NumericUpDown();
            this.num_stars_max = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_stars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stars_max)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "All Products";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(651, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 40);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "<= Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(627, 30);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(109, 40);
            this.btn_refresh.TabIndex = 21;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lb_products
            // 
            this.lb_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_products.FormattingEnabled = true;
            this.lb_products.ItemHeight = 16;
            this.lb_products.Location = new System.Drawing.Point(173, 82);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(456, 340);
            this.lb_products.TabIndex = 22;
            // 
            // cbb_category
            // 
            this.cbb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(12, 105);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(121, 32);
            this.cbb_category.TabIndex = 23;
            this.cbb_category.SelectedIndexChanged += new System.EventHandler(this.cbb_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filters Category:";
            // 
            // lbl_orber_by
            // 
            this.lbl_orber_by.AutoSize = true;
            this.lbl_orber_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orber_by.Location = new System.Drawing.Point(12, 155);
            this.lbl_orber_by.Name = "lbl_orber_by";
            this.lbl_orber_by.Size = new System.Drawing.Size(75, 20);
            this.lbl_orber_by.TabIndex = 26;
            this.lbl_orber_by.Text = "Order By:";
            // 
            // cbb_order_by
            // 
            this.cbb_order_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_order_by.FormattingEnabled = true;
            this.cbb_order_by.Location = new System.Drawing.Point(12, 178);
            this.cbb_order_by.Name = "cbb_order_by";
            this.cbb_order_by.Size = new System.Drawing.Size(121, 32);
            this.cbb_order_by.TabIndex = 25;
            this.cbb_order_by.SelectedIndexChanged += new System.EventHandler(this.cbb_order_by_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Filter By Stars:";
            // 
            // num_min_stars
            // 
            this.num_min_stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_min_stars.Location = new System.Drawing.Point(16, 254);
            this.num_min_stars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_min_stars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_min_stars.Name = "num_min_stars";
            this.num_min_stars.Size = new System.Drawing.Size(38, 29);
            this.num_min_stars.TabIndex = 29;
            this.num_min_stars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_min_stars.ValueChanged += new System.EventHandler(this.num_min_stars_ValueChanged);
            // 
            // num_stars_max
            // 
            this.num_stars_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_stars_max.Location = new System.Drawing.Point(98, 254);
            this.num_stars_max.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_stars_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_stars_max.Name = "num_stars_max";
            this.num_stars_max.Size = new System.Drawing.Size(38, 29);
            this.num_stars_max.TabIndex = 30;
            this.num_stars_max.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_stars_max.ValueChanged += new System.EventHandler(this.num_stars_max_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = " - ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_stars_max);
            this.Controls.Add(this.num_min_stars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_orber_by);
            this.Controls.Add(this.cbb_order_by);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_category);
            this.Controls.Add(this.lb_products);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min_stars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stars_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ListBox lb_products;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_orber_by;
        private System.Windows.Forms.ComboBox cbb_order_by;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_min_stars;
        private System.Windows.Forms.NumericUpDown num_stars_max;
        private System.Windows.Forms.Label label5;
    }
}