namespace Final_Project.GUI.Admin
{
    partial class Stock_manager
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
            this.dtgv_warehouse = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_acc = new System.Windows.Forms.Label();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.txb_newprice = new System.Windows.Forms.TextBox();
            this.btn_addto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_oldprice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_presentcount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmaddcount = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.rb_product = new System.Windows.Forms.RadioButton();
            this.rb_company = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_warehouse)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmaddcount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_warehouse
            // 
            this.dtgv_warehouse.AllowUserToAddRows = false;
            this.dtgv_warehouse.AllowUserToDeleteRows = false;
            this.dtgv_warehouse.AllowUserToOrderColumns = true;
            this.dtgv_warehouse.AllowUserToResizeColumns = false;
            this.dtgv_warehouse.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_warehouse.Location = new System.Drawing.Point(755, 30);
            this.dtgv_warehouse.Name = "dtgv_warehouse";
            this.dtgv_warehouse.RowHeadersWidth = 62;
            this.dtgv_warehouse.RowTemplate.Height = 28;
            this.dtgv_warehouse.Size = new System.Drawing.Size(769, 439);
            this.dtgv_warehouse.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(1244, 475);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(280, 47);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Thoát";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Thủ kho :";
            // 
            // lb_acc
            // 
            this.lb_acc.AutoSize = true;
            this.lb_acc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_acc.ForeColor = System.Drawing.Color.Teal;
            this.lb_acc.Location = new System.Drawing.Point(116, 13);
            this.lb_acc.Name = "lb_acc";
            this.lb_acc.Size = new System.Drawing.Size(194, 29);
            this.lb_acc.TabIndex = 15;
            this.lb_acc.Text = "Phan Đăng Trung";
            // 
            // cb_product
            // 
            this.cb_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_product.Location = new System.Drawing.Point(427, 42);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(265, 37);
            this.cb_product.TabIndex = 17;
            this.cb_product.SelectedIndexChanged += new System.EventHandler(this.cb_product_SelectedIndexChanged);
            // 
            // cb_company
            // 
            this.cb_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_company.Location = new System.Drawing.Point(16, 43);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(256, 37);
            this.cb_company.TabIndex = 18;
            this.cb_company.SelectedIndexChanged += new System.EventHandler(this.cb_company_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(422, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên sản phẩm :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lb_address);
            this.panel1.Controls.Add(this.txb_newprice);
            this.panel1.Controls.Add(this.btn_addto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lb_oldprice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_presentcount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nmaddcount);
            this.panel1.Controls.Add(this.lb_acc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 493);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_product);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cb_company);
            this.panel3.Location = new System.Drawing.Point(3, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 91);
            this.panel3.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên nhà cung cấp :";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.ForeColor = System.Drawing.Color.Teal;
            this.lb_address.Location = new System.Drawing.Point(268, 392);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(26, 29);
            this.lb_address.TabIndex = 40;
            this.lb_address.Text = "0";
            // 
            // txb_newprice
            // 
            this.txb_newprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_newprice.Location = new System.Drawing.Point(430, 331);
            this.txb_newprice.Name = "txb_newprice";
            this.txb_newprice.Size = new System.Drawing.Size(247, 35);
            this.txb_newprice.TabIndex = 39;
            // 
            // btn_addto
            // 
            this.btn_addto.BackColor = System.Drawing.Color.Teal;
            this.btn_addto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addto.ForeColor = System.Drawing.Color.White;
            this.btn_addto.Location = new System.Drawing.Point(0, 445);
            this.btn_addto.Name = "btn_addto";
            this.btn_addto.Size = new System.Drawing.Size(737, 45);
            this.btn_addto.TabIndex = 33;
            this.btn_addto.Text = "Thêm";
            this.btn_addto.UseVisualStyleBackColor = false;
            this.btn_addto.Click += new System.EventHandler(this.btn_addto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(20, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Địa chỉ nhà cung cấp :";
            // 
            // lb_oldprice
            // 
            this.lb_oldprice.AutoSize = true;
            this.lb_oldprice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_oldprice.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_oldprice.ForeColor = System.Drawing.Color.Teal;
            this.lb_oldprice.Location = new System.Drawing.Point(606, 252);
            this.lb_oldprice.Name = "lb_oldprice";
            this.lb_oldprice.Size = new System.Drawing.Size(26, 29);
            this.lb_oldprice.TabIndex = 38;
            this.lb_oldprice.Text = "0";
            this.lb_oldprice.Click += new System.EventHandler(this.lb_oldprice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(425, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Giá nhập cũ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(425, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Giá nhập mới :";
            // 
            // lb_presentcount
            // 
            this.lb_presentcount.AutoSize = true;
            this.lb_presentcount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_presentcount.ForeColor = System.Drawing.Color.Teal;
            this.lb_presentcount.Location = new System.Drawing.Point(228, 252);
            this.lb_presentcount.Name = "lb_presentcount";
            this.lb_presentcount.Size = new System.Drawing.Size(50, 29);
            this.lb_presentcount.TabIndex = 28;
            this.lb_presentcount.Text = "Tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(20, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 29);
            this.label9.TabIndex = 27;
            this.label9.Text = "Số lượng hiện có :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(28, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số lượng thêm :";
            // 
            // nmaddcount
            // 
            this.nmaddcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmaddcount.Location = new System.Drawing.Point(217, 310);
            this.nmaddcount.Name = "nmaddcount";
            this.nmaddcount.Size = new System.Drawing.Size(61, 32);
            this.nmaddcount.TabIndex = 25;
            this.nmaddcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pb_search);
            this.panel2.Controls.Add(this.txb_search);
            this.panel2.Controls.Add(this.rb_product);
            this.panel2.Controls.Add(this.rb_company);
            this.panel2.ForeColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 93);
            this.panel2.TabIndex = 24;
            // 
            // pb_search
            // 
            this.pb_search.BackgroundImage = global::Final_Project.Properties.Resources._945px_Vector_search_icon_svg;
            this.pb_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_search.Location = new System.Drawing.Point(585, 50);
            this.pb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(41, 35);
            this.pb_search.TabIndex = 24;
            this.pb_search.TabStop = false;
            this.pb_search.Click += new System.EventHandler(this.pb_search_Click);
            // 
            // txb_search
            // 
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(66, 50);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(504, 35);
            this.txb_search.TabIndex = 21;
            // 
            // rb_product
            // 
            this.rb_product.AutoSize = true;
            this.rb_product.Checked = true;
            this.rb_product.ForeColor = System.Drawing.Color.Teal;
            this.rb_product.Location = new System.Drawing.Point(399, 20);
            this.rb_product.Name = "rb_product";
            this.rb_product.Size = new System.Drawing.Size(171, 24);
            this.rb_product.TabIndex = 22;
            this.rb_product.TabStop = true;
            this.rb_product.Text = "Theo tên sản phẩm";
            this.rb_product.UseVisualStyleBackColor = true;
            // 
            // rb_company
            // 
            this.rb_company.AutoSize = true;
            this.rb_company.ForeColor = System.Drawing.Color.Teal;
            this.rb_company.Location = new System.Drawing.Point(65, 20);
            this.rb_company.Name = "rb_company";
            this.rb_company.Size = new System.Drawing.Size(170, 24);
            this.rb_company.TabIndex = 23;
            this.rb_company.TabStop = true;
            this.rb_company.Text = "Theo nhà cung cấp";
            this.rb_company.UseVisualStyleBackColor = true;
            // 
            // Stock_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1536, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dtgv_warehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Stock_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_manager";
            this.Load += new System.EventHandler(this.Stock_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_warehouse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmaddcount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_warehouse;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_acc;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.ComboBox cb_company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.RadioButton rb_product;
        private System.Windows.Forms.RadioButton rb_company;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_presentcount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmaddcount;
        private System.Windows.Forms.PictureBox pb_search;
        private System.Windows.Forms.Button btn_addto;
        private System.Windows.Forms.Label lb_oldprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_newprice;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
    }
}