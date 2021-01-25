using Final_Project.DAO;
using Final_Project.DTO;
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
    public partial class Profile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set
            {
                loginAccount = value; Changeaccount(loginAccount);
            }
        }
        public Profile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo(LoginAccount);
        }
        void Changeaccount(Account acc)
        {
            int id = acc.Idem;
            Employee employee = EmployeeDAO.Instance.GetEmployeeByID(id);
            tb_username.Text = acc.Username;
            tb_lastname.Text = employee.Lname;
            tb_firstname.Text = employee.Fname;
            tb_phone.Text = employee.Phone;
            if ((/*dtgvEmp.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"*/ employee.Gender.ToString().Trim() == "Female"))
            {
                rb_femail.Checked = true;
            }
            else
            {
                rb_male.Checked = true;
            }
        }
        void UpdateAccountInfo(Account acc)
        {
            //username, password, newpassword,fname,lname,gender,phone,id
            int id = acc.Idem;
            string username = tb_username.Text;
            string password = tb_oldpass.Text;
            string newpass = tb_newpass.Text;
            string reenterPass = tb_repass.Text;
            string fname = tb_firstname.Text;
            string lname = tb_lastname.Text;
            string phone = tb_phone.Text;
            string gender = " ";
            if (rb_femail.Checked == true)
            {
                gender = "Female";
            }
            else
            { gender = "Male"; }

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.Login(username,password))
                {
                    if(AccountDAO.Instance.UpdateAccountinfo(username,newpass) &&  EmployeeDAO.Instance.UpdateEmployeeforprofile(id,fname,lname,gender,phone))
                        MessageBox.Show("Cập nhật thành công");
                    MessageBox.Show(id.ToString());
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu");
                }
            }

        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }


        }


    }
}
