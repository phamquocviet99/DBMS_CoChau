using Final_Project.DAO;
using Final_Project.DTO;
using Final_Project.GUI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI.Admin
{
    public partial class Saler : Form
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
       double totalprice = 0;
        public Saler(Account acc)
        {
            InitializeComponent();
            LoadCategogy();
            this.LoginAccount = acc;
            Employee employee = EmployeeDAO.Instance.GetEmployeeByID(acc.Idem);
            lb_name.Text = (employee.Fname +" "+ employee.Lname);
           
        }
        private void lb_updateprofile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(LoginAccount);
            profile.ShowDialog();
        }
        BindingList<DTO.Menu> listmenu = new BindingList<DTO.Menu>();
        //List<DTO.Menu> listmenu1 = new List<DTO.Menu>();
        List<Category> listCategory = new List<Category>();
        List<Product> listProduct = new List<Product>();
        List<Customer> listCustomer = new List<Customer>();
        BindingList<Bill_Info_Out> bio = new BindingList<Bill_Info_Out>();
        //CultureInfo culture = new CultureInfo("vi-VN");

        void loaddtgvcart()
        {
            dgvcart.Columns["ID"].HeaderText = "Mã SP";
            dgvcart.Columns["NameProduct"].HeaderText = "Tên SP";
            dgvcart.Columns["Price"].HeaderText = "Giá";
            dgvcart.Columns["Count"].HeaderText = "Số lượng";
            dgvcart.Columns["TotalPrice"].HeaderText = "Tổng tiền";
        }
       //void changelist()
       // {
       //     foreach(DataGridViewRow row in dgvcart.Rows)
       //     {
       //         int idpro = (int)row.Cells["Id"].Value;
       //         string name = row.Cells["NameProduct"].Value.ToString();
       //         int count = (int)row.Cells["Count"].Value;
       //         double unitprice = (double)row.Cells["Price"].Value;
       //         double totalprice = (double)row.Cells["TotalPrice"].Value;
       //         DTO.Menu menu = new DTO.Menu(idpro, name, count, unitprice, totalprice);
       //         listmenu1.Add(menu);
       //     }
            
            
      
        private void loadheader_dgvpd()
        {
            dtgv_product.Columns["id"].HeaderText = "Mã SP";
            dtgv_product.Columns["idcate"].HeaderText = "Mã NH";
            dtgv_product.Columns["Name"].HeaderText = "Tên Sp";
            dtgv_product.Columns["Price"].HeaderText = "Giá tiền (VNĐ)";
            dtgv_product.Columns["Discount"].HeaderText = "Giảm giá";
            dtgv_product.Columns["Origin"].HeaderText = "Xuất sứ";
            this.dtgv_product.Columns["Warranty"].Visible = false;
        }
        // }
        private void Saler_Load(object sender, EventArgs e)
        {
            
            load();
            loadheader_dgvpd();
            string phone = txb_phone.Text;
            LoadCustomerbyphone(phone);
            cb_Category.Text = "";
  

        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load()
        {
            LoadCategogy();
            dtgv_product.DataSource = listProduct;
            loadProduct();
        }
        void Loadbill()
        {
            dgvcart.DataSource = null;
            dgvcart.Update();
            dgvcart.Refresh();
            dgvcart.DataSource = listmenu;
            //dataGridView1.Refresh();
        }
        void LoadCategogy()
        {
            listCategory = CategoryDAO.Instance.GetListCategory();
            cb_Category.DataSource = listCategory;
            cb_Category.DisplayMember = "Name";
        }
      
        void LoadCustomerbyphone(string phone)
        {
            listCustomer = CustomerDAO.Instance.SearchCustomerbyphone(phone);
            cb_customer.DataSource = listCustomer;
            cb_customer.DisplayMember = "Lname";
        }
        void Loadnummeric(int id)
        {
            Warehouse warehouse =  WarehouseDAO.Instance.GetQuantity(id);
            nm_count.Minimum = 0;
            nm_count.Maximum = warehouse.Quantity;
        }
        int maxamount(int id)
        {
            Warehouse warehouse = WarehouseDAO.Instance.GetQuantity(id);
            //nm_count.Minimum = 0;
            //nm_count.Maximum = warehouse.Quantity;
            return warehouse.Quantity;
        }
        void LoadProductListBybrand(int id)
        {
            listProduct = ProductDAO.Instance.GetProductByCateID(id);
            dtgv_product.DataSource = listProduct;
        }
        void loadProduct()
        {
            listProduct = ProductDAO.Instance.GetListProductforSaler();
            dtgv_product.DataSource = listProduct;
        }
        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            
        }

        private void pb_search_Click(object sender, EventArgs e)
        {
            listProduct = ProductDAO.Instance.SearchProductname(txb_search.Text);
            load();
        }

  

        private void lb_createcustomer_Click(object sender, EventArgs e)
        {
            Create_Cus_for_Saler create_Cus_For_Saler = new Create_Cus_for_Saler();
            create_Cus_For_Saler.Show(this);
        }

        private void pb_seachphonecus_Click(object sender, EventArgs e)
        {
            string phone = txb_phone.Text;
            LoadCustomerbyphone(phone);
        }
        

        private void dtgv_product_Click(object sender, EventArgs e)
        {
            try
            {
                int idpr = Int32.Parse(dtgv_product.CurrentRow.Cells[0].Value.ToString());
                Loadnummeric(idpr);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool checkproduct(string productname)
        {
            bool check = false;
            
            if (dgvcart.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvcart.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(productname.ToString()))
                    {

                        check = true;
                       
                        //count =  Int32.Parse( row.Cells[1].Value.ToString().Contains(productname.ToString()).ToString());
                        return check;

                    }
                   
                }
            }
            return check;
        }
        private void updateamout(int idpr,string productname,int countadd,ref bool check)
        {
            
            int count = 0;
            double unitprice = 0;
            int checksoluong = maxamount(idpr);
            check = false;
            foreach (DataGridViewRow row in dgvcart.Rows)
            {
                
                if (row.Cells[1].Value.ToString().Contains(productname.ToString()))
                {

                    count = Int32.Parse(row.Cells["Count"].Value.ToString());
                     
                    unitprice = double.Parse(row.Cells["Price"].Value.ToString());
                    count += countadd;
                    if(count > checksoluong)
                    {
                        count = checksoluong;
                        
                        check = true;
                       
                    }    
                    row.Cells["Count"].Value = count;
                    row.Cells["TotalPrice"].Value = count * unitprice ;
                    //count =  Int32.Parse( row.Cells[1].Value.ToString().Contains(productname.ToString()).ToString());
                   

                }

            }
          
        }
      
        private void btn_add_Click(object sender, EventArgs e)
        {
            int idpr = Int32.Parse(dtgv_product.CurrentRow.Cells[0].Value.ToString());
            int checksoluong = maxamount(idpr);
            int count = (int)nm_count.Value;
            if (checksoluong > count)
            {
                try
                {


                    string name = dtgv_product.CurrentRow.Cells[2].Value.ToString();

                    int discount = Int32.Parse(txb_discount.Text);
                    bool checkchange = false;
                    if (count > 0)
                    {
                        if (checkproduct(name) == true)
                        {
                            if (dgvcart.Rows.Count > 0)
                            {

                                updateamout(idpr, name, count, ref checkchange);
                                double unitprice = (double)dtgv_product.CurrentRow.Cells[3].Value;


                                if (checkchange != true)
                                {
                                    double price;
                                    price = (unitprice * count);
                                    totalprice = totalprice + price;
                                    lb_price.Text = totalprice.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Sản phẩm trong kho đã hết!");
                                }

                            }


                        }
                        else
                        {
                            double unitprice = (double)dtgv_product.CurrentRow.Cells[3].Value;

                            double price;


                            if (discount > 0)
                            {
                                price = (unitprice * count) - (((unitprice * count) * discount) / 100);
                            }
                            else
                            {
                                price = (unitprice * count);
                            }
                            totalprice = totalprice + price;
                            int id = Bill_OutDAO.Instance.GetMaxIDBill();

                            DTO.Menu menu = new DTO.Menu(idpr, name, count, unitprice, price);
                            listmenu.Add(menu);
                            Loadbill();
                            dgvcart.Refresh();

                            loaddtgvcart();
                            lb_price.Text = totalprice.ToString();
                        }


                    }
                    else
                    {
                        string message = "Số lượng mua phải lơn hơn 0";
                        string title = "Mua hàng";
                        MessageBox.Show(message, title);

                        return;
                    }
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Số lượng trong kho không đủ !");
            }
           
        }

        private void btn_createbill_Click(object sender, EventArgs e)
        {
            //int selectedCount = dgvcart.SelectedRows.Count;
            //while (selectedCount > 0)
            //{
            //    if (!dgvcart.SelectedRows[0].IsNewRow)
            //        dgvcart.Rows.RemoveAt(dgvcart.SelectedRows[0].Index);
            //    selectedCount--;
            //}
            //dgvcart.Refresh();
            //loaddtgvcart();
           

        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            try 
            {
                bool checkk = true;
                if (cb_customer.SelectedItem == null)
                {
                    string message = "Bạn chưa chọn khách hàng";
                    string title = "Thanh toán";
                    MessageBox.Show(message, title);
                   
                    return; 
                }
                int checkcart = dgvcart.Rows.Count;
                if (checkcart == 0 )
                {
                    string message = "Bạn chưa mua hàng";
                    string title = "Thanh toán";
                    MessageBox.Show(message, title);

                    return;
                }
                string message2 = "Bạn có chắc muốn thanh toán?";
                string title2 = "Thanh toán";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message2, title2, buttons);
                if (result == DialogResult.Yes)
                {
                    Customer cus = (cb_customer.SelectedItem as Customer);
                    int id_cus = cus.Id;
                    int id_em = LoginAccount.Idem;
                    //double Totalprice = double.Parse(totalprice.Text);
                    int discount = Int32.Parse(txb_discount.Text);

                    foreach (DataGridViewRow row in dgvcart.Rows)
                    {
                        int idpro = (int)row.Cells["Id"].Value;
                        int count = (int)row.Cells["Count"].Value;
                        string name = row.Cells["NameProduct"].Value.ToString();
                        if (maxamount(idpro) < count)
                        {
                            MessageBox.Show("Số lượng sản phẩm " + name + " trong kho không đủ ");
                            break;
                        }
                    }
                        if (Bill_OutDAO.Instance.CreateBillOut(id_cus, id_em, totalprice, discount))
                    {
                        int idbill = Bill_OutDAO.Instance.GetMaxIDBill();
                        foreach (DataGridViewRow row in dgvcart.Rows)
                        {
                            int idpro = (int)row.Cells["Id"].Value;
                            string name = row.Cells["NameProduct"].Value.ToString();
                            int count = (int)row.Cells["Count"].Value;
                            double unitprice = (double)row.Cells["Price"].Value;
                            double ttotalprice = (double)row.Cells["TotalPrice"].Value;
                            if (Bill_Info_OutDAO.Instance.CreateBill_Info_Out(idbill, idpro, count, unitprice, ttotalprice))
                            {
                            }
                            else { checkk = false; }
                        }
                    }
                    else { checkk = false; }
                    if (checkk == true)
                    {
                       
                        
                        string printmess = "Bạn có muốn in hóa đơn không?";
                        string titleprint = "Thanh toán";
                        MessageBoxButtons buttonprint = MessageBoxButtons.YesNo;
                        DialogResult resultprint = MessageBox.Show(printmess, titleprint, buttonprint);
                        if (resultprint == DialogResult.Yes)
                        {
                            Graphics g = this.CreateGraphics();
                            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                            Graphics mg = Graphics.FromImage(bmp);
                            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                            printPreviewDialog1.ShowDialog();
                        }
                        else
                        {
                            totalprice = 0;
                            lb_price.Text = "0";
                            dgvcart.Rows.Clear();
                            dgvcart.Refresh();
                            listProduct.Clear();
                            string message = "Thanh toán thành công";
                            string title = "Thanh toán";
                            MessageBox.Show(message, title);
                        }

                    }
                    // Mày phải làm cái form hiển thị bill, trong đó có nút in hóa đơn
                    // MessageBox.Show(id_cus.ToString() + id_em.ToString() + totalprice + discount.ToString());
                }
                else
                {
                    // Do something  
                }
               
            }
            catch
            {
                MessageBox.Show("Không thể thanh toán!");
            }
            


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            totalprice = 0;
            lb_price.Text = "0";
            dgvcart.Rows.Clear();
            dgvcart.Refresh();
        }

        private void pb_deleteProduct_Click(object sender, EventArgs e)
        {
           
           
            
        }

        private void pb_refresh_Click(object sender, EventArgs e)
        {
            dgvcart.Refresh();
        }

        private void dgvcart_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
               
            //    ContextMenu m = new ContextMenu();
            //    m.MenuItems.Add(new MenuItem("Cut"));
            //    m.MenuItems.Add(new MenuItem("Copy"));
            //    m.MenuItems.Add(new MenuItem("Paste"));
             
            //    m.Show(dgvcart, new Point(e.X, e.Y));
                

            //}
        }

        private void MenuItemNew_Click(Object sender, System.EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(dgvcart.Rows.Count >0 )
            {
                int rowIndex = dgvcart.CurrentCell.RowIndex;
                int amount = Int32.Parse(dgvcart.CurrentRow.Cells["Count"].Value.ToString());
                double uniprice = double.Parse(dgvcart.CurrentRow.Cells["PRICE"].Value.ToString());
                double ttprice = double.Parse(lb_price.Text);
                if (amount > 1)
                {
                    dgvcart.CurrentRow.Cells["Count"].Value = amount - 1;
                    double totalpricee = ttprice - uniprice;
                    lb_price.Text = totalpricee.ToString();
                }
                else
                {
                    dgvcart.Rows.RemoveAt(rowIndex);
                }
               
            }
          else
            {
                MessageBox.Show("Vui lòng mua sản phẩm");
            }    
               
            
          
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvcart.Rows.Count > 0)
            {
                int rowIndex = dgvcart.CurrentCell.RowIndex;
                double upr = double.Parse(dgvcart.CurrentRow.Cells["PRICE"].Value.ToString());
                int amou = int.Parse(dgvcart.CurrentRow.Cells["COUNT"].Value.ToString());
                double expr = upr * amou;
                totalprice = totalprice - expr;
                lb_price.Text = totalprice.ToString();
                dgvcart.Rows.RemoveAt(rowIndex);
             
            }
            else
            {
                MessageBox.Show("Vui lòng mua sản phẩm");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_warrity_Click(object sender, EventArgs e)
        {
            Warranty_Form warranty_Form = new Warranty_Form(LoginAccount);
            warranty_Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Profile profile = new Profile(LoginAccount);
            profile.ShowDialog();
        }

        private void cb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}