using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.DTO;
using Final_Project.DAO;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Statis : UserControl
    {
        public UC_Statis()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadListEmployeeTop2();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkin.Value = new DateTime(today.Year, today.Month, 1);
            dtpkout.Value = dtpkin.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListEmployeeTop2()
        {
            dtgv_employee.DataSource = EmployeeDAO.Instance.GetListEmployeeTop2();
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgv_bill.DataSource = Bill_OutDAO.Instance.GetBillListByDate(checkIn, checkOut);
            int sum = 0;
            foreach (DataGridViewRow item in dtgv_bill.Rows)
            {
                sum += Convert.ToInt32(item.Cells["Tổng tiền"].Value);
            }
            this.lb_total.Text = sum.ToString()+" VNĐ";
        }
        void LoadListBillOneMonth()
        {
            dtgv_bill.DataSource = Bill_OutDAO.Instance.GetBillListOneMonth();
            int sum = 0;
            foreach (DataGridViewRow item in dtgv_bill.Rows)
            {
                sum += Convert.ToInt32(item.Cells["Tổng tiền"].Value);
            }
            this.lb_total.Text = sum.ToString() + " VNĐ";
        }
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkin.Value, dtpkout.Value);
        }

        private void btn_getlistbillonemonth_Click(object sender, EventArgs e)
        {
            LoadListBillOneMonth();
        }
    }
}
