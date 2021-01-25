using Final_Project.DAO;
using Final_Project.DTO;
using Final_Project.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI.User
{
    public partial class Warranty_Form : Form
    {
        private Account loginAccount;

        List<Customer> listcus = new List<Customer>();
        List<Product> listpro = new List<Product>();
       
        public Warranty_Form(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            Employee employee = EmployeeDAO.Instance.GetEmployeeByID(acc.Idem);
            lb_emp.Text = (employee.Fname + " " + employee.Lname);
            LoadWarranty();          
        }
       
        public Account LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
            }
        }

        private void pb_fine_product_Click(object sender, EventArgs e)
        {
            string name = txb_find_pro.Text;
            LoadProductbyname(name);
           
        }

        private void pb_seachphonecus_Click(object sender, EventArgs e)
        {
            string phone = txb_phone.Text;
            LoadCustomerbyphone(phone);
        }
        void LoadCustomerbyphone(string phone)
        {
            listcus = CustomerDAO.Instance.SearchCustomerbyphone(phone);
            cb_customer.DataSource = listcus;
            cb_customer.DisplayMember = "Lname";
        }
        void LoadProductbyname(string name)
        {
            listpro = ProductDAO.Instance.SearchProductname(name);
            cb_product.DataSource = listpro;
            cb_product.DisplayMember = "Name";
        }

        private void lb_createcustomer_Click(object sender, EventArgs e)
        {
            Create_Cus_for_Saler create_Cus_For_Saler = new Create_Cus_for_Saler();
            create_Cus_For_Saler.Show(this);
        }

        private void cb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Product selected = cb.SelectedItem as Product;
            lb_time_warranty.Text = (selected.Warranty.ToString() + "  tháng");
        }
        void LoadWarranty ()
        {
            dtgv_warranty.DataSource = WarrantyDAO.Instance.GetListWanrranty();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            LoadWarranty();
        }

        private void btn_AddWarranty_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.Month.ToString());
            try
            {
                if (cb_product.SelectedItem == null)
                { MessageBox.Show("Chọn sản phẩm"); return; }
                Product pro = cb_product.SelectedItem as Product;
                if (cb_customer == null)
                { MessageBox.Show("Chọn khách hàng"); return; }

                Customer cus = cb_customer.SelectedItem as Customer;
                int idem = loginAccount.Idem;
                int nowtime = DateTime.Now.Month;
                int outtime = dtpk_out.Value.Month;
                
                if ((outtime - nowtime) < 1 && (outtime - nowtime) < 12)
                {
                    MessageBox.Show("Thời gian bảo hành phải hơn 1 tháng !");
                    return;
                }
                else
                {
                    if (WarrantyDAO.Instance.InsertWarranty(txb_descr.Text, dtpk_out.Value, idem, cus.Id, pro.Id))
                    {
                        MessageBox.Show("Thêm phiếu bảo hành thành công");
                        LoadWarranty();
                    }
                    else { MessageBox.Show("Thêm thất bại !"); }
                }
        }
            catch
            {
                MessageBox.Show("Chọn đầy thủ thông tin !");
            }


}

        private void ckb_dateout_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       

        private void btn_disable_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dtgv_warranty.CurrentRow.Cells[0].Value.ToString());
                if (WarrantyDAO.Instance.Confirm(id))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    LoadWarranty();
                }
            }
            catch
            {
                MessageBox.Show("Chọn phiếu cần cập nhật !");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dtgv_warranty.CurrentRow.Cells[0].Value.ToString());
                if (WarrantyDAO.Instance.Delete(id))
                {
                    MessageBox.Show("Xóa thành công !");
                    LoadWarranty();
                }
            }
            catch
            {
                MessageBox.Show("Chọn phiếu cần xóa !");
            }
        }
    }
}
