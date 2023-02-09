using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    
    public class BookInfo
    {
        private string bookname;
        private int id;

        public BookInfo (int id, string bookname)
        {
            this.Id = id;
            this.Bookname = bookname;
        }

        public BookInfo(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Bookname = row["BookName"].ToString();
        }
        public int Id 
        { 
            get { return id; }
            set { id = value; }
        }

        public string Bookname 
        { 
            get { return bookname; }
            set { bookname = value; }
        }
    }
}
