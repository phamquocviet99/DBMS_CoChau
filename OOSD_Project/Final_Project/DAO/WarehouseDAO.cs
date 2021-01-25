using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.DAO;
using Final_Project.DTO;


namespace Final_Project.DAO
{
    public class WarehouseDAO
    {
        private static WarehouseDAO instance;
        public static WarehouseDAO Instance
        {
            get { if (instance == null) instance = new WarehouseDAO(); return WarehouseDAO.instance; }
            private set { WarehouseDAO.instance = value; }
        }
        private WarehouseDAO() { }
        public bool InsertWarehouse(int id_pro, int quantity,float entryprice)
        {

            string query = string.Format("INSERT dbo.Warehouse(IDPRO,Quantity,EntryPrice,idcom)VALUES ( {0}, {1},{2},0)",id_pro, quantity,entryprice);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Warehouse GetQuantity(int id)
        {
            DataTable data = MyDB.Instance.ExcuteQuery("Select * from dbo.Warehouse where IDpro = " + id);

            foreach (DataRow item in data.Rows)
            {
                return new Warehouse(item);
            }
            return null;
        }
       
        public bool DeleteWarehouse(int id)
        {
           
            string query = string.Format("DELETE FROM WAREHOUSE WHERE idpro ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateWarehouse(int id_pro, int quantity, double entryprice,int idcom)
        {
            string query = string.Format("exec USP_UpdateWarehourse @idpro = {0}, @quantitynew = {1}, @entryprice = {2}, @idcom = {3}", id_pro,quantity,entryprice,idcom);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCount(int idpr, int count, int status)
        {
            string query = string.Format("exec USP_UPDATEWAREHOUSE {0}, {1}, {2}", idpr, count, status);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
