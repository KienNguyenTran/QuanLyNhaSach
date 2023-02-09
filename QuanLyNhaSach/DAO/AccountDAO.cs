using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance { 
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] {userName, passWord});
            return result.Rows.Count > 0;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("Select * from dbo.Account");
        }
        public Account GetAccoutByUserName (string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.Account where Username = '" + userName+ "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);

            }
            return null;
        }
        public bool InsertAccount (string username, string displayname, string password, int type)
        {
            string query = string.Format("INSERT into dbo.Account (Username, DisplayName, Password, Type) VALUES (N'{0}', N'{1}', {2}, {3})", username, displayname, password, type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        
        public bool UpdateAccount (string username, string displayname, string password, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}',Password = {2}, Type = {3} where Username = N'{0}' ", username, displayname, password, type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount (string username)
        {
            string query = string.Format("Delete dbo.Account where Username = N'{0}'", username);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
