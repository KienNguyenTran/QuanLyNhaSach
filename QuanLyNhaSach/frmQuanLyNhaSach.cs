using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmQuanLyNhaSach : Form
    {
        private Account loginAccount;

        public Account LoginAccount 
        { 
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public frmQuanLyNhaSach(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        void ChangeAccount (int type)
        {
            btnAdmin.Enabled = type == 1;
            btnAddBook.Enabled = type == 1;
            lbName.Text = " Xin chào (" + LoginAccount.DisplayName + ")";
        }
        

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmQuyenAdmin f = new frmQuyenAdmin();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmTimKiem f= new frmTimKiem();
            f.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmQuanLy f = new frmQuanLy();
            f.ShowDialog();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmPhieuNhap f = new frmPhieuNhap();
            f.ShowDialog();    
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            f.ShowDialog();
        }
    }
}
