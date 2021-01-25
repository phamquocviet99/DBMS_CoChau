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
    public partial class Create_Cus_for_Saler : Form
    {
        public Create_Cus_for_Saler()
        {
            InitializeComponent();
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            string fname = txb_FName.Text;
            string lname = txb_LName.Text;
           
            string gender = "Male";
            rb_Female.Checked = true;
            if (rb_Female.Checked)
            {
                gender = "Female";
            }
            string phone = txb_Phone.Text;
            
            int this_year = DateTime.Now.Year;
            //if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            //{
            //    MessageBox.Show("The Customer Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
                if (CustomerDAO.Instance.InsertCustomer(fname, lname, gender, phone))
                {
                    MessageBox.Show("Thêm thành công khách hàng mới", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         
        }

        private void Create_Cus_for_Saler_Load(object sender, EventArgs e)
        {

        }
    }
}
