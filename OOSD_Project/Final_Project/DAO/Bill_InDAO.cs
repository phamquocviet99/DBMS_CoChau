using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Bill_InDAO
    {
        private static Bill_InDAO instance;
        public static Bill_InDAO Instance
        {
            get { if (instance == null) instance = new Bill_InDAO(); return Bill_InDAO.instance; }
            private set { Bill_InDAO.instance = value; }
        }
        public int GetMaxIDBillIn()
        {
            try
            {
                return (int)MyDB.Instance.ExecuteScalar("select max(IDB_O) from dbo.BILL_in");
            }
            catch
            {
                return 1;
            }
        }
        public bool CreateBillIn(int idcom,int idem,double totalprice)
        {
            string query = string.Format("INSERT dbo.Bill_In(IDC,IDEm,DateIN,TotalPrice,checkout)VALUES ( {0} , {1},GETDATE(),'{2}',1)",idcom,idem,totalprice);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletebyEmployee(int id)
        {
            string query = string.Format("DELETE from dbo.BILL_In WHERE IDem ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
