using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Bill_Info_InDAO
    {
        private static Bill_Info_InDAO instance;
        public static Bill_Info_InDAO Instance
        {
            get { if (instance == null) instance = new Bill_Info_InDAO(); return Bill_Info_InDAO.instance; }
            private set { Bill_Info_InDAO.instance = value; }
        }
        public bool CreateBill_Info_In(int idbill, int idpro, int count, double unitprice, double totalprice)
        {
            string query = string.Format("INSERT dbo.Bill_Info_In(IDB_In,IDPro,CountIn,PriceIn,Totalprice)VALUES ( {0},{1},{2},'{3}','{4}')", idbill, idpro, count, unitprice, totalprice);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
