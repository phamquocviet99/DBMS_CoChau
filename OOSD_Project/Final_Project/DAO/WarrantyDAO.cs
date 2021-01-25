using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class WarrantyDAO
    {
        private static WarrantyDAO instance;
        public static WarrantyDAO Instance
        {
            get { if (instance == null) instance = new WarrantyDAO(); return WarrantyDAO.instance; }
            private set { WarrantyDAO.instance = value; }
        }
        private WarrantyDAO() { }

        public bool InsertWarranty(string des,  DateTime dateOut, int idEmp, int idCus, int idPro)
        {
            string query = string.Format("EXEC USP_InsertWanrity @descr =N'{0}' ,@dateout= '{1}', @idem ={2}, @idcus ={3},@idpro ={4}",
                                                   des, dateOut, idEmp, idCus, idPro);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetListWanrranty()
        {
            return MyDB.Instance.ExcuteQuery("select*from v_GetListWarranty");
        }
        public bool Confirm(int id)
        {
            string query = string.Format("USP_UpdateWanrity @id= {0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Delete(int id)
        {
            string query = string.Format("USP_DeleteWanrity @id ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletebyEmployee(int id)
        {
            string query = string.Format("USP_DeleteWanritybyEmployee @idem ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }

}
