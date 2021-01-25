using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Warranty
    {
        private int id;
        private string des;
        private DateTime dateIn;
        private DateTime dateOut;
        private int idEmp;
        private int idCus;
        private int idPro;
        private string status;


        public int Id { get => id; set => id = value; }
        public string Des { get => des; set => des = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime DateOut { get => dateOut; set => dateOut = value; }
        public int IdEmp { get => idEmp; set => idEmp = value; }
        public int IdCus { get => idCus; set => idCus = value; }
        public int IdPro { get => idPro; set => idPro = value; }
        public string Status { get => status; set => status = value; }

        public Warranty(int id, string des, DateTime dateIn, DateTime dateOut, int idEmp, int idCus, int idPro, string status)
        {
            this.Id = id;
            this.Des = des;
            this.DateIn = dateIn;
            this.DateOut = dateOut;
            this.IdEmp = idEmp;
            this.IdCus = idCus;
            this.IdPro = idPro;
            this.Status = status;
        }

        public Warranty(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Des = row["DESCR"].ToString();
            this.DateIn = (DateTime)row["Datein"];
            this.DateOut = (DateTime)row["DateOut"];
            this.IdEmp = (int)row["IDem"];
            this.IdCus = (int)row["IDcus"];
            this.IdPro = (int)row["IDpro"];
            this.Status = row["status"].ToString();
        }
    }
}
