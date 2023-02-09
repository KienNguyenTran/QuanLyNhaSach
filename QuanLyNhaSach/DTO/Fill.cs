using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Fill
    {
        private int id;
        private DateTime datetime;

        public Fill(int id, DateTime datetime)
        {
            this.Id = id;
            this.Datetime = datetime;
        }    

        public Fill(DataRow row)
        {
            this.Id=(int)row["id"];
            this.Datetime = Convert.ToDateTime(row["datetime"]);
        }
        

        public int Id 
        { 
            get { return id; }
            set { id = value; }
        }

        public DateTime Datetime 
        { 
            get { return datetime; }
            set { datetime = value; }
        }
    }
}
