namespace Final_Project.GUI.Admin
{
    partial class UC_Customer
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
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.btn_EditCustomer = new System.Windows.Forms.Button();
            this.dtpk_Birth = new System.Windows.Forms.DateTimePicker();
            this.btn_RemoveCustomer = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.txb_LName = new System.Windows.Forms.TextBox();
            this.txb_FName = new System.Windows.Forms.TextBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.PanEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(1, 2);
            this.dtgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 62;
            this.dtgvCustomer.RowTemplate.Height = 28;
            this.dtgvCustomer.Size = new System.Drawing.Size(712, 438);
            this.dtgvCustomer.TabIndex = 7;
            this.dtgvCustomer.Click += new System.EventHandler(this.dtgvCustomer_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.panel1);
            this.PanEmployee.Controls.Add(this.btn_Clear);
            this.PanEmployee.Controls.Add(this.tbx_id);
            this.PanEmployee.Controls.Add(this.txb_Phone);
            this.PanEmployee.Controls.Add(this.btn_EditCustomer);
            this.PanEmployee.Controls.Add(this.dtpk_Birth);
            this.PanEmployee.Controls.Add(this.btn_RemoveCustomer);
            this.PanEmployee.Controls.Add(this.btn_AddCustomer);
            this.PanEmployee.Controls.Add(this.txb_LName);
            this.PanEmployee.Controls.Add(this.txb_FName);
            this.PanEmployee.Controls.Add(this.label4);
            this.PanEmployee.Controls.Add(this.label5);
            this.PanEmployee.Controls.Add(this.label6);
            this.PanEmployee.Controls.Add(this.label3);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(721, 2);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(464, 437);
            this.PanEmployee.TabIndex = 8;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = global::Final_Project.Properties.Resources.refresh2;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Location = new System.Drawing.Point(410, 256);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(35, 34);
            this.btn_Clear.TabIndex = 36;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tbx_id
            // 
            this.tbx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_id.Location = new System.Drawing.Point(23, 40);
            this.tbx_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(47, 30);
            this.tbx_id.TabIndex = 35;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_Phone.Location = new System.Drawing.Point(122, 163);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(232, 29);
            this.txb_Phone.TabIndex = 34;
            // 
            // btn_EditCustomer
            // 
            this.btn_EditCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditCustomer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_EditCustomer.Location = new System.Drawing.Point(174, 377);
            this.btn_EditCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditCustomer.Name = "btn_EditCustomer";
            this.btn_EditCustomer.Size = new System.Drawing.Size(135, 38);
            this.btn_EditCustomer.TabIndex = 4;
            this.btn_EditCustomer.Text = "Sửa";
            this.btn_EditCustomer.UseVisualStyleBackColor = false;
            this.btn_EditCustomer.Click += new System.EventHandler(this.btn_EditCustomer_Click);
            // 
            // dtpk_Birth
            // 
            this.dtpk_Birth.Location = new System.Drawing.Point(123, 231);
            this.dtpk_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_Birth.Name = "dtpk_Birth";
            this.dtpk_Birth.Size = new System.Drawing.Size(233, 22);
            this.dtpk_Birth.TabIndex = 33;
            // 
            // btn_RemoveCustomer
            // 
            this.btn_RemoveCustomer.BackColor = System.Drawing.Color.Tomato;
            this.btn_RemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoveCustomer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveCustomer.Location = new System.Drawing.Point(23, 377);
            this.btn_RemoveCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveCustomer.Name = "btn_RemoveCustomer";
            this.btn_RemoveCustomer.Size = new System.Drawing.Size(129, 38);
            this.btn_RemoveCustomer.TabIndex = 3;
            this.btn_RemoveCustomer.Text = "Xoá ";
            this.btn_RemoveCustomer.UseVisualStyleBackColor = false;
            this.btn_RemoveCustomer.Click += new System.EventHandler(this.btn_RemoveCustomer_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.BackColor = System.Drawing.Color.Teal;
            this.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_AddCustomer.Location = new System.Drawing.Point(329, 377);
            this.btn_AddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(122, 38);
            this.btn_AddCustomer.TabIndex = 2;
            this.btn_AddCustomer.Text = "Thêm khách hàng";
            this.btn_AddCustomer.UseVisualStyleBackColor = false;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // txb_LName
            // 
            this.txb_LName.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_LName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_LName.Location = new System.Drawing.Point(121, 100);
            this.txb_LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_LName.Name = "txb_LName";
            this.txb_LName.Size = new System.Drawing.Size(233, 29);
            this.txb_LName.TabIndex = 31;
            // 
            // txb_FName
            // 
            this.txb_FName.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_FName.Location = new System.Drawing.Point(121, 40);
            this.txb_FName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_FName.Name = "txb_FName";
            this.txb_FName.Size = new System.Drawing.Size(233, 29);
            this.txb_FName.TabIndex = 30;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.ForeColor = System.Drawing.Color.White;
            this.rb_Female.Location = new System.Drawing.Point(285, 11);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(57, 28);
            this.rb_Female.TabIndex = 27;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.ForeColor = System.Drawing.Color.White;
            this.rb_Male.Location = new System.Drawing.Point(139, 11);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(73, 28);
            this.rb_Male.TabIndex = 26;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(119, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(119, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(119, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(119, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(117, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.rb_Female);
            this.panel1.Controls.Add(this.rb_Male);
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 45);
            this.panel1.TabIndex = 37;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanEmployee);
            this.Controls.Add(this.dtgvCustomer);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1186, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Button btn_EditCustomer;
        private System.Windows.Forms.DateTimePicker dtpk_Birth;
        private System.Windows.Forms.Button btn_RemoveCustomer;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.TextBox txb_LName;
        private System.Windows.Forms.TextBox txb_FName;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel1;
    }
}
