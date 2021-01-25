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
using Final_Project.DTO;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Company : UserControl
    {
        BindingSource listcompany = new BindingSource();

        public UC_Company()
        {
            InitializeComponent();
            Load();
        }
        new void Load()
        {
            dtgv_company.DataSource =listcompany;
            LoadlistCompany();
            
        }
        void LoadlistCompany()
        {
            listcompany.DataSource = CompanyDAO.Instance.GetListCompany();
        }

        private void btn_addcompany_Click(object sender, EventArgs e)
        {
            string address = txb_addresscompany.Text;
            string name = txb_namecompany.Text;
            string phone = txb_phonecompany.Text;
            if (verif())
            {
                if (CompanyDAO.Instance.InsertCompany(name, address, phone))
                {
                    MessageBox.Show("Thêm thành công công ty mới", "Thêm công ty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Thêm công ty thất bại", "Thêm công ty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Thông tin bị trống", "Thêm công ty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        bool verif()
        {
            if ((txb_namecompany.Text.Trim() == "")
                        || (txb_addresscompany.Text.Trim() == "")
                        || (txb_phonecompany.Text.Trim() == "")
                        )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btn_editcompany_Click(object sender, EventArgs e)
        {
            string address = txb_addresscompany.Text;
            string name = txb_namecompany.Text;
            string phone = txb_phonecompany.Text;
            int id = Int32.Parse(tbx_idcompany.Text);
            if (verif())
            {
                if (CompanyDAO.Instance.UpdateCompany(name,id,address,phone))
                {
                    MessageBox.Show("Sửa thành công công ty mới", "Sửa công ty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Sửa công ty thất bại", "Sửa công ty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin bị trống", "Sửa công ty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtgvcompany_click(object sender, EventArgs e)
        {
            tbx_idcompany.Text = dtgv_company.CurrentRow.Cells[0].Value.ToString();
            txb_namecompany.Text = dtgv_company.CurrentRow.Cells[1].Value.ToString();
            txb_addresscompany.Text = dtgv_company.CurrentRow.Cells[2].Value.ToString();
            txb_phonecompany.Text = dtgv_company.CurrentRow.Cells[3].Value.ToString();


        }

        private void btn_removecompany_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbx_idcompany.Text);
            if (CompanyDAO.Instance.DeleteCompanyByID(id))
            {
                MessageBox.Show("Xóa thành công công ty mới", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Xóa công ty thất bại", "Xóa công ty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
