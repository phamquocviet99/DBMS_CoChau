using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Bill_In
    {
        public Bill_In(int iD,int iDCom, int iDEm, DateTime datein,double totalPrice,int status)
        {
            this.ID = iD;
            this.IDCom = iDCom;
            this.IDEm = iDEm;
            this.Datein = datein;
            this.TotalPrice = totalPrice;
            this.Status = status;
        }
        public Bill_In(DataRow row)
        {
            this.ID = (int)row["IDB_I"];
            this.IDCom = (int)row["IDC"];
            this.IDEm = (int)row["IDEm"];
            this.Datein = (DateTime)row["DateIn"];
            this.TotalPrice = (double)Convert.ToDouble(row["Totalprice"].ToString());
            this.Status = (int)row["checkout"];
        }
        private int iD;
        private int iDCom;
        private int iDEm;
        private DateTime datein;
        private double totalPrice;
        private int status;

        public int ID { get => iD; set => iD = value; }
        public int IDCom { get => iDCom; set => iDCom = value; }
        public int IDEm { get => iDEm; set => iDEm = value; }
        public DateTime Datein { get => datein; set => datein = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int Status { get => status; set => status = value; }
    }
}
