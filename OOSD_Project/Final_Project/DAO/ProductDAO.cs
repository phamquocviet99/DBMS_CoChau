using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
     public class ProductDAO 
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }
        private ProductDAO() { }
       
        public bool InsertProduct(int idcate,string name,float price,int discount,int warranty,string origin)
        {

            string query = string.Format("INSERT  dbo.Product(IDcate,NamePro,PricePro,DiscountPro,Warranty,Origin, islock)VALUES ( N'{0}', N'{1}', '{2}', N'{3}', {4}, N'{5}',0)", idcate,name,price,discount,warranty,origin);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaxIDpro()
        {
            try
            {
                return (int)MyDB.Instance.ExecuteScalar("select max(IDpro) from dbo.product");
            }
            catch
            {
                return 1;
            }
        }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();
            string query = " Select * from Product where islock = 0";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product pro = new Product(item);
                list.Add(pro);
            }
            return list;
        }
        public List<Product> GetListProductforSaler()
        {
            List<Product> list = new List<Product>();
            string query = "select * from f_loadlistproductforsaler()";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product pro = new Product(item);
                list.Add(pro);
            }
            return list;
        }
        public bool DeleteProduct(int id)
        {
            string query = string.Format("update dbo.product set islock = 1 FROM Product WHERE IDPro = {0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteProductByIdBrand(int id)
        {
            string query = string.Format("DELETE FROM Product WHERE IDcate ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateProduct(int id,int idcate, string name, float price, int discount, int warranty, string origin)
        {
            string query = string.Format("exec USP_UpdateProduct @idPro = {0}, @idCate = {1}, @namePro = N'{2}', @pricePro = {3}, @discountPro ={4}, @warranty ={5}, @origin N'{6}'", id,idcate,name,price,discount,warranty,origin);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int execCount(string query)
        {
            int count = MyDB.Instance.ExecuteNonQuery(query);
            return count;
        }
        public List<Product> SearchProductname(string name)
        {
            List<Product> list = new List<Product>();

            string query = string.Format("SELECT * FROM dbo.Product WHERE dbo.fuConvertToUnsign1(namepro) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = MyDB.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }

            return list;
        }
        public List<Product> GetProductByCateID(int id)
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product where IDcate= " + id;

            DataTable data = MyDB.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }

            return list;
        }
    }
}
