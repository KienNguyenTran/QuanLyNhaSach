using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Bill
    {
        private int id;
        private DateTime date;

        public Bill(int id, DateTime date)
        {
            this.Id = id;
            this.Date = date;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Date = Convert.ToDateTime(row["Date"]);
        }
        public int Id 
        { 
            get { return id; }
            set { id = value; }
        }

        public DateTime Date 
        { 
            get { return date; }
            set { date = value; }
        }
    }
}
