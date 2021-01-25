using Final_Project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI.Admin
{
    public partial class CreateAccount_Form : Form
    {
        public CreateAccount_Form()
        {
            InitializeComponent();
        }
        public int id = 0;

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            int pos = 0;
            if (rbAdmin.Checked == true)
            {
                pos = 1;
            }
            else
            {
                if (rb_sale.Checked == true)
                {
                    pos = 2;
                }
                else
                {
                    pos = 3;
                }
            }
           
                if (AccountDAO.Instance.InsertAccount(username, pos, id))
                {
                    MessageBox.Show("Thêm thành công tài khoản mới", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại !", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
            
           
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_sale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_ware_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
