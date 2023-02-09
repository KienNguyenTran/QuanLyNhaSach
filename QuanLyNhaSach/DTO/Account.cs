using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Account
    {
        public Account(string userName, string displayName, int type, string passWord = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.PassWord = passWord;
        }
        public Account(DataRow row)
        {
            this.DisplayName=row["DisplayName"].ToString();
            this.UserName = row["userName"].ToString();
            this.Type = (int)row["Type"];
            this.PassWord = row["passWord"].ToString();
        }
        private string displayName;
        private int type;
        private string passWord;
        private string userName;

        public string UserName 
        { 
            get { return userName; } 
            set { userName = value;}
         }

        public string PassWord 
        {
            get { return passWord; }
            set { passWord = value;}
         }

        

        public string DisplayName 
        { 
            get { return displayName; }
            set { displayName = value;}
        }

        public int Type 
        {
            get { return type;}
            set { type = value;}
        }
    }
}
