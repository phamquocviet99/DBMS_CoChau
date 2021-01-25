namespace Final_Project.GUI.Admin
{
    partial class UC_Company
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
            this.dtgv_company = new System.Windows.Forms.DataGridView();
            this.Panbr = new System.Windows.Forms.Panel();
            this.txb_phonecompany = new System.Windows.Forms.TextBox();
            this.txb_addresscompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addcompany = new System.Windows.Forms.Button();
            this.txb_namecompany = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btn_removecompany = new System.Windows.Forms.Button();
            this.btn_editcompany = new System.Windows.Forms.Button();
            this.tbx_idcompany = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_company)).BeginInit();
            this.Panbr.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_company
            // 
            this.dtgv_company.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_company.Location = new System.Drawing.Point(1, 1);
            this.dtgv_company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_company.Name = "dtgv_company";
            this.dtgv_company.RowHeadersWidth = 62;
            this.dtgv_company.RowTemplate.Height = 28;
            this.dtgv_company.Size = new System.Drawing.Size(712, 438);
            this.dtgv_company.TabIndex = 13;
            this.dtgv_company.Click += new System.EventHandler(this.dtgvcompany_click);
            // 
            // Panbr
            // 
            this.Panbr.Controls.Add(this.btn_Clear);
            this.Panbr.Controls.Add(this.txb_phonecompany);
            this.Panbr.Controls.Add(this.txb_addresscompany);
            this.Panbr.Controls.Add(this.label3);
            this.Panbr.Controls.Add(this.label1);
            this.Panbr.Controls.Add(this.btn_addcompany);
            this.Panbr.Controls.Add(this.txb_namecompany);
            this.Panbr.Controls.Add(this.Tên);
            this.Panbr.Controls.Add(this.btn_removecompany);
            this.Panbr.Controls.Add(this.btn_editcompany);
            this.Panbr.Controls.Add(this.tbx_idcompany);
            this.Panbr.Location = new System.Drawing.Point(719, 2);
            this.Panbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panbr.Name = "Panbr";
            this.Panbr.Size = new System.Drawing.Size(464, 437);
            this.Panbr.TabIndex = 14;
            // 
            // txb_phonecompany
            // 
            this.txb_phonecompany.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_phonecompany.Location = new System.Drawing.Point(103, 263);
            this.txb_phonecompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_phonecompany.Name = "txb_phonecompany";
            this.txb_phonecompany.Size = new System.Drawing.Size(260, 32);
            this.txb_phonecompany.TabIndex = 46;
            // 
            // txb_addresscompany
            // 
            this.txb_addresscompany.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_addresscompany.Location = new System.Drawing.Point(104, 184);
            this.txb_addresscompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_addresscompany.Name = "txb_addresscompany";
            this.txb_addresscompany.Size = new System.Drawing.Size(259, 32);
            this.txb_addresscompany.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Địa chỉ";
            // 
            // btn_addcompany
            // 
            this.btn_addcompany.BackColor = System.Drawing.Color.Teal;
            this.btn_addcompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addcompany.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcompany.ForeColor = System.Drawing.Color.White;
            this.btn_addcompany.Location = new System.Drawing.Point(309, 377);
            this.btn_addcompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addcompany.Name = "btn_addcompany";
            this.btn_addcompany.Size = new System.Drawing.Size(139, 38);
            this.btn_addcompany.TabIndex = 42;
            this.btn_addcompany.Text = "Thêm";
            this.btn_addcompany.UseVisualStyleBackColor = false;
            this.btn_addcompany.Click += new System.EventHandler(this.btn_addcompany_Click);
            // 
            // txb_namecompany
            // 
            this.txb_namecompany.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_namecompany.Location = new System.Drawing.Point(103, 107);
            this.txb_namecompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_namecompany.Name = "txb_namecompany";
            this.txb_namecompany.Size = new System.Drawing.Size(260, 32);
            this.txb_namecompany.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tên.Location = new System.Drawing.Point(100, 76);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(41, 24);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Tên";
            // 
            // btn_removecompany
            // 
            this.btn_removecompany.BackColor = System.Drawing.Color.Tomato;
            this.btn_removecompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removecompany.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removecompany.ForeColor = System.Drawing.Color.White;
            this.btn_removecompany.Location = new System.Drawing.Point(26, 377);
            this.btn_removecompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removecompany.Name = "btn_removecompany";
            this.btn_removecompany.Size = new System.Drawing.Size(132, 40);
            this.btn_removecompany.TabIndex = 3;
            this.btn_removecompany.Text = "Xoá ";
            this.btn_removecompany.UseVisualStyleBackColor = false;
            this.btn_removecompany.Click += new System.EventHandler(this.btn_removecompany_Click);
            // 
            // btn_editcompany
            // 
            this.btn_editcompany.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editcompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editcompany.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editcompany.ForeColor = System.Drawing.Color.White;
            this.btn_editcompany.Location = new System.Drawing.Point(164, 377);
            this.btn_editcompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editcompany.Name = "btn_editcompany";
            this.btn_editcompany.Size = new System.Drawing.Size(139, 40);
            this.btn_editcompany.TabIndex = 2;
            this.btn_editcompany.Text = "Sửa";
            this.btn_editcompany.UseVisualStyleBackColor = false;
            this.btn_editcompany.Click += new System.EventHandler(this.btn_editcompany_Click);
            // 
            // tbx_idcompany
            // 
            this.tbx_idcompany.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_idcompany.Location = new System.Drawing.Point(104, 30);
            this.tbx_idcompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_idcompany.Name = "tbx_idcompany";
            this.tbx_idcompany.Size = new System.Drawing.Size(259, 32);
            this.tbx_idcompany.TabIndex = 30;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = global::Final_Project.Properties.Resources.refresh2;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Location = new System.Drawing.Point(323, 310);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(40, 38);
            this.btn_Clear.TabIndex = 47;
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // UC_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panbr);
            this.Controls.Add(this.dtgv_company);
            this.Name = "UC_Company";
            this.Size = new System.Drawing.Size(1186, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_company)).EndInit();
            this.Panbr.ResumeLayout(false);
            this.Panbr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_company;
        private System.Windows.Forms.Panel Panbr;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txb_phonecompany;
        private System.Windows.Forms.TextBox txb_addresscompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addcompany;
        private System.Windows.Forms.TextBox txb_namecompany;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_removecompany;
        private System.Windows.Forms.Button btn_editcompany;
        private System.Windows.Forms.TextBox tbx_idcompany;
    }
}
