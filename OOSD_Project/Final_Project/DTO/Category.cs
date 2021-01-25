using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Category
    {
        public Category(int id, string name,string des)
        {
            this.Id = id;
            this.Name = name;
            this.Des = des;
        }
        public Category(DataRow row)
        {
            this.Id = (int)row["IDCate"];
            this.Name = row["NameCate"].ToString();
            this.Des = row["DesCate"].ToString();
        }
        private int id;
        private string name;
        private string des;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Des { get => des; set => des = value; }
    }
}
