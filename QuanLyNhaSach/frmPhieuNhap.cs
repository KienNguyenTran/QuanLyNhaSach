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
    public partial class frmPhieuNhap : Form
    {
        
        BindingSource listBook = new BindingSource();
        BindingSource listFillInfo = new BindingSource();
        BindingSource listFill = new BindingSource();
        public frmPhieuNhap()
        {
            
            InitializeComponent();
            LoadFill();
            LoadBookData();
            LoadFillInfo();
        }

        #region methods
        void LoadBookData()
        {
            dgvBookInfo.DataSource = listBook;
            LoadListBookData();
            AddBookDataBinding();
        }

        void LoadListBookData()
        {
            listBook.DataSource = BookDAO.Instance.LoadListBookInfo();
        }
        
        void LoadFillInfo()
        {
            lsvFillInfo.Items.Clear();
            List<FillInfo> listFillInfo = FillDAO.Instance.LoadFillInfoList();
            float totalPrice = 0;
            foreach (FillInfo item in listFillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Bookid.ToString());
                lsvItem.SubItems.Add(item.Bookname.ToString());
                lsvItem.SubItems.Add(item.Idphieunhap.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString());
                totalPrice += item.Totalprice;
                lsvFillInfo.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txtTPrice.Text = totalPrice.ToString("c",culture);
        }

        void LoadFill()
        {
            dgvFill.DataSource = FillDAO.Instance.LoadListFill();
           
        }
        
        void AddBookDataBinding()
        {
            txtBookID.DataBindings.Add(new Binding("Text", dgvBookInfo.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtBookName.DataBindings.Add(new Binding("Text", dgvBookInfo.DataSource, "BookName", true, DataSourceUpdateMode.Never));
        }

        void AddFillInfo(int id, string bookname, int idphieunhap, int quantity, int price)
        { 
            FillDAO.Instance.InsertFillInfo(id, bookname, idphieunhap, quantity, price);
        }

        
        void AddFill(int id)
        {
            FillDAO.Instance.AddListFill(id);
        }

        void DeleteFill(int id)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if(FillDAO.Instance.DeleteFill(id))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
                else
                {
                    MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }    
            else
            {
                return;
            }    
        }
        #endregion

        #region events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBookID.Text);
            string bookname = txtBookName.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int price = Convert.ToInt32(txtPrice.Text);
            int idphieu = int.Parse(txtFillID.Text);
            AddFillInfo(id, bookname, idphieu, quantity, price);
            LoadFillInfo();
        }

        private void btnAddFill_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFillID.Text);
            AddFill(id);
            LoadFill();
            

        }
        #endregion

        private void btnDeleteAB_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFillID.Text);
            DeleteFill(id);
            LoadFill();
        }
    }
}
