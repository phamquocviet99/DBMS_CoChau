namespace Final_Project.GUI.Admin
{
    partial class UC_Statis
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
            this.dtgv_bill = new System.Windows.Forms.DataGridView();
            this.btn_statictics = new System.Windows.Forms.Button();
            this.dtpkin = new System.Windows.Forms.DateTimePicker();
            this.dtpkout = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_getlistbillonemonth = new System.Windows.Forms.Button();
            this.dtgv_employee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_bill
            // 
            this.dtgv_bill.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_bill.Location = new System.Drawing.Point(4, 68);
            this.dtgv_bill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_bill.Name = "dtgv_bill";
            this.dtgv_bill.RowHeadersWidth = 62;
            this.dtgv_bill.Size = new System.Drawing.Size(783, 322);
            this.dtgv_bill.TabIndex = 1;
            // 
            // btn_statictics
            // 
            this.btn_statictics.BackColor = System.Drawing.Color.Teal;
            this.btn_statictics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_statictics.ForeColor = System.Drawing.Color.White;
            this.btn_statictics.Location = new System.Drawing.Point(271, 21);
            this.btn_statictics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_statictics.Name = "btn_statictics";
            this.btn_statictics.Size = new System.Drawing.Size(136, 28);
            this.btn_statictics.TabIndex = 3;
            this.btn_statictics.Text = "Xem Thống Kê";
            this.btn_statictics.UseVisualStyleBackColor = false;
            this.btn_statictics.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // dtpkin
            // 
            this.dtpkin.Location = new System.Drawing.Point(16, 22);
            this.dtpkin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkin.Name = "dtpkin";
            this.dtpkin.Size = new System.Drawing.Size(247, 22);
            this.dtpkin.TabIndex = 4;
            // 
            // dtpkout
            // 
            this.dtpkout.Location = new System.Drawing.Point(415, 21);
            this.dtpkout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkout.Name = "dtpkout";
            this.dtpkout.Size = new System.Drawing.Size(265, 22);
            this.dtpkout.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 403);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng thu :";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(653, 403);
            this.lb_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(27, 29);
            this.lb_total.TabIndex = 7;
            this.lb_total.Text = "0";
            // 
            // btn_getlistbillonemonth
            // 
            this.btn_getlistbillonemonth.BackColor = System.Drawing.Color.Teal;
            this.btn_getlistbillonemonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_getlistbillonemonth.ForeColor = System.Drawing.Color.White;
            this.btn_getlistbillonemonth.Location = new System.Drawing.Point(698, 20);
            this.btn_getlistbillonemonth.Margin = new System.Windows.Forms.Padding(4);
            this.btn_getlistbillonemonth.Name = "btn_getlistbillonemonth";
            this.btn_getlistbillonemonth.Size = new System.Drawing.Size(203, 28);
            this.btn_getlistbillonemonth.TabIndex = 8;
            this.btn_getlistbillonemonth.Text = "Xem Thống Kê Trong Tháng";
            this.btn_getlistbillonemonth.UseVisualStyleBackColor = false;
            this.btn_getlistbillonemonth.Click += new System.EventHandler(this.btn_getlistbillonemonth_Click);
            // 
            // dtgv_employee
            // 
            this.dtgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_employee.Location = new System.Drawing.Point(823, 170);
            this.dtgv_employee.Name = "dtgv_employee";
            this.dtgv_employee.RowHeadersWidth = 51;
            this.dtgv_employee.RowTemplate.Height = 24;
            this.dtgv_employee.Size = new System.Drawing.Size(344, 151);
            this.dtgv_employee.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(818, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Top 2 nhân viên bán chạy nhất";
            // 
            // UC_Statis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv_employee);
            this.Controls.Add(this.btn_getlistbillonemonth);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpkout);
            this.Controls.Add(this.dtpkin);
            this.Controls.Add(this.btn_statictics);
            this.Controls.Add(this.dtgv_bill);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Statis";
            this.Size = new System.Drawing.Size(1187, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_bill;
        private System.Windows.Forms.Button btn_statictics;
        private System.Windows.Forms.DateTimePicker dtpkin;
        private System.Windows.Forms.DateTimePicker dtpkout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button btn_getlistbillonemonth;
        private System.Windows.Forms.DataGridView dtgv_employee;
        private System.Windows.Forms.Label label2;
    }
}
