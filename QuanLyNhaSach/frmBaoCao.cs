using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        void LoadReportList(DateTime date)
        {
            lsvReport.Items.Clear();
            List<Report> listReport = ReportDAO.Instance.LoadReport(date);
            float revenue = 0;
            foreach (Report item in listReport)
            {
                ListViewItem lsvItem = new ListViewItem(item.Bookid.ToString());
                lsvItem.SubItems.Add(item.Bookname.ToString());
                lsvItem.SubItems.Add(item.Inprice.ToString());
                lsvItem.SubItems.Add(item.Outprice.ToString());
                lsvItem.SubItems.Add(item.Outquantity.ToString());
                lsvItem.SubItems.Add(item.Date.ToString());
                lsvItem.SubItems.Add(item.Revenue.ToString());
                revenue += item.Revenue;
                lsvReport.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txtRevenue.Text = revenue.ToString("c", culture);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DateTime date = dtpReport.Value;
            LoadReportList(date.Date);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
