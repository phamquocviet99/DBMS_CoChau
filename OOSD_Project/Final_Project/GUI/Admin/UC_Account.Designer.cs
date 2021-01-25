namespace Final_Project.GUI.Admin
{
    partial class UC_Account
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
            this.btn_RemoveAcc = new System.Windows.Forms.Button();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_ware = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rb_sale = new System.Windows.Forms.RadioButton();
            this.btn_updateAcc = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_idem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.PanEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RemoveAcc
            // 
            this.btn_RemoveAcc.BackColor = System.Drawing.Color.Tomato;
            this.btn_RemoveAcc.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveAcc.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveAcc.Location = new System.Drawing.Point(95, 383);
            this.btn_RemoveAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveAcc.Name = "btn_RemoveAcc";
            this.btn_RemoveAcc.Size = new System.Drawing.Size(130, 41);
            this.btn_RemoveAcc.TabIndex = 3;
            this.btn_RemoveAcc.Text = "Xóa";
            this.btn_RemoveAcc.UseVisualStyleBackColor = false;
            this.btn_RemoveAcc.Click += new System.EventHandler(this.btn_RemoveAcc_Click);
            // 
            // txb_username
            // 
            this.txb_username.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_username.Location = new System.Drawing.Point(97, 139);
            this.txb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(287, 35);
            this.txb_username.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(92, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên đăng nhập";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(1, 1);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 62;
            this.dtgvAccount.RowTemplate.Height = 28;
            this.dtgvAccount.Size = new System.Drawing.Size(712, 438);
            this.dtgvAccount.TabIndex = 8;
            this.dtgvAccount.Click += new System.EventHandler(this.dtgvAccount_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.BackColor = System.Drawing.Color.White;
            this.PanEmployee.Controls.Add(this.label3);
            this.PanEmployee.Controls.Add(this.panel1);
            this.PanEmployee.Controls.Add(this.btn_updateAcc);
            this.PanEmployee.Controls.Add(this.txb_name);
            this.PanEmployee.Controls.Add(this.Tên);
            this.PanEmployee.Controls.Add(this.label1);
            this.PanEmployee.Controls.Add(this.txb_idem);
            this.PanEmployee.Controls.Add(this.btn_RemoveAcc);
            this.PanEmployee.Controls.Add(this.txb_username);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(719, 2);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(464, 437);
            this.PanEmployee.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(92, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Quyền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.rb_ware);
            this.panel1.Controls.Add(this.rbAdmin);
            this.panel1.Controls.Add(this.rb_sale);
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 61);
            this.panel1.TabIndex = 43;
            // 
            // rb_ware
            // 
            this.rb_ware.AutoSize = true;
            this.rb_ware.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ware.ForeColor = System.Drawing.Color.White;
            this.rb_ware.Location = new System.Drawing.Point(334, 17);
            this.rb_ware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ware.Name = "rb_ware";
            this.rb_ware.Size = new System.Drawing.Size(98, 27);
            this.rb_ware.TabIndex = 37;
            this.rb_ware.TabStop = true;
            this.rb_ware.Text = "Thủ kho";
            this.rb_ware.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.ForeColor = System.Drawing.Color.White;
            this.rbAdmin.Location = new System.Drawing.Point(59, 17);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(95, 27);
            this.rbAdmin.TabIndex = 35;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Quản lý";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rb_sale
            // 
            this.rb_sale.AutoSize = true;
            this.rb_sale.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sale.ForeColor = System.Drawing.Color.White;
            this.rb_sale.Location = new System.Drawing.Point(197, 17);
            this.rb_sale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_sale.Name = "rb_sale";
            this.rb_sale.Size = new System.Drawing.Size(111, 27);
            this.rb_sale.TabIndex = 36;
            this.rb_sale.TabStop = true;
            this.rb_sale.Text = "Bán hàng";
            this.rb_sale.UseVisualStyleBackColor = true;
            // 
            // btn_updateAcc
            // 
            this.btn_updateAcc.BackColor = System.Drawing.Color.Teal;
            this.btn_updateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updateAcc.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateAcc.ForeColor = System.Drawing.Color.White;
            this.btn_updateAcc.Location = new System.Drawing.Point(248, 382);
            this.btn_updateAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_updateAcc.Name = "btn_updateAcc";
            this.btn_updateAcc.Size = new System.Drawing.Size(134, 42);
            this.btn_updateAcc.TabIndex = 42;
            this.btn_updateAcc.Text = "Xác nhận";
            this.btn_updateAcc.UseVisualStyleBackColor = false;
            this.btn_updateAcc.Click += new System.EventHandler(this.btn_updateAcc_Click);
            // 
            // txb_name
            // 
            this.txb_name.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_name.Location = new System.Drawing.Point(95, 224);
            this.txb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(287, 35);
            this.txb_name.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tên.ForeColor = System.Drawing.Color.Teal;
            this.Tên.Location = new System.Drawing.Point(92, 193);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(166, 29);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã nhân viên";
            // 
            // txb_idem
            // 
            this.txb_idem.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_idem.Location = new System.Drawing.Point(95, 55);
            this.txb_idem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_idem.Name = "txb_idem";
            this.txb_idem.Size = new System.Drawing.Size(287, 35);
            this.txb_idem.TabIndex = 38;
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.PanEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(1186, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_RemoveAcc;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.RadioButton rb_sale;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rb_ware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_idem;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_updateAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
