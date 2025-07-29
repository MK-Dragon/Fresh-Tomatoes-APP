namespace Fresh_Tomatoes_APP
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_add_product = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_product_name = new System.Windows.Forms.TextBox();
            this.num_rating = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.pb_product = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_new_category = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_product.Location = new System.Drawing.Point(340, 346);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(155, 44);
            this.btn_add_product.TabIndex = 12;
            this.btn_add_product.Text = "Add Product";
            this.btn_add_product.UseVisualStyleBackColor = false;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-112, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1033, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Name:";
            // 
            // tb_product_name
            // 
            this.tb_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_product_name.Location = new System.Drawing.Point(196, 134);
            this.tb_product_name.Name = "tb_product_name";
            this.tb_product_name.Size = new System.Drawing.Size(180, 32);
            this.tb_product_name.TabIndex = 17;
            // 
            // num_rating
            // 
            this.num_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_rating.Location = new System.Drawing.Point(491, 257);
            this.num_rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_rating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_rating.Name = "num_rating";
            this.num_rating.Size = new System.Drawing.Size(72, 32);
            this.num_rating.TabIndex = 18;
            this.num_rating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rating:";
            // 
            // rtb_description
            // 
            this.rtb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_description.Location = new System.Drawing.Point(196, 225);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.Size = new System.Drawing.Size(180, 89);
            this.rtb_description.TabIndex = 20;
            this.rtb_description.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Category:";
            // 
            // cbb_category
            // 
            this.cbb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(196, 176);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(180, 33);
            this.cbb_category.TabIndex = 23;
            // 
            // pb_product
            // 
            this.pb_product.Location = new System.Drawing.Point(572, 94);
            this.pb_product.Name = "pb_product";
            this.pb_product.Size = new System.Drawing.Size(176, 160);
            this.pb_product.TabIndex = 24;
            this.pb_product.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_back.Location = new System.Drawing.Point(2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 40);
            this.btn_back.TabIndex = 25;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_new_category
            // 
            this.btn_new_category.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_new_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_category.ForeColor = System.Drawing.Color.Transparent;
            this.btn_new_category.Location = new System.Drawing.Point(382, 176);
            this.btn_new_category.Name = "btn_new_category";
            this.btn_new_category.Size = new System.Drawing.Size(126, 33);
            this.btn_new_category.TabIndex = 26;
            this.btn_new_category.Text = "New Category";
            this.btn_new_category.UseVisualStyleBackColor = false;
            this.btn_new_category.Click += new System.EventHandler(this.btn_new_category_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(136, -181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(545, 405);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_new_category);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pb_product);
            this.Controls.Add(this.cbb_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_rating);
            this.Controls.Add(this.tb_product_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_product_name;
        private System.Windows.Forms.NumericUpDown num_rating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.PictureBox pb_product;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_new_category;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}