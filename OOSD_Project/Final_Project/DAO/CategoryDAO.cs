using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = " Select * from Category";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category cate = new Category(item);
                list.Add(cate);
            }
            return list;
        }
       
        public bool InsertCategory(string name,string des )
        {

            string query = string.Format("INSERT dbo.CATEGORY ( namecate , descate)VALUES  ( N'{0}', N'{1}')", name,des);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(string name, int id,string des)
        {
            string query = string.Format("UPDATE dbo.CATEGORY SET namecate = N'{0}', descate = N'{2}' WHERE idcate = {1}", name, id,des);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
       
        public bool DeleteCategory(int id)
        {
           
            string query = string.Format("Delete dbo.CATEGORY where IDcate = {0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "SELECT*FROM CATEGORY where idcate=" + id;
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
    }
}
