namespace Final_Project.GUI.User
{
    partial class Warranty_Form
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
            this.btn_AddWarranty = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_disable = new System.Windows.Forms.Button();
            this.dtgv_warranty = new System.Windows.Forms.DataGridView();
            this.txb_find_pro = new System.Windows.Forms.TextBox();
            this.pb_fine_product = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_emp = new System.Windows.Forms.Label();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.pb_seachphonecus = new System.Windows.Forms.PictureBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_createcustomer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.lb_time_warranty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpk_out = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.txb_descr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_warranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fine_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_seachphonecus)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddWarranty
            // 
            this.btn_AddWarranty.BackColor = System.Drawing.Color.Teal;
            this.btn_AddWarranty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddWarranty.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddWarranty.ForeColor = System.Drawing.Color.White;
            this.btn_AddWarranty.Location = new System.Drawing.Point(37, 493);
            this.btn_AddWarranty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddWarranty.Name = "btn_AddWarranty";
            this.btn_AddWarranty.Size = new System.Drawing.Size(137, 41);
            this.btn_AddWarranty.TabIndex = 42;
            this.btn_AddWarranty.Text = "Thêm";
            this.btn_AddWarranty.UseVisualStyleBackColor = false;
            this.btn_AddWarranty.Click += new System.EventHandler(this.btn_AddWarranty_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Tomato;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(1116, 493);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(135, 41);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Xoá ";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_disable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_disable.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disable.ForeColor = System.Drawing.Color.White;
            this.btn_disable.Location = new System.Drawing.Point(430, 493);
            this.btn_disable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(274, 41);
            this.btn_disable.TabIndex = 2;
            this.btn_disable.Text = "Xác nhận đã bảo hành";
            this.btn_disable.UseVisualStyleBackColor = false;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // dtgv_warranty
            // 
            this.dtgv_warranty.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_warranty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_warranty.Location = new System.Drawing.Point(37, 299);
            this.dtgv_warranty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_warranty.Name = "dtgv_warranty";
            this.dtgv_warranty.RowHeadersWidth = 62;
            this.dtgv_warranty.RowTemplate.Height = 28;
            this.dtgv_warranty.Size = new System.Drawing.Size(1214, 177);
            this.dtgv_warranty.TabIndex = 15;
            // 
            // txb_find_pro
            // 
            this.txb_find_pro.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_find_pro.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_find_pro.Location = new System.Drawing.Point(22, 50);
            this.txb_find_pro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_find_pro.Name = "txb_find_pro";
            this.txb_find_pro.Size = new System.Drawing.Size(195, 32);
            this.txb_find_pro.TabIndex = 54;
            // 
            // pb_fine_product
            // 
            this.pb_fine_product.BackgroundImage = global::Final_Project.Properties.Resources._945px_Vector_search_icon_svg;
            this.pb_fine_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_fine_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_fine_product.Location = new System.Drawing.Point(253, 50);
            this.pb_fine_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_fine_product.Name = "pb_fine_product";
            this.pb_fine_product.Size = new System.Drawing.Size(35, 34);
            this.pb_fine_product.TabIndex = 58;
            this.pb_fine_product.TabStop = false;
            this.pb_fine_product.Click += new System.EventHandler(this.pb_fine_product_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Tên nhân viên :";
            // 
            // lb_emp
            // 
            this.lb_emp.AutoSize = true;
            this.lb_emp.Location = new System.Drawing.Point(152, 14);
            this.lb_emp.Name = "lb_emp";
            this.lb_emp.Size = new System.Drawing.Size(46, 17);
            this.lb_emp.TabIndex = 63;
            this.lb_emp.Text = "label7";
            // 
            // cb_customer
            // 
            this.cb_customer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Location = new System.Drawing.Point(581, 98);
            this.cb_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(309, 30);
            this.cb_customer.TabIndex = 69;
            // 
            // pb_seachphonecus
            // 
            this.pb_seachphonecus.BackgroundImage = global::Final_Project.Properties.Resources._945px_Vector_search_icon_svg;
            this.pb_seachphonecus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_seachphonecus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_seachphonecus.Location = new System.Drawing.Point(896, 46);
            this.pb_seachphonecus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_seachphonecus.Name = "pb_seachphonecus";
            this.pb_seachphonecus.Size = new System.Drawing.Size(35, 34);
            this.pb_seachphonecus.TabIndex = 68;
            this.pb_seachphonecus.TabStop = false;
            this.pb_seachphonecus.Click += new System.EventHandler(this.pb_seachphonecus_Click);
            // 
            // txb_phone
            // 
            this.txb_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_phone.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_phone.ForeColor = System.Drawing.Color.Gray;
            this.txb_phone.Location = new System.Drawing.Point(581, 46);
            this.txb_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(309, 35);
            this.txb_phone.TabIndex = 64;
            this.txb_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(412, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 29);
            this.label14.TabIndex = 67;
            this.label14.Text = "Số điện thoại:";
            // 
            // lb_createcustomer
            // 
            this.lb_createcustomer.AutoSize = true;
            this.lb_createcustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_createcustomer.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_createcustomer.ForeColor = System.Drawing.Color.DimGray;
            this.lb_createcustomer.Location = new System.Drawing.Point(920, 102);
            this.lb_createcustomer.Name = "lb_createcustomer";
            this.lb_createcustomer.Size = new System.Drawing.Size(117, 21);
            this.lb_createcustomer.TabIndex = 65;
            this.lb_createcustomer.Text = "*Tạo khách hàng";
            this.lb_createcustomer.Click += new System.EventHandler(this.lb_createcustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(425, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "Khách hàng:";
            // 
            // cb_product
            // 
            this.cb_product.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(22, 107);
            this.cb_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(309, 30);
            this.cb_product.TabIndex = 72;
            this.cb_product.SelectedIndexChanged += new System.EventHandler(this.cb_product_SelectedIndexChanged);
            // 
            // lb_time_warranty
            // 
            this.lb_time_warranty.AutoSize = true;
            this.lb_time_warranty.Location = new System.Drawing.Point(319, 179);
            this.lb_time_warranty.Name = "lb_time_warranty";
            this.lb_time_warranty.Size = new System.Drawing.Size(46, 17);
            this.lb_time_warranty.TabIndex = 74;
            this.lb_time_warranty.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Thời gian bảo hành của sản phẩm này là : ";
            // 
            // dtpk_out
            // 
            this.dtpk_out.Location = new System.Drawing.Point(581, 166);
            this.dtpk_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_out.Name = "dtpk_out";
            this.dtpk_out.Size = new System.Drawing.Size(309, 22);
            this.dtpk_out.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Ngày trả dự kiến";
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Location = new System.Drawing.Point(248, 493);
            this.btn_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(146, 41);
            this.btn_show.TabIndex = 79;
            this.btn_show.Text = "Xem ";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txb_descr
            // 
            this.txb_descr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_descr.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descr.ForeColor = System.Drawing.Color.Gray;
            this.txb_descr.Location = new System.Drawing.Point(1124, 50);
            this.txb_descr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_descr.Multiline = true;
            this.txb_descr.Name = "txb_descr";
            this.txb_descr.Size = new System.Drawing.Size(309, 115);
            this.txb_descr.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1120, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Lý do bảo hành";
            // 
            // Warranty_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_descr);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpk_out);
            this.Controls.Add(this.lb_time_warranty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_product);
            this.Controls.Add(this.cb_customer);
            this.Controls.Add(this.pb_seachphonecus);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_createcustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_emp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pb_fine_product);
            this.Controls.Add(this.btn_AddWarranty);
            this.Controls.Add(this.txb_find_pro);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dtgv_warranty);
            this.Controls.Add(this.btn_disable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Warranty_Form";
            this.Text = "Xem";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_warranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fine_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_seachphonecus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddWarranty;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_disable;
        private System.Windows.Forms.DataGridView dtgv_warranty;
        private System.Windows.Forms.TextBox txb_find_pro;
        private System.Windows.Forms.PictureBox pb_fine_product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_emp;
        private System.Windows.Forms.ComboBox cb_customer;
        private System.Windows.Forms.PictureBox pb_seachphonecus;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_createcustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.Label lb_time_warranty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpk_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txb_descr;
        private System.Windows.Forms.Label label1;
    }
}