using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) BillDAO.Instance = new BillDAO(); return instance; }
            set { BillDAO.instance = value; } 
        }

        private BillDAO() { }

        public List<BillInfo> LoadBillInfoList()
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("select bi.BookID, bi.BookName, bi.IDBill, bi.Quantity, bi.Price, bi.Quantity*bi.Price as totalPrice from BillInfo bi, Bill b, Book bo where b.ID = bi.IDBill and bo.id = bi.BookID order by bi.IDBill asc");
            foreach (DataRow item in data.Rows)
            {
                BillInfo bill = new BillInfo(item);
                list.Add(bill);
            }
            return list;
        }
        public List<Bill> LoadBillList()
        {
            List<Bill> list = new List<Bill>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill");
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                list.Add(bill);
            }
            return list;
        }

        public void DeleteBillInfoByBookID(int id)
        {
            DataProvider.Instance.ExcuteQuery("DELETE dbo.BillInfo where BookID = " + id);
        }

        public bool AddListBill(int id)
        {
            string query = string.Format("Insert into dbo.Bill (ID,Date) VALUES ({0},GETDATE())", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBill(int id)
        {
            string query = string.Format("Delete dbo.Bill where ID = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool InsertBillInfo(int id, string bookname, int idbill, int quantity, int price)
        {
            string query = string.Format("INSERT into dbo.BillInfo (BookID, BookName, IDBill, Quantity, Price) VALUES ({0}, N'{1}', {2}, {3}, {4})", id, bookname, idbill, quantity, price);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
