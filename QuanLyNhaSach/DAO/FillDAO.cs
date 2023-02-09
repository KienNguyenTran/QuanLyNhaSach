using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class FillDAO
    {
        private static FillDAO instance;

        public static FillDAO Instance 
        { 
            get { if (instance == null) FillDAO.Instance = new FillDAO(); return instance; }
            set { FillDAO.instance = value; }
        }

        private FillDAO() { }

        public List<FillInfo> LoadFillInfoList()
        {
            List<FillInfo> list = new List<FillInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("select pf.BookID, pf.BookName, pf.IDPhieuNhap, pf.Quantity, pf.Price, pf.Quantity*pf.Price as totalPrice from PhieuNhapInfo pf, PhieuNhap p, Book b where p.ID = pf.IDPhieuNhap and b.id = pf.BookID order by pf.IDPhieuNhap ASC");
            foreach (DataRow item in data.Rows)
            {
                FillInfo fill = new FillInfo(item);
                list.Add(fill);
            }
            return list;
        }

        public bool AddListFill(int id)
        {
            string query = string.Format("Insert into dbo.PhieuNhap (ID,DateTime) VALUES ({0},GETDATE())", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<Fill> LoadListFill()
        {
            List<Fill> list = new List<Fill>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.PhieuNhap");
            foreach (DataRow item in data.Rows)
            {
                Fill fill = new Fill(item);
                list.Add(fill);
            }
            return list;
        }

        public bool InsertFillInfo(int id, string bookname, int idphieunhap, int quantity, int price)
        {
            string query = string.Format("INSERT into dbo.PhieuNhapInfo (BookID, BookName, IDPhieuNhap, Quantity, Price) VALUES ({0}, N'{1}', {2}, {3}, {4})", id, bookname, idphieunhap, quantity, price);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteFill(int id)
        {
            string query = string.Format("Delete dbo.PhieuNhap where ID = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
