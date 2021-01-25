using System;
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

namespace Final_Project.GUI.Admin
{
    public partial class UC_WareHouse : UserControl
    {
        
        public UC_WareHouse()
        {
            InitializeComponent();
            Load();
        }
        //BindingSource listwarehouse= new BindingSource();

        new void Load()
        {
            dtgvWarehouse.DataSource = MyDB.Instance.ExcuteQuery("Select * from dbo.Warehouse");
            dtgvWarehouse.RowTemplate.Height = 25;
            LoadCombox(cb_pro);
        }
      
        void LoadCombox(ComboBox cb)
        {
            cb.DataSource = ProductDAO.Instance.GetListProduct();
            cb.DisplayMember = "Name";
        }
      

        private void dtgvWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                
                cb_pro.Text = dtgvWarehouse.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
            
            //txb_Phone.Text = dtgvCustomer.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_AddWarehouse_Click(object sender, EventArgs e)
        {try
            {
                Product pro = (cb_pro.SelectedItem as Product);

                if (WarehouseDAO.Instance.InsertWarehouse(pro.Id, 0,0))
                {
                    MessageBox.Show("Thêm kho thành công", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Thêm kho thất bại", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { MessageBox.Show("Vui lòng điền đầy đủ thông tin !"); }
           
        }

       

        private void btn_RemoveWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dtgvWarehouse.CurrentRow.Cells[0].Value.ToString());
                if (WarehouseDAO.Instance.DeleteWarehouse(id))
                {
                    MessageBox.Show("Xóa kho thành công", "Xóa kho  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Xóa kho không thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn kho ");
            }
        }
    }
}
