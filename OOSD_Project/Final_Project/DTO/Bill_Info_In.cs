using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Bill_Info_In
    {
        public Bill_Info_In(int iD,int iDB_In,int iDPro,int count, double price, double totalPrice)
        {
            this.ID = iD;
            this.IDB_In = iDB_In;
            this.IDPro = iDPro;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Bill_Info_In(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDB_In = (int)row["IDB_In"];
            this.IDPro = (int)row["IDPro"];
            this.Count = (int)row["CountIn"];
            this.Price = (double)Convert.ToDouble(row["PriceIn"].ToString());
            this.TotalPrice = (double)Convert.ToDouble(row["Totalprice"].ToString());
        }



        private int iD;
        private int iDB_In;
        private int iDPro;
        private int count;
        private double price;
        private double totalPrice;

        public int ID { get => iD; set => iD = value; }
        public int IDB_In { get => iDB_In; set => iDB_In = value; }
        public int IDPro { get => iDPro; set => iDPro = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
    
}
