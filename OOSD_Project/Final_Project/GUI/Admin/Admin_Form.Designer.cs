namespace Final_Project.GUI
{
    partial class Admin_Form
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
            this.btn_Em = new System.Windows.Forms.Button();
            this.PanAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Company = new System.Windows.Forms.Button();
            this.btn_staits = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.lb_acc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Em
            // 
            this.btn_Em.BackColor = System.Drawing.Color.Teal;
            this.btn_Em.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Em.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Em.ForeColor = System.Drawing.Color.White;
            this.btn_Em.Location = new System.Drawing.Point(-5, 2);
            this.btn_Em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Em.Name = "btn_Em";
            this.btn_Em.Size = new System.Drawing.Size(257, 51);
            this.btn_Em.TabIndex = 0;
            this.btn_Em.Text = "Nhân Viên";
            this.btn_Em.UseVisualStyleBackColor = false;
            this.btn_Em.Click += new System.EventHandler(this.btn_Em_Click);
            // 
            // PanAdmin
            // 
            this.PanAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanAdmin.Location = new System.Drawing.Point(253, 66);
            this.PanAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanAdmin.Name = "PanAdmin";
            this.PanAdmin.Size = new System.Drawing.Size(1186, 441);
            this.PanAdmin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Em);
            this.panel2.Controls.Add(this.btn_Product);
            this.panel2.Controls.Add(this.btn_Company);
            this.panel2.Controls.Add(this.btn_staits);
            this.panel2.Controls.Add(this.btn_Customer);
            this.panel2.Controls.Add(this.btn_Account);
            this.panel2.Controls.Add(this.btn_Category);
            this.panel2.Location = new System.Drawing.Point(4, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 414);
            this.panel2.TabIndex = 2;
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.Teal;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Location = new System.Drawing.Point(-5, 356);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(257, 52);
            this.btn_Product.TabIndex = 6;
            this.btn_Product.Text = "Sản Phẩm";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Company
            // 
            this.btn_Company.BackColor = System.Drawing.Color.Teal;
            this.btn_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Company.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Company.ForeColor = System.Drawing.Color.White;
            this.btn_Company.Location = new System.Drawing.Point(-5, 303);
            this.btn_Company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Company.Name = "btn_Company";
            this.btn_Company.Size = new System.Drawing.Size(257, 55);
            this.btn_Company.TabIndex = 7;
            this.btn_Company.Text = "Công ty";
            this.btn_Company.UseVisualStyleBackColor = false;
            this.btn_Company.Click += new System.EventHandler(this.btn_Company_Click);
            // 
            // btn_staits
            // 
            this.btn_staits.BackColor = System.Drawing.Color.Teal;
            this.btn_staits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staits.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staits.ForeColor = System.Drawing.Color.White;
            this.btn_staits.Location = new System.Drawing.Point(0, 245);
            this.btn_staits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_staits.Name = "btn_staits";
            this.btn_staits.Size = new System.Drawing.Size(252, 60);
            this.btn_staits.TabIndex = 5;
            this.btn_staits.Text = "Thống kê";
            this.btn_staits.UseVisualStyleBackColor = false;
            this.btn_staits.Click += new System.EventHandler(this.btn_Warehouse_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.Teal;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Location = new System.Drawing.Point(0, 198);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(252, 52);
            this.btn_Customer.TabIndex = 4;
            this.btn_Customer.Text = "Khách hàng";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.Teal;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Location = new System.Drawing.Point(-5, 146);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(257, 62);
            this.btn_Account.TabIndex = 3;
            this.btn_Account.Text = "Tài khoản ";
            this.btn_Account.UseVisualStyleBackColor = false;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.BackColor = System.Drawing.Color.Teal;
            this.btn_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Category.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.ForeColor = System.Drawing.Color.White;
            this.btn_Category.Location = new System.Drawing.Point(-5, 50);
            this.btn_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(257, 51);
            this.btn_Category.TabIndex = 1;
            this.btn_Category.Text = "Danh mục";
            this.btn_Category.UseVisualStyleBackColor = false;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mobile Shop";
            // 
            // pic_close
            // 
            this.pic_close.BackgroundImage = global::Final_Project.Properties.Resources._106830;
            this.pic_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = global::Final_Project.Properties.Resources._106830;
            this.pic_close.Location = new System.Drawing.Point(1414, 12);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(28, 29);
            this.pic_close.TabIndex = 6;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // lb_acc
            // 
            this.lb_acc.AutoSize = true;
            this.lb_acc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_acc.Location = new System.Drawing.Point(1131, 23);
            this.lb_acc.Name = "lb_acc";
            this.lb_acc.Size = new System.Drawing.Size(163, 24);
            this.lb_acc.TabIndex = 7;
            this.lb_acc.Text = "Phan Đăng Trung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(935, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quản trị viên:";
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_acc);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Em;
        private System.Windows.Forms.Panel PanAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_staits;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Label lb_acc;
        private System.Windows.Forms.Label label3;
    }
}