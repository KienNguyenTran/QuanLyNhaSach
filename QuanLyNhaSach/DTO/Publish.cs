using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Publish
    {
        private string publishname;
        private int id;

        public Publish(int id, string publishname)
        {
            this.Id = id;
            this.Publishname = publishname;
        }
        public Publish(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Publishname = row["PublishName"].ToString();
        }
        public int Id 
        { 
            get { return id; }
            set { id = value; }
        }

        public string Publishname 
        { 
            get { return publishname; }
            set { publishname = value; }
        }
    }
}
