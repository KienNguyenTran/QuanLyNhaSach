using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance 
        { 
            get { if (instance == null) BookDAO.instance = new BookDAO(); return instance;}
            set { BookDAO.instance = value; }
        }

        private BookDAO() { }

        public List<Book> LoadBookList()
        {
            List<Book> list = new List<Book>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetBookList");
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<BookInfo> LoadListBookInfo()
        {
            List<BookInfo> list = new List<BookInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetBookListByIDAndName");
            foreach (DataRow item in data.Rows)
            {
                BookInfo book = new BookInfo(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> SearchBookByName(string bookname)
        {
            List<Book> list = new List<Book>();
            string query = string.Format("select * from dbo.Book where dbo.fuConvertToUnsign1(BookName) Like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", bookname);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> SearchBookByAuthor(string authorname)
        {
            List<Book> list = new List<Book>();
            string query = string.Format("select * from dbo.Book where dbo.fuConvertToUnsign1(Author) Like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", authorname);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }
        public bool InsertBook(int id, string bookname, int categoryid, int publishid, string author)
        {
            string query = string.Format("INSERT into dbo.Book (ID, BookName, CategoryID, PublishID, Author) VALUES ({0}, N'{1}', {2}, {3}, N'{4}')", id, bookname, categoryid, publishid, author);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBook(int id, string bookname, int categoryid, int publishid, string author)
        {
            string query = string.Format("UPDATE dbo.Book SET BookName = N'{1}', CategoryID = {2}, PublishID = {3}, Author = N'{4}' WHERE ID = {0} ", id, bookname, categoryid, publishid, author);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBook(int id)
        {
            BillDAO.Instance.DeleteBillInfoByBookID(id);

            string query = string.Format("Delete dbo.Book where ID = '{0}'", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }


    }
}
