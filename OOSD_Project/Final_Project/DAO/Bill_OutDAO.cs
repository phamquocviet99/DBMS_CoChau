using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Bill_OutDAO
    {
        private static Bill_OutDAO instance;
        public static Bill_OutDAO Instance
        {
            get { if (instance == null) instance = new Bill_OutDAO(); return Bill_OutDAO.instance; }
            private set { Bill_OutDAO.instance = value; }
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)MyDB.Instance.ExecuteScalar("select max(IDB_O) from dbo.BILL_out");
            }
            catch
            {
                return 1;
            }
        }
        public bool CreateBillOut(int idcus, int idem,double totalprice,int discount)
        {
            string query = string.Format("INSERT dbo.Bill_Out(IDCus,IDEm,DateOut,PriceOut,status,discount)VALUES ( {0} , {1},GETDATE(),'{2}',1 ,{3})",idcus, idem,totalprice,discount );
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return MyDB.Instance.ExcuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public DataTable GetBillListOneMonth()
        {
            return MyDB.Instance.ExcuteQuery("select*from v_GetListBillOneMonth");
        }



        public bool DeletebyEmployee(int id)
        {
            string query = string.Format("DELETE from dbo.BILL_out WHERE IDem ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result >= 0;
        }
    }
}
