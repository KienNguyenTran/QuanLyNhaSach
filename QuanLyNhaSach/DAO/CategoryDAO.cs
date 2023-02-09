using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        { 
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> LoadCategoryList()
        {
            List<Category> list = new List<Category>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetCategoryList");
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public bool InsertCategory(int id, string categoryname)
        {
            string query = string.Format("INSERT into dbo.Category (ID, CategoryName) VALUES ({0}, N'{1}')", id, categoryname);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCategory(int id, string categoryname)
        {
            string query = string.Format("UPDATE dbo.Category SET CategoryName = N'{1}' where ID = {0}", id, categoryname);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            string query = string.Format("Delete dbo.Category where ID = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "Select * from dbo.Category where ID = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }

    }
}
