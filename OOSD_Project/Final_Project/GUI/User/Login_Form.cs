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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            string password = txb_password.Text;
            Account loginaccount = AccountDAO.Instance.GetAccountByUserName(username);

            //int id = loginaccount.Idem;
            //string idd = id.ToString();
            if (login(username, password))
            {
                if (loginaccount.Pos == 2)
                {
                    Saler saler = new Saler(loginaccount);
                    this.Hide();
                    saler.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (loginaccount.Pos == 1)
                    {
                        Admin_Form admin_Form = new Admin_Form(loginaccount);
                        this.Hide();
                        admin_Form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                            Stock_manager stock = new Stock_manager(loginaccount);
                            this.Hide();
                            stock.ShowDialog();
                            this.Show();
                     }
                }
              


            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập!");
            }
        }
       
        bool login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void txb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_login_Click(sender, e);
            }
        }

        private void txb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_login_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
