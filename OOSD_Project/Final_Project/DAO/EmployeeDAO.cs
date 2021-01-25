using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }
        private EmployeeDAO() { }
        public bool InsertEmployee( string fname, string lname, DateTime birthday, string gender, string phone, string address)
        {

            string query = string.Format("INSERT  dbo.Employee(FirstN,LastN,Birthday,Gender,Phone,AddressEm)VALUES ( N'{0}', N'{1}', '{2}', N'{3}', {4}, N'{5}')",  fname , lname , birthday , gender, phone, address);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Employee> GetListEmployee()
        {
            List<Employee> list = new List<Employee>();
            string query = " Select * from Employee where status = 1";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Employee emp = new Employee(item);
                list.Add(emp);
            }
            return list;
        }
        public bool DeleteEmployee(int id)
        {
            
            AccountDAO.Instance.RemoveAccount(id);
                string query = string.Format("UPDATE dbo.Employee SET status =0 where idem ={0}", id);
                int result = MyDB.Instance.ExecuteNonQuery(query);
                return result > 0;
            
        }
        public bool UpdateEmployee(string id, string fname, string lname, DateTime birthday, string gender, string phone, string address)
        {
            string query = string.Format("UPDATE dbo.Employee SET FirstN = N'{1}',LastN = N'{2}', Birthday = '{3}', Gender = N'{4}',Phone = {5},AddressEm=N'{6}' WHERE idem = {0}", id, fname,lname,birthday,gender,phone,address);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateEmployeeforprofile(int id, string fname, string lname,  string gender, string phone)
        {
            string query = string.Format("UPDATE dbo.Employee SET FirstN = N'{1}',LastN = N'{2}',  Gender = N'{3}',Phone = {4} WHERE idem = {0}", id, fname, lname,  gender, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public  int execCount(string query)
        {
            int count = MyDB.Instance.ExecuteNonQuery(query);
            return count;
        }
        public Employee GetEmployeeByID(int id)
        {
            DataTable data = MyDB.Instance.ExcuteQuery("Select * from dbo.Employee where IDEm = "+ id);

            foreach (DataRow item in data.Rows)
            {
                return new Employee(item);
            }
            return null;
        }
        public DataTable GetListEmployeeTop2()
        {
            return MyDB.Instance.ExcuteQuery("select*from f_top2employee()");
        }

    }
}
