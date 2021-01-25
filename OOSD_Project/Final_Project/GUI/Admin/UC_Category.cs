using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.DAO;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Category : UserControl
    {
        BindingSource categorylist = new BindingSource();
        public UC_Category()
        {
            InitializeComponent();
            Load();
        }
        new void Load()
        {
            DataBindings.Clear();
            dtgv_category.DataSource = categorylist;
            LoadlistCategory();
            AddCategory();  
        }
       void  LoadlistCategory()
        {
            categorylist.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddCategory()
        {
            txb_des.DataBindings.Add(new Binding("Text", dtgv_category.DataSource, "Des", true, DataSourceUpdateMode.Never));
            txb_namecate.DataBindings.Add(new Binding("Text", dtgv_category.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        private void btn_AddCate_Click(object sender, EventArgs e)
        {
            string namecate = txb_namecate.Text;
            string descriptione = txb_des.Text;
            if (CategoryDAO.Instance.InsertCategory(namecate, descriptione))
            { MessageBox.Show("Thêm thành công !"); }
            else { MessageBox.Show("Thêm thất bại !"); }
            LoadlistCategory();
        }

        private void btn_Removecate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgv_category.CurrentRow.Cells[0].Value.ToString());
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa thành công !");
                LoadlistCategory();
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
            
        }

     

        private void btn_editcate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgv_category.CurrentRow.Cells[0].Value.ToString());
            string namecate = txb_namecate.Text;
            string des = txb_des.Text;
            if (CategoryDAO.Instance.UpdateCategory(namecate,id,des))
            { MessageBox.Show("Sửa thành công !"); LoadlistCategory(); }
            else { MessageBox.Show("Sửa thất bại !"); }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txb_des.Text = "";
            txb_namecate.Text = "";
        }

        private void dtgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
