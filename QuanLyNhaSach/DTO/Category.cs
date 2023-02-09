using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Category
    {
        private string categoryname;
        private int id;

        public Category(int id, string categoryname)
        {
            this.Id = id;
            this.Categoryname = categoryname;
        }

        public Category(DataRow row)
        {
            this.id = (int)row["id"];
            this.Categoryname = row["CategoryName"].ToString();
        }
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string Categoryname 
        { 
            get { return categoryname; }
            set { categoryname = value; }
        }
    }
}
