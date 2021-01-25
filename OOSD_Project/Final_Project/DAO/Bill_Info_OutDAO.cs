using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Bill_Info_OutDAO
    {
        private static Bill_Info_OutDAO instance;
        public static Bill_Info_OutDAO Instance
        {
            get { if (instance == null) instance = new Bill_Info_OutDAO(); return Bill_Info_OutDAO.instance; }
            private set { Bill_Info_OutDAO.instance = value; }
        }
        public bool CreateBill_Info_Out(int idbill, int idpro, int count, double unitprice, double totalprice)
        {
            string query = string.Format("INSERT dbo.Bill_Info_Out(IDB_Out,IDPro,count,unitprice,price)VALUES ( {0},{1},{2},'{3}','{4}')", idbill,idpro,count,unitprice,totalprice);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
