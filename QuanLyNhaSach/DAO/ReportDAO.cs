using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class ReportDAO
    {
        private static ReportDAO instance;

        public static ReportDAO Instance 
        {
            get { if(instance == null) ReportDAO.Instance = new ReportDAO(); return instance; }
            set { ReportDAO.instance = value; }
        }

        private ReportDAO() { }

        public List<Report> LoadReport(DateTime date)
        {
            List<Report> list = new List<Report>();
            string query = "USP_GetReport @date";
            DataTable data = DataProvider.Instance.ExcuteQuery(query,new object[] {date});
            foreach (DataRow item in data.Rows)
            {
                Report re = new Report(item);
                list.Add(re);
            }
            return list;
        }
    }
}
