namespace Final_Project.GUI
{
    partial class UC_Employee
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
            this.btn_AddEm = new System.Windows.Forms.Button();
            this.btn_RemoveEm = new System.Windows.Forms.Button();
            this.btn_EditEm = new System.Windows.Forms.Button();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_createacc = new System.Windows.Forms.Button();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.dtpk_Birth = new System.Windows.Forms.DateTimePicker();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.txb_LName = new System.Windows.Forms.TextBox();
            this.txb_FName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.dtgvEmp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.PanEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddEm
            // 
            this.btn_AddEm.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_AddEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddEm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEm.ForeColor = System.Drawing.Color.White;
            this.btn_AddEm.Location = new System.Drawing.Point(264, 482);
            this.btn_AddEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddEm.Name = "btn_AddEm";
            this.btn_AddEm.Size = new System.Drawing.Size(128, 49);
            this.btn_AddEm.TabIndex = 2;
            this.btn_AddEm.Text = "Thêm NV";
            this.btn_AddEm.UseVisualStyleBackColor = false;
            this.btn_AddEm.Click += new System.EventHandler(this.btn_AddEm_Click);
            // 
            // btn_RemoveEm
            // 
            this.btn_RemoveEm.BackColor = System.Drawing.Color.Tomato;
            this.btn_RemoveEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoveEm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveEm.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveEm.Location = new System.Drawing.Point(3, 482);
            this.btn_RemoveEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveEm.Name = "btn_RemoveEm";
            this.btn_RemoveEm.Size = new System.Drawing.Size(112, 49);
            this.btn_RemoveEm.TabIndex = 3;
            this.btn_RemoveEm.Text = "Xoá ";
            this.btn_RemoveEm.UseVisualStyleBackColor = false;
            this.btn_RemoveEm.Click += new System.EventHandler(this.btn_RemoveEm_Click);
            // 
            // btn_EditEm
            // 
            this.btn_EditEm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_EditEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditEm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditEm.ForeColor = System.Drawing.Color.White;
            this.btn_EditEm.Location = new System.Drawing.Point(123, 482);
            this.btn_EditEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditEm.Name = "btn_EditEm";
            this.btn_EditEm.Size = new System.Drawing.Size(135, 49);
            this.btn_EditEm.TabIndex = 4;
            this.btn_EditEm.Text = "Sửa";
            this.btn_EditEm.UseVisualStyleBackColor = false;
            this.btn_EditEm.Click += new System.EventHandler(this.btn_EditEm_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_clear);
            this.PanEmployee.Controls.Add(this.btn_createacc);
            this.PanEmployee.Controls.Add(this.txb_Phone);
            this.PanEmployee.Controls.Add(this.btn_EditEm);
            this.PanEmployee.Controls.Add(this.dtpk_Birth);
            this.PanEmployee.Controls.Add(this.btn_RemoveEm);
            this.PanEmployee.Controls.Add(this.txb_Address);
            this.PanEmployee.Controls.Add(this.btn_AddEm);
            this.PanEmployee.Controls.Add(this.txb_LName);
            this.PanEmployee.Controls.Add(this.txb_FName);
            this.PanEmployee.Controls.Add(this.label8);
            this.PanEmployee.Controls.Add(this.label4);
            this.PanEmployee.Controls.Add(this.label5);
            this.PanEmployee.Controls.Add(this.label6);
            this.PanEmployee.Controls.Add(this.label3);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(809, 2);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(574, 546);
            this.PanEmployee.TabIndex = 5;
            // 
            // btn_createacc
            // 
            this.btn_createacc.BackColor = System.Drawing.Color.Teal;
            this.btn_createacc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createacc.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createacc.ForeColor = System.Drawing.Color.White;
            this.btn_createacc.Location = new System.Drawing.Point(399, 482);
            this.btn_createacc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createacc.Name = "btn_createacc";
            this.btn_createacc.Size = new System.Drawing.Size(119, 49);
            this.btn_createacc.TabIndex = 36;
            this.btn_createacc.Text = "Tạo TK";
            this.btn_createacc.UseVisualStyleBackColor = false;
            this.btn_createacc.Click += new System.EventHandler(this.btn_createacc_Click);
            // 
            // txb_Phone
            // 
            this.txb_Phone.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_Phone.Location = new System.Drawing.Point(123, 264);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(252, 36);
            this.txb_Phone.TabIndex = 34;
            // 
            // dtpk_Birth
            // 
            this.dtpk_Birth.Location = new System.Drawing.Point(123, 342);
            this.dtpk_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_Birth.Name = "dtpk_Birth";
            this.dtpk_Birth.Size = new System.Drawing.Size(252, 26);
            this.dtpk_Birth.TabIndex = 33;
            // 
            // txb_Address
            // 
            this.txb_Address.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Address.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_Address.Location = new System.Drawing.Point(123, 187);
            this.txb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(252, 36);
            this.txb_Address.TabIndex = 32;
            // 
            // txb_LName
            // 
            this.txb_LName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_LName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_LName.Location = new System.Drawing.Point(123, 119);
            this.txb_LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_LName.Name = "txb_LName";
            this.txb_LName.Size = new System.Drawing.Size(252, 36);
            this.txb_LName.TabIndex = 31;
            // 
            // txb_FName
            // 
            this.txb_FName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_FName.Location = new System.Drawing.Point(123, 44);
            this.txb_FName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_FName.Name = "txb_FName";
            this.txb_FName.Size = new System.Drawing.Size(252, 36);
            this.txb_FName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(120, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(120, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(122, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(120, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(120, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(120, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ nhân viên";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.ForeColor = System.Drawing.Color.White;
            this.rb_Female.Location = new System.Drawing.Point(313, 12);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(66, 31);
            this.rb_Female.TabIndex = 27;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            this.rb_Female.CheckedChanged += new System.EventHandler(this.rb_Female_CheckedChanged);
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.ForeColor = System.Drawing.Color.White;
            this.rb_Male.Location = new System.Drawing.Point(155, 12);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(83, 31);
            this.rb_Male.TabIndex = 26;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            this.rb_Male.CheckedChanged += new System.EventHandler(this.rb_Male_CheckedChanged);
            // 
            // dtgvEmp
            // 
            this.dtgvEmp.BackgroundColor = System.Drawing.Color.White;
            this.dtgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmp.Location = new System.Drawing.Point(2, 2);
            this.dtgvEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEmp.Name = "dtgvEmp";
            this.dtgvEmp.RowHeadersWidth = 62;
            this.dtgvEmp.RowTemplate.Height = 28;
            this.dtgvEmp.Size = new System.Drawing.Size(801, 548);
            this.dtgvEmp.TabIndex = 6;
            this.dtgvEmp.Click += new System.EventHandler(this.dtgvEmp_Click);
            this.dtgvEmp.DoubleClick += new System.EventHandler(this.dtgvEmp_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.rb_Male);
            this.panel1.Controls.Add(this.rb_Female);
            this.panel1.Location = new System.Drawing.Point(809, 415);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 51);
            this.panel1.TabIndex = 37;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Teal;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(398, 413);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(119, 49);
            this.btn_clear.TabIndex = 37;
            this.btn_clear.Text = "Trống";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvEmp);
            this.Controls.Add(this.PanEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(1386, 551);
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddEm;
        private System.Windows.Forms.Button btn_RemoveEm;
        private System.Windows.Forms.Button btn_EditEm;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.DataGridView dtgvEmp;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.DateTimePicker dtpk_Birth;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.TextBox txb_LName;
        private System.Windows.Forms.TextBox txb_FName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_createacc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear;
    }
}
