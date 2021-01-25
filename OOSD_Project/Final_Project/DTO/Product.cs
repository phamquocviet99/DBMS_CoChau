using Final_Project.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.DTO
{
    public class Product : Observer
    {
        List<Customer> listcus = CustomerDAO.Instance.GetListCustomerCare();
        public Product(int id,int idcate,string name,double price,int discount,int warranty,string origin)
        {
            this.Id = id;
            this.Idcate = idcate;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Warranty = warranty;
            this.Origin = origin;
        }
        public Product(DataRow row)
        {
            this.Id = (int)row["IDPro"];
            this.Idcate = (int)row["IDcate"];
            this.Name = row["NamePro"].ToString();
            this.Price =  (double)Convert.ToDouble(row["PricePro"].ToString());
            this.Discount = (int)row["DiscountPro"];
            this.Warranty = (int)row["Warranty"];
            this.Origin = row["Origin"].ToString();

        }
        public override void ObserverInfo(string info)
        {

            foreach (Customer item in listcus)
            {
                if (item != null)
                {
                    item.ObserverInfo(Name + " với giá : "+Price+"VND");
                }
            }
            MessageBox.Show("Gửi mail thành công !");

        }
        
        public void addcus(Customer cus)
        {
            if (cus != null)
            {
                listcus.Add(cus);
            }
        }
        public void removecus(Customer cus)
        {
            if (cus != null)
            {
                listcus.Remove(cus);
            }
        }

        private int id;
        private int idcate;
        private string name;
        private double price;
        private int discount;
        private int warranty;
        private string origin;

        public int Id { get => id; set => id = value; }
        public int Idcate { get => idcate; set => idcate = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Warranty { get => warranty; set => warranty = value; }
        public string Origin { get => origin; set => origin = value; }
    }
}
