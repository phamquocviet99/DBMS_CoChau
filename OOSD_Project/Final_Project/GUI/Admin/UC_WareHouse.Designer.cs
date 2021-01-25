namespace Final_Project.GUI.Admin
{
    partial class UC_WareHouse
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
            this.dtgvWarehouse = new System.Windows.Forms.DataGridView();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pro = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_RemoveWarehouse = new System.Windows.Forms.Button();
            this.btn_AddWarehouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWarehouse)).BeginInit();
            this.PanEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvWarehouse
            // 
            this.dtgvWarehouse.BackgroundColor = System.Drawing.Color.White;
            this.dtgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWarehouse.Location = new System.Drawing.Point(1, 2);
            this.dtgvWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvWarehouse.Name = "dtgvWarehouse";
            this.dtgvWarehouse.RowHeadersWidth = 62;
            this.dtgvWarehouse.RowTemplate.Height = 28;
            this.dtgvWarehouse.Size = new System.Drawing.Size(804, 548);
            this.dtgvWarehouse.TabIndex = 8;
            this.dtgvWarehouse.Click += new System.EventHandler(this.dtgvWarehouse_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.label1);
            this.PanEmployee.Controls.Add(this.cb_pro);
            this.PanEmployee.Controls.Add(this.btn_Clear);
            this.PanEmployee.Controls.Add(this.btn_RemoveWarehouse);
            this.PanEmployee.Controls.Add(this.btn_AddWarehouse);
            this.PanEmployee.Location = new System.Drawing.Point(811, 2);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(522, 546);
            this.PanEmployee.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(151, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sản phẩm";
            // 
            // cb_pro
            // 
            this.cb_pro.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pro.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_pro.FormattingEnabled = true;
            this.cb_pro.Location = new System.Drawing.Point(154, 102);
            this.cb_pro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_pro.Name = "cb_pro";
            this.cb_pro.Size = new System.Drawing.Size(238, 37);
            this.cb_pro.TabIndex = 37;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = global::Final_Project.Properties.Resources.refresh3;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Location = new System.Drawing.Point(437, 95);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(51, 55);
            this.btn_Clear.TabIndex = 36;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_RemoveWarehouse
            // 
            this.btn_RemoveWarehouse.BackColor = System.Drawing.Color.Tomato;
            this.btn_RemoveWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoveWarehouse.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveWarehouse.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveWarehouse.Location = new System.Drawing.Point(310, 349);
            this.btn_RemoveWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveWarehouse.Name = "btn_RemoveWarehouse";
            this.btn_RemoveWarehouse.Size = new System.Drawing.Size(130, 55);
            this.btn_RemoveWarehouse.TabIndex = 3;
            this.btn_RemoveWarehouse.Text = "Xoá";
            this.btn_RemoveWarehouse.UseVisualStyleBackColor = false;
            this.btn_RemoveWarehouse.Click += new System.EventHandler(this.btn_RemoveWarehouse_Click);
            // 
            // btn_AddWarehouse
            // 
            this.btn_AddWarehouse.BackColor = System.Drawing.Color.Teal;
            this.btn_AddWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddWarehouse.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddWarehouse.ForeColor = System.Drawing.Color.White;
            this.btn_AddWarehouse.Location = new System.Drawing.Point(88, 349);
            this.btn_AddWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddWarehouse.Name = "btn_AddWarehouse";
            this.btn_AddWarehouse.Size = new System.Drawing.Size(134, 55);
            this.btn_AddWarehouse.TabIndex = 2;
            this.btn_AddWarehouse.Text = "Thêm ";
            this.btn_AddWarehouse.UseVisualStyleBackColor = false;
            this.btn_AddWarehouse.Click += new System.EventHandler(this.btn_AddWarehouse_Click);
            // 
            // UC_WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanEmployee);
            this.Controls.Add(this.dtgvWarehouse);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_WareHouse";
            this.Size = new System.Drawing.Size(1334, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWarehouse)).EndInit();
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvWarehouse;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_RemoveWarehouse;
        private System.Windows.Forms.Button btn_AddWarehouse;
        private System.Windows.Forms.ComboBox cb_pro;
        private System.Windows.Forms.Label label1;
    }
}
