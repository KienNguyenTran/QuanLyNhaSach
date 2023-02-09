using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class BillInfo
    {
        private int price;
        private int quantity;
        private int idbill;
        private string bookname;
        private int bookid;
        private float totalprice;

        public BillInfo(int bookid, string bookname, int idbill, int quantity, int price, float totalprice = 0)
        {
            this.Bookid = bookid;
            this.Bookname = bookname;
            this.Idbill = idbill;
            this.Quantity = quantity;
            this.Price = price;
            this.Totalprice = totalprice;


        }

        public BillInfo(DataRow row)
        {
            this.Bookid = (int)row["BookID"];
            this.Bookname = row["BookName"].ToString();
            this.Idbill = (int)row["IDBill"];
            this.Quantity = (int)row["Quantity"];
            this.Price = (int)row["Price"];
            this.Totalprice = (float)Convert.ToDouble(row["totalprice"].ToString());

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

        public int Idbill
        {
            get { return idbill ; }
            set { idbill = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public float Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
    }
}
