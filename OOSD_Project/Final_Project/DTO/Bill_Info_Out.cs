using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Bill_Info_Out
    {
        public Bill_Info_Out(int id,int iDB_O, int idpro, int count, double unitprice,double totalprice)
        {
            this.Id = id;
            this.Idb_out = iDB_O;
            this.Idpro = idpro;
            this.Count = count;
            this.Unitprice = unitprice;
            this.Totalprice = totalprice;
        }
        public Bill_Info_Out(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Idb_out = (int)row["IDB_Out"];
            this.Idpro = (int)row["IDPro"];
            this.Count = (int)row["count"];
            this.Unitprice=  (double)Convert.ToDouble(row["unitprice"].ToString());
           
            this.Totalprice = (double)Convert.ToDouble(row["price"].ToString());
        }

        private int id;
        private int idb_out;
        private int idpro;
        private int count;
        private double unitprice;
        private double totalprice; 

        public int Id { get => id; set => id = value; }
        public int Idb_out { get => idb_out; set => idb_out = value; }
        public int Idpro { get => idpro; set => idpro = value; }
        public int Count { get => count; set => count = value; }
        public double Totalprice { get => totalprice; set => totalprice = value; }
        public double Unitprice { get => unitprice; set => unitprice = value; }
    }
}
