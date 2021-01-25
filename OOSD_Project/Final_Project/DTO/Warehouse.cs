using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Warehouse
    {
        public Warehouse(int id,int idpro, double entryprice,int quantity,int idcom)
        {
            this.Id = id;
            this.Idpro = idpro;
            this.Entryprice = entryprice;
            this.Quantity = quantity;
            this.Idcom = idcom;
        }
        public Warehouse(DataRow row )
        {
            this.Id = (int)row["IDWa"];
            this.Idpro = (int)row["IDPro"];
            this.Entryprice= (double)Convert.ToDouble(row["EntryPrice"].ToString());
            this.Quantity = (int)row["Quantity"];
            this.Idcom= (int)row["IDcom"];
        }

        private int id;
        private int idpro;
        private double entryprice;
        private int quantity;
        private int idcom;

        public int Id { get => id; set => id = value; }
        public int Idpro { get => idpro; set => idpro = value; }
        public double Entryprice { get => entryprice; set => entryprice = value; }
        public  int Quantity { get => quantity; set => quantity = value; }
        public int Idcom { get => idcom; set => idcom = value; }
    }
}
