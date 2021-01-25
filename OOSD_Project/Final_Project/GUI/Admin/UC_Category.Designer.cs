namespace Final_Project.GUI.Admin
{
    partial class UC_Category
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
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_AddCate = new System.Windows.Forms.Button();
            this.txb_des = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btn_Removecate = new System.Windows.Forms.Button();
            this.btn_editcate = new System.Windows.Forms.Button();
            this.txb_namecate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_category = new System.Windows.Forms.DataGridView();
            this.PanEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_clear);
            this.PanEmployee.Controls.Add(this.btn_AddCate);
            this.PanEmployee.Controls.Add(this.txb_des);
            this.PanEmployee.Controls.Add(this.Tên);
            this.PanEmployee.Controls.Add(this.btn_Removecate);
            this.PanEmployee.Controls.Add(this.btn_editcate);
            this.PanEmployee.Controls.Add(this.txb_namecate);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(808, 2);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(522, 546);
            this.PanEmployee.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = global::Final_Project.Properties.Resources.refresh1;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clear.Location = new System.Drawing.Point(408, 375);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(52, 56);
            this.btn_clear.TabIndex = 43;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_AddCate
            // 
            this.btn_AddCate.BackColor = System.Drawing.Color.Teal;
            this.btn_AddCate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddCate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCate.ForeColor = System.Drawing.Color.White;
            this.btn_AddCate.Location = new System.Drawing.Point(359, 466);
            this.btn_AddCate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCate.Name = "btn_AddCate";
            this.btn_AddCate.Size = new System.Drawing.Size(129, 46);
            this.btn_AddCate.TabIndex = 42;
            this.btn_AddCate.Text = "Thêm";
            this.btn_AddCate.UseVisualStyleBackColor = false;
            this.btn_AddCate.Click += new System.EventHandler(this.btn_AddCate_Click);
            // 
            // txb_des
            // 
            this.txb_des.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_des.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_des.Location = new System.Drawing.Point(87, 192);
            this.txb_des.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_des.Multiline = true;
            this.txb_des.Name = "txb_des";
            this.txb_des.Size = new System.Drawing.Size(373, 176);
            this.txb_des.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tên.ForeColor = System.Drawing.Color.Teal;
            this.Tên.Location = new System.Drawing.Point(81, 154);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(84, 34);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Mô tả";
            // 
            // btn_Removecate
            // 
            this.btn_Removecate.BackColor = System.Drawing.Color.Tomato;
            this.btn_Removecate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Removecate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Removecate.ForeColor = System.Drawing.Color.White;
            this.btn_Removecate.Location = new System.Drawing.Point(37, 466);
            this.btn_Removecate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Removecate.Name = "btn_Removecate";
            this.btn_Removecate.Size = new System.Drawing.Size(125, 46);
            this.btn_Removecate.TabIndex = 3;
            this.btn_Removecate.Text = "Xoá";
            this.btn_Removecate.UseVisualStyleBackColor = false;
            this.btn_Removecate.Click += new System.EventHandler(this.btn_Removecate_Click);
            // 
            // btn_editcate
            // 
            this.btn_editcate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editcate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editcate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editcate.ForeColor = System.Drawing.Color.White;
            this.btn_editcate.Location = new System.Drawing.Point(196, 466);
            this.btn_editcate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editcate.Name = "btn_editcate";
            this.btn_editcate.Size = new System.Drawing.Size(136, 46);
            this.btn_editcate.TabIndex = 2;
            this.btn_editcate.Text = "Sửa";
            this.btn_editcate.UseVisualStyleBackColor = false;
            this.btn_editcate.Click += new System.EventHandler(this.btn_editcate_Click);
            // 
            // txb_namecate
            // 
            this.txb_namecate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_namecate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txb_namecate.Location = new System.Drawing.Point(87, 71);
            this.txb_namecate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_namecate.Name = "txb_namecate";
            this.txb_namecate.Size = new System.Drawing.Size(373, 36);
            this.txb_namecate.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(81, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên danh mục";
            // 
            // dtgv_category
            // 
            this.dtgv_category.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_category.Location = new System.Drawing.Point(1, 1);
            this.dtgv_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_category.Name = "dtgv_category";
            this.dtgv_category.RowHeadersWidth = 62;
            this.dtgv_category.RowTemplate.Height = 28;
            this.dtgv_category.Size = new System.Drawing.Size(801, 548);
            this.dtgv_category.TabIndex = 10;
            this.dtgv_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_category_CellContentClick);
            // 
            // UC_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanEmployee);
            this.Controls.Add(this.dtgv_category);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Category";
            this.Size = new System.Drawing.Size(1334, 551);
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.Button btn_AddCate;
        private System.Windows.Forms.TextBox txb_des;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_Removecate;
        private System.Windows.Forms.Button btn_editcate;
        private System.Windows.Forms.TextBox txb_namecate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_category;
        private System.Windows.Forms.Button btn_clear;
    }
}
