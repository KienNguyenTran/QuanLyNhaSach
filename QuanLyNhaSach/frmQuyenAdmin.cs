using QuanLyNhaSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmQuyenAdmin : Form
    {
        BindingSource listAccount = new BindingSource();
        public frmQuyenAdmin()
        {
            InitializeComponent();
            toolTip1.SetToolTip(nmAccountType, "1 là ADMIN, 0 là STAFF");

        }
        #region methods
        void Load()
        {
            dgvAccount.DataSource = listAccount;
            LoadAccount();
            addAccountBinding();

        }

        void addAccountBinding()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
            txtPass.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));

        }

        void LoadAccount()
        {
            listAccount.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccount(string username , string displayname, string password, int type)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm tài khoản mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (AccountDAO.Instance.InsertAccount(username, displayname, password, type))
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadAccount();
            }
            else
            {
                return;
            }
           
        }

        void EditAccount(string username, string displayname, string password, int type)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (AccountDAO.Instance.UpdateAccount(username, displayname, password, type))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadAccount();
            }
            else
            {
                return;
            }
        }

        void DeleteAccount(string username)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (AccountDAO.Instance.DeleteAccount(username))
                {
                    MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xoá tài khoản thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadAccount();
            }
            else
            {
                return ;
            }
        }
        #endregion

        #region Events
        private void btnView_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string displayname = txtDisplayName.Text;
            string password = txtPass.Text;
            int type = (int)nmAccountType.Value;
            AddAccount(username, displayname, password,type);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            DeleteAccount(username);
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string displayname = txtDisplayName.Text;
            string password = txtPass.Text;
            int type = (int)nmAccountType.Value;
            EditAccount(username, displayname, password, type);
        }
        #endregion


    }
}
