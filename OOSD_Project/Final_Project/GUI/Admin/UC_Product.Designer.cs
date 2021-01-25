namespace Final_Project.GUI.Admin
{
    partial class UC_Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgv_product = new System.Windows.Forms.DataGridView();
            this.Panbr = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_cate = new System.Windows.Forms.ComboBox();
            this.num_Price = new System.Windows.Forms.NumericUpDown();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_originproduct = new System.Windows.Forms.TextBox();
            this.txb_warrantyproduct = new System.Windows.Forms.TextBox();
            this.txb_discountproduct = new System.Windows.Forms.TextBox();
            this.btn_Addproduct = new System.Windows.Forms.Button();
            this.txb_nameproduct = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btn_Removeproduct = new System.Windows.Forms.Button();
            this.btn_Editproduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_product)).BeginInit();
            this.Panbr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_product
            // 
            this.dtgv_product.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_product.Location = new System.Drawing.Point(3, 1);
            this.dtgv_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_product.Name = "dtgv_product";
            this.dtgv_product.RowHeadersWidth = 62;
            this.dtgv_product.RowTemplate.Height = 28;
            this.dtgv_product.Size = new System.Drawing.Size(712, 438);
            this.dtgv_product.TabIndex = 13;
            this.dtgv_product.Click += new System.EventHandler(this.dtgvproduct_Click);
            // 
            // Panbr
            // 
            this.Panbr.AutoSize = true;
            this.Panbr.Controls.Add(this.label6);
            this.Panbr.Controls.Add(this.cb_cate);
            this.Panbr.Controls.Add(this.num_Price);
            this.Panbr.Controls.Add(this.btn_Clear);
            this.Panbr.Controls.Add(this.label4);
            this.Panbr.Controls.Add(this.label3);
            this.Panbr.Controls.Add(this.label1);
            this.Panbr.Controls.Add(this.txb_originproduct);
            this.Panbr.Controls.Add(this.txb_warrantyproduct);
            this.Panbr.Controls.Add(this.txb_discountproduct);
            this.Panbr.Controls.Add(this.btn_Addproduct);
            this.Panbr.Controls.Add(this.txb_nameproduct);
            this.Panbr.Controls.Add(this.Tên);
            this.Panbr.Controls.Add(this.btn_Removeproduct);
            this.Panbr.Controls.Add(this.btn_Editproduct);
            this.Panbr.Controls.Add(this.label2);
            this.Panbr.Location = new System.Drawing.Point(719, 2);
            this.Panbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panbr.Name = "Panbr";
            this.Panbr.Size = new System.Drawing.Size(446, 437);
            this.Panbr.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tên danh mục";
            // 
            // cb_cate
            // 
            this.cb_cate.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_cate.FormattingEnabled = true;
            this.cb_cate.Location = new System.Drawing.Point(13, 41);
            this.cb_cate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_cate.Name = "cb_cate";
            this.cb_cate.Size = new System.Drawing.Size(198, 32);
            this.cb_cate.TabIndex = 54;
            this.cb_cate.SelectedIndexChanged += new System.EventHandler(this.cb_cate_SelectedIndexChanged);
            // 
            // num_Price
            // 
            this.num_Price.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Price.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.num_Price.Location = new System.Drawing.Point(65, 321);
            this.num_Price.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.num_Price.Name = "num_Price";
            this.num_Price.Size = new System.Drawing.Size(152, 32);
            this.num_Price.TabIndex = 52;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = global::Final_Project.Properties.Resources.refresh1;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Clear.Location = new System.Drawing.Point(400, 248);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(34, 32);
            this.btn_Clear.TabIndex = 51;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(153, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(153, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Warranty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(241, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Khuyến mãi";
            // 
            // txb_originproduct
            // 
            this.txb_originproduct.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_originproduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_originproduct.Location = new System.Drawing.Point(157, 248);
            this.txb_originproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_originproduct.Name = "txb_originproduct";
            this.txb_originproduct.Size = new System.Drawing.Size(198, 32);
            this.txb_originproduct.TabIndex = 47;
            // 
            // txb_warrantyproduct
            // 
            this.txb_warrantyproduct.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_warrantyproduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_warrantyproduct.Location = new System.Drawing.Point(154, 188);
            this.txb_warrantyproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_warrantyproduct.Name = "txb_warrantyproduct";
            this.txb_warrantyproduct.Size = new System.Drawing.Size(195, 32);
            this.txb_warrantyproduct.TabIndex = 46;
            // 
            // txb_discountproduct
            // 
            this.txb_discountproduct.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_discountproduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_discountproduct.Location = new System.Drawing.Point(245, 321);
            this.txb_discountproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_discountproduct.Name = "txb_discountproduct";
            this.txb_discountproduct.Size = new System.Drawing.Size(178, 32);
            this.txb_discountproduct.TabIndex = 45;
            // 
            // btn_Addproduct
            // 
            this.btn_Addproduct.BackColor = System.Drawing.Color.Teal;
            this.btn_Addproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Addproduct.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addproduct.ForeColor = System.Drawing.Color.White;
            this.btn_Addproduct.Location = new System.Drawing.Point(306, 383);
            this.btn_Addproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Addproduct.Name = "btn_Addproduct";
            this.btn_Addproduct.Size = new System.Drawing.Size(137, 41);
            this.btn_Addproduct.TabIndex = 42;
            this.btn_Addproduct.Text = "Thêm";
            this.btn_Addproduct.UseVisualStyleBackColor = false;
            this.btn_Addproduct.Click += new System.EventHandler(this.btn_Addproduct_Click);
            // 
            // txb_nameproduct
            // 
            this.txb_nameproduct.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nameproduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_nameproduct.Location = new System.Drawing.Point(157, 120);
            this.txb_nameproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_nameproduct.Name = "txb_nameproduct";
            this.txb_nameproduct.Size = new System.Drawing.Size(195, 32);
            this.txb_nameproduct.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tên.ForeColor = System.Drawing.Color.Teal;
            this.Tên.Location = new System.Drawing.Point(61, 294);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(34, 24);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Gía";
            // 
            // btn_Removeproduct
            // 
            this.btn_Removeproduct.BackColor = System.Drawing.Color.Tomato;
            this.btn_Removeproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Removeproduct.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Removeproduct.ForeColor = System.Drawing.Color.White;
            this.btn_Removeproduct.Location = new System.Drawing.Point(13, 383);
            this.btn_Removeproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Removeproduct.Name = "btn_Removeproduct";
            this.btn_Removeproduct.Size = new System.Drawing.Size(135, 41);
            this.btn_Removeproduct.TabIndex = 3;
            this.btn_Removeproduct.Text = "Xoá ";
            this.btn_Removeproduct.UseVisualStyleBackColor = false;
            this.btn_Removeproduct.Click += new System.EventHandler(this.btn_Removeproduct_Click);
            // 
            // btn_Editproduct
            // 
            this.btn_Editproduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Editproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Editproduct.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editproduct.ForeColor = System.Drawing.Color.White;
            this.btn_Editproduct.Location = new System.Drawing.Point(154, 383);
            this.btn_Editproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editproduct.Name = "btn_Editproduct";
            this.btn_Editproduct.Size = new System.Drawing.Size(146, 41);
            this.btn_Editproduct.TabIndex = 2;
            this.btn_Editproduct.Text = "Sửa";
            this.btn_Editproduct.UseVisualStyleBackColor = false;
            this.btn_Editproduct.Click += new System.EventHandler(this.btn_Editproduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(153, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên sản phẩm";
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panbr);
            this.Controls.Add(this.dtgv_product);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(1186, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_product)).EndInit();
            this.Panbr.ResumeLayout(false);
            this.Panbr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_product;
        private System.Windows.Forms.Panel Panbr;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_originproduct;
        private System.Windows.Forms.TextBox txb_warrantyproduct;
        private System.Windows.Forms.TextBox txb_discountproduct;
        private System.Windows.Forms.Button btn_Addproduct;
        private System.Windows.Forms.TextBox txb_nameproduct;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_Removeproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_cate;
        private System.Windows.Forms.Button btn_Editproduct;
    }
}
