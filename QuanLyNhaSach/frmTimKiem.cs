using QuanLyNhaSach.DAO;
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
    public partial class frmTimKiem : Form
    {
        BindingSource listFindBook = new BindingSource();
        public frmTimKiem()
        {
            InitializeComponent();
           
           
        }

        #region methods
        void LoadBook()
        {
            dgvFindBook.DataSource = listFindBook;
            LoadListBook();
        }

        void LoadListBook()
        {
            
            listFindBook.DataSource = BookDAO.Instance.LoadBookList();
        }

        List<Book> SearchBookByName(string bookname)
        {
            List<Book> listBook = BookDAO.Instance.SearchBookByName(bookname);
            return listBook;
        }

        List<Book> SearchBookByAuthor(string authorname)
        {
            List<Book> listBookA= BookDAO.Instance.SearchBookByAuthor(authorname);
            return listBookA;
        }

        #endregion

        #region events
        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadBook();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text != string.Empty)
            {
                listFindBook.DataSource = SearchBookByName(txtBookName.Text);
            }
            else
            {
                listFindBook.DataSource = SearchBookByAuthor(txtAuthor.Text);
            }
            
        }

        #endregion

       

       
    }
}
