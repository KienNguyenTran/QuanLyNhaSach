using QuanLyNhaSach.DAO;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmHoaDon : Form
    {
        BindingSource listBook = new BindingSource();
        public frmHoaDon()
        {
            InitializeComponent();
            LoadBillList();
            LoadBookData();
            LoadBillInfo();
        }
        #region methods
        void LoadBookData()
        {
            lsvBillInfo.DataSource = listBook;
            LoadListBookData();
            AddBookDataBinding();
        }

        void LoadBillList()
        {
            dgvBill.DataSource = BillDAO.Instance.LoadBillList();
        }
        void LoadListBookData()
        {
            listBook.DataSource = BookDAO.Instance.LoadListBookInfo();
        }

        void AddBookDataBinding()
        {
            txtBookID.DataBindings.Add(new Binding("Text", lsvBillInfo.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtBookName.DataBindings.Add(new Binding("Text", lsvBillInfo.DataSource, "BookName", true, DataSourceUpdateMode.Never));
        }
        void AddBill(int id)
        {
            BillDAO.Instance.AddListBill(id);
        }

        void DeleteBill(int id)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá hoá đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if(BillDAO.Instance.DeleteBill(id))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }   
            else
            {
                return;
            }    
        }

        void LoadBillInfo()
        {
            lsvInfoBill.Items.Clear();
            List<BillInfo> listBillInfo = BillDAO.Instance.LoadBillInfoList();
            float totalPrice = 0;
            foreach (BillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Bookid.ToString());
                lsvItem.SubItems.Add(item.Bookname.ToString());
                lsvItem.SubItems.Add(item.Idbill.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString());
                totalPrice += item.Totalprice;
                lsvInfoBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txtTPrice.Text = totalPrice.ToString("c", culture);
        }
        void AddBillInfo(int id, string bookname, int idbill, int quantity, int price)
        {
            BillDAO.Instance.InsertBillInfo(id, bookname, idbill, quantity, price);

        }
        #endregion
        #region events
        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillID.Text);
            AddBill(id);
            LoadBillList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillID.Text);
            DeleteBill(id);
            LoadBillList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBookID.Text);
            string bookname = txtBookName.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int price = Convert.ToInt32(txtPrice.Text);
            int idbill = Convert.ToInt32(txtBillID.Text);
            AddBillInfo(id, bookname, idbill, quantity, price);
            LoadBillInfo();
        }
        #endregion


    }
}
