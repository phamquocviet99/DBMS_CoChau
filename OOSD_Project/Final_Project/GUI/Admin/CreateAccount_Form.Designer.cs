namespace Final_Project.GUI.Admin
{
    partial class CreateAccount_Form
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
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.rb_ware = new System.Windows.Forms.RadioButton();
            this.rb_sale = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.btn_Create = new System.Windows.Forms.Button();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.PanEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_close);
            this.PanEmployee.Controls.Add(this.panel2);
            this.PanEmployee.Controls.Add(this.btn_Create);
            this.PanEmployee.Controls.Add(this.txb_username);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Controls.Add(this.label8);
            this.PanEmployee.Location = new System.Drawing.Point(1, 77);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(708, 322);
            this.PanEmployee.TabIndex = 8;
            // 
            // rb_ware
            // 
            this.rb_ware.AutoSize = true;
            this.rb_ware.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ware.ForeColor = System.Drawing.Color.White;
            this.rb_ware.Location = new System.Drawing.Point(475, 22);
            this.rb_ware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ware.Name = "rb_ware";
            this.rb_ware.Size = new System.Drawing.Size(98, 27);
            this.rb_ware.TabIndex = 37;
            this.rb_ware.TabStop = true;
            this.rb_ware.Text = "Thủ kho";
            this.rb_ware.UseVisualStyleBackColor = true;
            this.rb_ware.CheckedChanged += new System.EventHandler(this.rb_ware_CheckedChanged);
            // 
            // rb_sale
            // 
            this.rb_sale.AutoSize = true;
            this.rb_sale.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sale.ForeColor = System.Drawing.Color.White;
            this.rb_sale.Location = new System.Drawing.Point(304, 22);
            this.rb_sale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_sale.Name = "rb_sale";
            this.rb_sale.Size = new System.Drawing.Size(111, 27);
            this.rb_sale.TabIndex = 36;
            this.rb_sale.TabStop = true;
            this.rb_sale.Text = "Bán hàng";
            this.rb_sale.UseVisualStyleBackColor = true;
            this.rb_sale.CheckedChanged += new System.EventHandler(this.rb_sale_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.ForeColor = System.Drawing.Color.White;
            this.rbAdmin.Location = new System.Drawing.Point(153, 22);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(95, 27);
            this.rbAdmin.TabIndex = 35;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Quản lý";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Teal;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Location = new System.Drawing.Point(399, 264);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(174, 44);
            this.btn_Create.TabIndex = 3;
            this.btn_Create.Text = "Xác nhận";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txb_username
            // 
            this.txb_username.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_username.ForeColor = System.Drawing.Color.DarkGray;
            this.txb_username.Location = new System.Drawing.Point(153, 71);
            this.txb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(420, 32);
            this.txb_username.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(148, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Phần Quyền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 72);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(148, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên tài khoản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.rbAdmin);
            this.panel2.Controls.Add(this.rb_ware);
            this.panel2.Controls.Add(this.rb_sale);
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 65);
            this.panel2.TabIndex = 38;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Tomato;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(153, 264);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(174, 44);
            this.btn_close.TabIndex = 39;
            this.btn_close.Text = "Hủy";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // CreateAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateAccount_Form";
            this.Text = "CreateAccount_Form";
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.RadioButton rb_ware;
        private System.Windows.Forms.RadioButton rb_sale;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
    }
}