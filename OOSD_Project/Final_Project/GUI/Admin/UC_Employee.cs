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
using Final_Project.DTO;

namespace Final_Project.GUI
{
    public partial class UC_Employee : UserControl
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
        public UC_Employee(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            Load();
        }
        BindingSource listemploy = new BindingSource();
        void Load()
        {
            LoadListEmploy();
            dtgvEmp.RowTemplate.Height = 25;
            dtgvEmp.DataSource = listemploy;
        }
        void LoadListEmploy()
        {      
           listemploy.DataSource= EmployeeDAO.Instance.GetListEmployee();
        }

        private void btn_AddEm_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txb_FName.Text;
                string lname = txb_LName.Text;
                DateTime birthday = dtpk_Birth.Value;
                string gender = "";
                if (rb_Female.Checked == true)
                {
                    gender = "Nữ";
                }
                else
                { gender = "Nam"; }
                string phone = txb_Phone.Text;
                string address = txb_Address.Text;
                int born_year = dtpk_Birth.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi nhân viên phải trong từ 10 đến 100", "Độ tuổi không phù hợp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    if (EmployeeDAO.Instance.InsertEmployee(fname, lname, birthday, gender, phone, address))
                    {
                        MessageBox.Show("Thêm thành công nhân viên mới", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin bị trống", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { MessageBox.Show("Vui lòng thêm đầy đủ thông tin nhân viên !"); }

        }
        bool verif()
        {
            if ((txb_FName.Text.Trim() == "")
                        || (txb_LName.Text.Trim() == "")
                        || (txb_Phone.Text.Trim() == "")
                        || (txb_Phone.Text.Trim() == "")
                        || (txb_Address.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void dtgvEmp_Click(object sender, EventArgs e)
        {
            //tbx_id.Text = dtgvEmp.CurrentRow.Cells[0].Value.ToString();
            txb_FName.Text= dtgvEmp.CurrentRow.Cells[1].Value.ToString();
            txb_LName.Text = dtgvEmp.CurrentRow.Cells[2].Value.ToString();
            txb_Address.Text = dtgvEmp.CurrentRow.Cells[5].Value.ToString();
            txb_Phone.Text = dtgvEmp.CurrentRow.Cells[6].Value.ToString();
            dtpk_Birth.Value = (DateTime)dtgvEmp.CurrentRow.Cells[3].Value;
            if ((dtgvEmp.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                rb_Female.Checked = true;
            }
            else
            {
                rb_Male.Checked = true;
            }
        }

        private void btn_RemoveEm_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dtgvEmp.CurrentRow.Cells[0].Value.ToString());
                if (loginAccount.Idem == id)
                { MessageBox.Show("Bạn không thể xóa chính bạn !"); return; }
                if (EmployeeDAO.Instance.DeleteEmployee(id))
                {
                    MessageBox.Show("Xóa thành công nhân viên mới", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { MessageBox.Show("Vui lòng chọn thành viên !"); }
            //try
            //{
            //    int id = Int32.Parse(dtgvEmp.CurrentRow.Cells[0].Value.ToString());
            //    if (EmployeeDAO.Instance.DeleteEmployee(id))
            //    {
            //        MessageBox.Show("Xóa thành công nhân viên mới", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Load();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Xóa nhân viên thất bại", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch { MessageBox.Show("Vui lòng chọn nhân viên !"); }
        }

        private void btn_EditEm_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dtgvEmp.CurrentRow.Cells[0].Value.ToString();
                string fname = txb_FName.Text;
                string lname = txb_LName.Text;
                DateTime birthday = dtpk_Birth.Value;
                string gender = "";
                if (rb_Female.Checked == true)
                {
                    gender = "Nữ";
                }
                else
                { gender = "Nam"; }
                string phone = txb_Phone.Text;
                string address = txb_Address.Text;
                int born_year = dtpk_Birth.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi nhân viên phải trong từ 10 đến 100", "Độ tuổi không phù hợp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    if (EmployeeDAO.Instance.UpdateEmployee(id, fname, lname, birthday, gender, phone, address))
                    {
                        MessageBox.Show("Sửa nhân viên thành công !", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại !", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin bị trống ", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên trong bảng !");
            }
        }

        private void dtgvEmp_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            try
            {
                CreateAccount_Form create = new CreateAccount_Form();
                create.Show(this);
                create.id = Convert.ToInt32(dtgvEmp.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên !");
            }
           
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txb_FName.Text = "";
            txb_LName.Text = "";
            txb_Address.Text = "";
            txb_Phone.Text = "";
            dtpk_Birth.Value = DateTime.Now;
        }
    }
}
