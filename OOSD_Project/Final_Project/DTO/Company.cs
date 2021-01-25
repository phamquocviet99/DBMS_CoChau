using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Company
    {
        public Company(int id, string name, string address, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
        public Company(DataRow row)
        {
            this.Id = (int)row["IDC"];
            this.Name = row["NameC"].ToString();
            this.Address = row["AddressC"].ToString();
            this.Phone = row["PhoneC"].ToString();      
        }
        private int id;
        private string name;
        private string address;
        private string phone;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
