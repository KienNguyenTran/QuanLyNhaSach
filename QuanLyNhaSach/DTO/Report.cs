using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Report
    {
        private int bookid;
        private string bookname;
        private int inprice;
        private int outprice;
        private DateTime date;
        private int outquantity;
        private float revenue;


        public Report(int bookid, string bookname, int inprice, int outprice, int outquantity, DateTime date, float revenue = 0)
        {
            this.Bookid = bookid;
            this.Bookname = bookname;
            this.Inprice = inprice;
            this.Outprice = outprice;
            this.Outquantity = outquantity;
            this.Date = date;
            this.Revenue = revenue;
        }

        public Report(DataRow row)
        {
            this.Bookid = (int)row["BookID"];
            this.Bookname = row["BookName"].ToString();
            this.Inprice = (int)row["InPrice"];
            this.Outprice = (int)row["OutPrice"];
            this.Outquantity = (int)row["OutQuantity"];
            this.Date = Convert.ToDateTime(row["Date"]);
            this.Revenue = (float)Convert.ToDouble(row["revenue"].ToString());
        }
        public int Bookid
        {
            get { return bookid; }
            set { bookid = value; }
        }

        public string Bookname
        {
            get { return bookname; }
            set { bookname = value; }
        }

        public int Inprice
        {
            get { return inprice; }
            set { inprice = value; }
        }

        public int Outprice
        {
            get { return outprice; }
            set { outprice = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Outquantity
        {
            get { return outquantity; }
            set { outquantity = value; }
        }


        public float Revenue
        {
            get { return revenue; }
            set { revenue = value; }
        }
    }
}
