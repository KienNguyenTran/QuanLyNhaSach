using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class PublishDAO
    {
        private static PublishDAO instance;

        public static PublishDAO Instance 
        { 
            get { if(instance == null) instance = new PublishDAO(); return instance; }  
            set { PublishDAO.instance = value; }
        }

        private PublishDAO() { }

        public List<Publish> LoadPublishList()
        {
            List<Publish> list = new List<Publish>();
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.NhaXB");
            foreach (DataRow item in data.Rows)
            {
                Publish publish = new Publish(item);
                list.Add(publish);
            }
            return list;
        }
        public Publish GetPublishByID(int id)
        {
            Publish publish = null;
            string query = "Select * from dbo.NhaXB where ID = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                publish = new Publish(item);
                return publish;
            }
            return publish;
        }
            public bool InsertPublish(int id, string publishname)
        {
            string query = string.Format("INSERT into dbo.NhaXB (ID, PublishName) VALUES ({0}, N'{1}')", id, publishname);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePublish(int id, string publishname)
        {
            string query = string.Format("UPDATE dbo.NhaXB SET PublishName = N'{1}' where ID = {0}", id, publishname);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePublish(int id)
        {
            string query = string.Format("Delete dbo.NhaXB where ID = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
