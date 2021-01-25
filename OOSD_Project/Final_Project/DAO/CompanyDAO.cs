using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
   public class CompanyDAO
    {
        private static CompanyDAO instance;
        public static CompanyDAO Instance
        {
            get { if (instance == null) instance = new CompanyDAO(); return CompanyDAO.instance; }
            private set { CompanyDAO.instance = value; }
        }

        public List<Company> GetListCompany()
        {
            List<Company> list = new List<Company>();
            string query = "EXEC USP_GetListCompany";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Company company = new Company(item);
                list.Add(company);
            }
            return list;
        }

        public List<Company> SearchCompanyname(string name)
        {
            List<Company> list = new List<Company>();

            string query = string.Format("USP_SearchCompany @name = N'{0}'", name);

            DataTable data = MyDB.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Company com = new Company(item);
                list.Add(com);
            }

            return list;
        }
        public bool InsertCompany(string name, string address, string phone)
        {

            string query = string.Format("USP_InsertCompany @name = N'{0}',@address = N'{1}',@phone = N'{2}'", name, address, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCompany(string name, int id, string address, string phone)
        {
            string query = string.Format("USP_UpdateCompany @id = {1}, @name = N'{0}',@address = N'{2}',@phone = N'{3}'", name, id, address, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //public bool DeleteCompany(int id)
        //{
        //    string query = string.Format("Delete dbo.Company where IDC = {0}", id);
        //    int result = MyDB.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        public bool DeleteCompanyByID(int id)
        {
            string query = string.Format("USP_DeleteCompany @id = {0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int execCount(string query)
        {
            int count = MyDB.Instance.ExecuteNonQuery(query);
            return count;
        }

    }
}
