using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Bill_Out
    {
        public Bill_Out(int iDB_O, int iDcus,int iDem,DateTime dateout,float priceOut,int status,int discount)
        {
            this.IDB_O = iDB_O;
            this.IDcus = iDcus;
            this.IDem = iDem;
            this.PriceOut = priceOut;
            this.Dateout = dateout;
            this.Status = status;
            this.Discount = discount;

        }
         public Bill_Out(DataRow row)
        {
            this.IDB_O = (int)row["IDB_O"];
            this.IDcus = (int)row["IDCus"];
            this.IDem = (int)row["IDEm"];
            this.PriceOut = (float)Convert.ToDouble(row["PriceOut"].ToString());
            this.Dateout = (DateTime)row["DateOut"];
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }

        private int iDB_O;
        private int iDcus;
        private int iDem;
        private DateTime dateout;
        private float priceOut;
        private int status;
        private int discount;
        public int IDB_O { get => iDB_O; set => iDB_O = value; }
        public int IDcus { get => iDcus; set => iDcus = value; }
        public int IDem { get => iDem; set => iDem = value; }
        public DateTime Dateout { get => dateout; set => dateout = value; }
        public float PriceOut { get => priceOut; set => priceOut = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Status { get => status; set => status = value; }
        
    }
}
