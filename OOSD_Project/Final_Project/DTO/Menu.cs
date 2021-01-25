using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Menu
    {
        public Menu(int id, string nameProduct, int count, double price, double totalPrice )
        {
            this.Id = id;
            this.NameProduct = nameProduct;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.NameProduct = row["NAMEPRODUCT"].ToString();
            this.Count = (int)row["COUNT"];
            this.Price = (double)Convert.ToDouble(row["PRICE"].ToString());
            this.TotalPrice = (double)Convert.ToDouble(row["TOTALPRICE"].ToString());
        }
        private int id;
        private double totalPrice;
        private double price;
        private int count;
        private string nameProduct;

        public int Id { get => id; set => id = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public double Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
      
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
     
    }
}
