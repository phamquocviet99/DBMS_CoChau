using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Account
    {
        public Account(string username, string password, int pos,int idem)
        {
            this.Username = username;
            this.Password = password;
            this.Pos = pos;
            this.Idem = idem;
        }
        public Account(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.Pos = (int)row["Pos"];
            this.Idem = (int)row["IDem"];
        }
        private string username;
        private string password;
        private int  pos;
        private int idem;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Pos { get => pos; set => pos = value; }
        public int Idem { get => idem; set => idem = value; }
    }
}
