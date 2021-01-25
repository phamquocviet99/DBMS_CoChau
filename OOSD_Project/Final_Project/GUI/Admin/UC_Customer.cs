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
using System.Globalization;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
            Load();
        }
        BindingSource listcustomer = new BindingSource();
         new void Load()
        {
            LoadListCustomer();
            dtgvCustomer.RowTemplate.Height = 25;
            dtgvCustomer.DataSource = listcustomer;
        }
        void LoadListCustomer()
        {
            listcustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
        }
        bool verif()
        {
            if ((txb_FName.Text.Trim() == "")
                        || (txb_LName.Text.Trim() == "")
                        || (txb_Phone.Text.Trim() == "")
                        || (txb_Phone.Text.Trim() == "")
                        )
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void dtgvCustomer_Click(object sender, EventArgs e)
        {
            tbx_id.Text = dtgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txb_FName.Text = dtgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txb_LName.Text = dtgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txb_Phone.Text = dtgvCustomer.CurrentRow.Cells[5].Value.ToString();
            //txb_Phone.Text = dtgvCustomer.CurrentRow.Cells[6].Value.ToString();
            
            if ((dtgvCustomer.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                rb_Female.Checked = true;
            }
            else
            {
                rb_Male.Checked = true;
            }
        }

        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            string id = tbx_id.Text;
            string fname = txb_FName.Text;
            string lname = txb_LName.Text;
            DateTime birthday = dtpk_Birth.Value;
            string gender = "";
            if (rb_Female.Checked == true)
            {
                gender = "Female";
            }
            else
            { gender = "Male"; }
            string phone = txb_Phone.Text;
            int born_year = dtpk_Birth.Value.Year;
            int this_year = DateTime.Now.Year;
           
            if (verif())
            {
                if (CustomerDAO.Instance.UpdateCustomer(id, fname, lname, birthday, gender, phone))
                {
                    MessageBox.Show("Sửa thành công khách hàng mới", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin bị trống", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            string fname = txb_FName.Text;
            string lname = txb_LName.Text;
            DateTime birthday = dtpk_Birth.Value;
            string gender = "Male";
            rb_Female.Checked = true;
            if (rb_Female.Checked)
            {
                gender = "Female";
            }
            string phone = txb_Phone.Text;
            int born_year = dtpk_Birth.Value.Year;
            int this_year = DateTime.Now.Year;
            //if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            //{
            //    MessageBox.Show("The Customer Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
             if (verif())
            {
                if (CustomerDAO.Instance.InsertCustomer(fname, lname,  gender, phone))
                {
                    MessageBox.Show("Thêm thành công khách hàng mới", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin bị trống", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_RemoveCustomer_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbx_id.Text);
            if (CustomerDAO.Instance.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa thành công khách hàng mới", "Xóa khách hàng  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_id.Text = "";
            txb_FName.Text = "";
            txb_LName.Text = "";
            txb_Phone.Text = "";
        }
    }
}
