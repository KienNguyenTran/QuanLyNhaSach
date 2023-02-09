using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Book
    {
        private int id;
        private string bookname;
        private string author;
        private int categoryid;
        private int publishid;

        public Book(int id, string bookname, string author, int categoryid, int publihsid)
        {
            this.Id = id;
            this.Bookname = bookname;
            this.Author = author;
            this.Categoryid = categoryid;
            this.Publishid = publihsid;
        }
        public Book(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Bookname = row["BookName"].ToString();
            this.Categoryid = (int)row["CategoryID"];
            this.Publishid = (int)row["PublishID"];
            this.Author = row["Author"].ToString();
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

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }

        public int Publishid
        {
            get { return publishid; }
            set { publishid = value; }
        }
    }
}
