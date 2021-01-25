using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
         public DataTable GetlistAcc()
        {
            return MyDB.Instance.ExcuteQuery("exec GetListAccount");
        }
        public bool InsertAccount(string username, int pos, int idem)
        {
            string query = string.Format(" EXEC USP_INSERTACCOUNT @idem= {0}, @username =N'{1}', @pos= {2}", idem, username, pos);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool RemoveAccount( int idem)
        {
            string query = string.Format("EXEC USP_RemoveAccount @idem ={0}", idem);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(int id, string username, int pos)
        {
            string query = string.Format("EXEC USP_UpdateAccount @idem = {0} , @username =N'{1}', @pos= {2}", id, username, pos);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccountinfo(string username, string password)
        {

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = string.Format("EXEC USP_UpdatePassword @username = N'{0}',@pas =N'{1}'", username, hasPass);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = MyDB.Instance.ExcuteQuery("exec USP_GetAccountbyUsername @username = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
       
        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            // var list = hasData.ToString();
            //list.Reverse();
   
            string query = "USP_Login @userName , @passWord";
            DataTable result = MyDB.Instance.ExcuteQuery(query, new object[] { userName, hasPass });
            return result.Rows.Count > 0;
        }
    }
}
