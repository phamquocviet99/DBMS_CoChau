using Final_Project.DAO;
using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI.Admin
{
    public partial class Stock_manager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value;
            }
        }
        BindingList<DTO.Menu> listmenu = new BindingList<DTO.Menu>();
        List<Company> listcompany = new List<Company>();
        List<Product> listproduct = new List<Product>();
        CultureInfo culture = new CultureInfo("vi-VN");
        
        public Stock_manager(Account acc)
        {
           
            InitializeComponent();
            this.LoginAccount = acc;
            Employee employee = EmployeeDAO.Instance.GetEmployeeByID(acc.Idem);
            lb_acc.Text = (employee.Fname + " " + employee.Lname);
            dtgv_warehouse.DataSource = MyDB.Instance.ExcuteQuery("exec USP_GETLISTWAREHOUSE");
            
        }
        void load ()
        {
            dtgv_warehouse.DataSource = MyDB.Instance.ExcuteQuery("exec USP_GETLISTWAREHOUSE");
        }
        void Loadcount(int id)
        {
            Warehouse warehouse = WarehouseDAO.Instance.GetQuantity(id);
            lb_presentcount.Text = warehouse.Quantity.ToString();
            double old_price = warehouse.Entryprice;
            lb_oldprice.Text  = old_price.ToString();
        }
        void loadcbproduct(string name)
        {
            listproduct = ProductDAO.Instance.SearchProductname(name);
            cb_product.DataSource = listproduct;
            cb_product.DisplayMember = "Name";
        }
        void loadcbcompany(string name)
        {
            listcompany = CompanyDAO.Instance.SearchCompanyname(name);
            cb_company.DataSource = listcompany;
            cb_company.DisplayMember = "Name";

        }
        private void pb_search_Click(object sender, EventArgs e)
        {
            string name = txb_search.Text;
            if (rb_company.Checked)
            {
                loadcbcompany(name);
            }
            else
            {
                loadcbproduct(name);
            }
            
           
        }

        private void cb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product pro = (cb_product.SelectedItem as Product);
            int id = pro.Id;
            Loadcount(id);
            
        }
      
        private void btn_addto_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = (cb_product.SelectedItem as Product);
                int id_pro = product.Id;

                Company company = (cb_company.SelectedItem as Company);
                int id_com = company.Id;

                int count = (int)nmaddcount.Value;
                double unitprice = double.Parse(txb_newprice.Text);

                if (WarehouseDAO.Instance.UpdateWarehouse(id_pro, count, unitprice, id_com))
                {
                    MessageBox.Show("Thêm hàng thành công!");
                    load();
                }
            }
            catch
            {
                MessageBox.Show(" Vui lòng chọn đầy đủ th");
            }


        }

        private void lb_oldprice_Click(object sender, EventArgs e)
        {

            txb_newprice.Text = lb_oldprice.Text;
        }

        private void cb_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            Company com = (cb_company.SelectedItem as Company);
            lb_address.Text = com.Address;
          
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Company com = (cb_company.SelectedItem as Company);
            //int idcom = com.Id;
           
            //int pro 
            //if (WarehouseDAO.Instance.UpdateWarehouse(9, 50, 350000000, 4)) 
            //{ 
            //    MessageBox.Show("Thêm hàng thành công!"); 
            //}
        }

        private void Stock_manager_Load(object sender, EventArgs e)
        {
            string name = txb_search.Text;
           
                loadcbcompany(name);          
                loadcbproduct(name);
          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
