using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Employee
    {
        public Employee(int id, string fname, string lname, DateTime birthday, string gender,string phone,string address,bool status)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Brithday = birthday;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Status = status;
            
        }
        public Employee(DataRow row)
        {
            this.Id = (int)row["IDEm"];
            this.Fname = row["FirstN"].ToString();
            this.Lname = row["LastN"].ToString();
            this.Gender = row["Gender"].ToString();
            this.Phone = row["Phone"].ToString();
            this.Address = row["AddressEm"].ToString();
            this.Brithday = (DateTime)row["Birthday"];
            this.Status = (bool)row["Status"];
        }

        private int id;
        private string fname;
        private string lname;
        private DateTime brithday;
        private string gender;
        private string address;
        private string phone;
        private bool status;
        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public DateTime Brithday { get => brithday; set => brithday = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Status { get => status; set => status = value; }
    }
}
