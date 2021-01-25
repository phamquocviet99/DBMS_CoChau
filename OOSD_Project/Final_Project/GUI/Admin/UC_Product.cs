using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.GUI.Admin;
using Final_Project.DAO;
using Final_Project.DTO;

using System.Globalization;
using System;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
            Load();
        }
        List<Category> listCategory = new List<Category>();
        //BindingSource listpro = new BindingSource();
        new void Load()
        {
            LoadListproduct();
            dtgv_product.RowTemplate.Height = 25;
            //dtgv_product.DataSource = listpro;
            LoadCategogy();

        }
        void LoadCategogy()
        {
            listCategory = CategoryDAO.Instance.GetListCategory();
            cb_cate.DataSource = listCategory;
            cb_cate.DisplayMember = "Name";
        }
        void LoadListproduct()
        {
            
            dtgv_product.DataSource = ProductDAO.Instance.GetListProduct();
        }


        private void btn_Addproduct_Click(object sender, System.EventArgs e)
        {
            try
            {
                string name = txb_nameproduct.Text;
                float price = (float)num_Price.Value;
                int discount = Convert.ToInt32(txb_discountproduct.Text);
                int warranty = Convert.ToInt32(txb_warrantyproduct.Text);
                string origin = txb_originproduct.Text;

                int idcate = (cb_cate.SelectedItem as Category).Id;
                    if (ProductDAO.Instance.InsertProduct(idcate, name, price, discount, warranty, origin))
                    {
                        int idpro = ProductDAO.Instance.GetMaxIDpro();
                        //WarehouseDAO.Instance.InsertWarehouse(idpro, 0, 0);
                        MessageBox.Show("Thêm thành công sản phẩm mới và kho ", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load();
                        Product pro = new Product(1, idcate, name, price, discount, warranty, origin);
                        pro.ObserverInfo("");
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            }
            catch
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm !");
            }

        }

        private void btn_Editproduct_Click(object sender, System.EventArgs e)
        {
            //try
            //{
                int id = Convert.ToInt32(dtgv_product.CurrentRow.Cells[0].Value.ToString());
                int idcate = Convert.ToInt32(cb_cate.Text);
                string name = txb_nameproduct.Text;
                float price = (float)num_Price.Value;
                int discount = Convert.ToInt32(txb_discountproduct.Text);
                int warranty = Convert.ToInt32(txb_warrantyproduct.Text);
                string origin = txb_originproduct.Text;

               
                if (ProductDAO.Instance.UpdateProduct(id, idcate, name, price, discount, warranty, origin))
                  {
                        MessageBox.Show("Sửa thành công sản phẩm mới", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load();
                        Product pro = new Product(id, idcate, name, price, discount, warranty, origin);
                        pro.ObserverInfo("");
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
               
            //}
            //catch { MessageBox.Show(" Chọn sản phẩm trước khi sửa !"); }
        }
        
        private void btn_Removeproduct_Click(object sender, System.EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dtgv_product.CurrentRow.Cells[0].Value.ToString());
                if (ProductDAO.Instance.DeleteProduct(id))
                {
                    WarehouseDAO.Instance.DeleteWarehouse(id);
                    MessageBox.Show("Xóa thành công sản phẩm và kho", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { MessageBox.Show("Vui lòng chọn sản phẩm trước khi xóa !"); }

        }

        private void btn_Clear_Click(object sender, System.EventArgs e)
        {
            //tbx_idpro.Text = "";
            txb_discountproduct.Text = "";
            txb_nameproduct.Text = "";
            txb_originproduct.Text = "";
            num_Price.Text = "";
            txb_warrantyproduct.Text = "";
            cb_cate.Text = "";
            
        }
       

        private void dtgvproduct_Click(object sender, EventArgs e)
        {
            //tbx_idpro.Text = dtgv_product.CurrentRow.Cells[0].Value.ToString();
            cb_cate.Text = dtgv_product.CurrentRow.Cells[1].Value.ToString();
            txb_nameproduct.Text = dtgv_product.CurrentRow.Cells[2].Value.ToString();
            num_Price.Text = dtgv_product.CurrentRow.Cells[3].Value.ToString();
            txb_discountproduct.Text = dtgv_product.CurrentRow.Cells[4].Value.ToString();
            txb_warrantyproduct.Text = dtgv_product.CurrentRow.Cells[5].Value.ToString();
            txb_originproduct.Text = dtgv_product.CurrentRow.Cells[6].Value.ToString();

        }

        private void cb_cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
        }
     
    }
}
