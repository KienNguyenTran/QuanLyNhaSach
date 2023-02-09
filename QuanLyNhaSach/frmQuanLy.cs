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
    public partial class frmQuanLy : Form
    {
        BindingSource listCategory = new BindingSource();
        BindingSource listPublish = new BindingSource();
        BindingSource listBook = new BindingSource();
        public frmQuanLy()
        {
            InitializeComponent();
            LoadCategory();
            LoadPublish();
            LoadCategoryIntoCombobox(cbCategory);
            LoadPublishIntoCombobox(cbPublish);
            LoadBook();
        }

        #region methods
        void LoadCategory()
        {
            dgvCategory.DataSource = listCategory;
            LoadListCategory();
            AddCategoryBinding();
        }

        void LoadPublish()
        {
            dgvPublish.DataSource = listPublish;
            LoadListPublish();
            AddPublishBinding();
        }
        void LoadBook()
        {
            dgvBook.DataSource = listBook;
            LoadListBook();
            AddBookBinding();
        }

        void AddCategoryBinding()
        {
            txtCateID.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "CategoryName", true, DataSourceUpdateMode.Never));
        }
        void AddPublishBinding()
        {
            txtPublishID.DataBindings.Add(new Binding("Text", dgvPublish.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtPublishName.DataBindings.Add(new Binding("Text", dgvPublish.DataSource, "PublishName", true, DataSourceUpdateMode.Never));
        }
        
        void AddBookBinding()
        {
            txtBookID.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtBookName.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "BookName", true, DataSourceUpdateMode.Never));
            txtAuthor.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "Author", true, DataSourceUpdateMode.Never));
            txtCategoryID.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));
            txtPublishingID.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "PublishID", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.LoadCategoryList();
            cb.DisplayMember = "CategoryName";
        }

        void LoadPublishIntoCombobox(ComboBox cb)
        {
            cb.DataSource= PublishDAO.Instance.LoadPublishList();
            cb.DisplayMember = "PublishName";
        }
        void LoadListPublish()
        {
            listPublish.DataSource = PublishDAO.Instance.LoadPublishList();
        }
        void LoadListCategory()
        {
            listCategory.DataSource = CategoryDAO.Instance.LoadCategoryList();
        }
        
        void LoadListBook()
        {
            listBook.DataSource = BookDAO.Instance.LoadBookList();
        }



        void AddCategory(int id, string categoryname)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm thể loại mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (CategoryDAO.Instance.InsertCategory(id, categoryname))
                {
                    MessageBox.Show("Thêm thể loại mới thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm thể loại mới thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListCategory();
            }
            else
            {
                return;
            }
                
        }
        
        void EditCategory(int id, string categoryname)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin thể loại này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (CategoryDAO.Instance.UpdateCategory(id, categoryname))
                {
                    MessageBox.Show("Cập nhật thể loại thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật thể loại thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListCategory();
            }
            else
            {
                return;
            }
        }

        void DeleteCategory(int id)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá thể loại này không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (CategoryDAO.Instance.DeleteCategory(id))
                {
                    MessageBox.Show("Xoá thể loại thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xoá thể loại thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListCategory();
            }
            else
            {
                return;
            }
        }

        void AddPublish(int id, string publishname)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm nhà xuất bản mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PublishDAO.Instance.InsertPublish(id, publishname))
                {
                    MessageBox.Show("Thêm nhà xuất bản mới thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm nhà xuất bản mới thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListPublish();
            }
            else
            {
                return;
            }
        }

        void EditPublish(int id, string publishname)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin nhà xuất bản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PublishDAO.Instance.UpdatePublish(id, publishname))
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListPublish();
            }
            else
            {
                return;
            }
        }

        void DeletePublish(int id)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá nhà xuất bản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PublishDAO.Instance.DeletePublish(id))
                {
                    MessageBox.Show("Xoá nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xoá nhà xuất bản thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListPublish();
            }
            else
            {
                return;
            }
        }

        void AddBook(int id, string bookname, int categoryid, int publishid, string author)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm sách mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BookDAO.Instance.InsertBook(id, bookname,categoryid,publishid,author))
                {
                    MessageBox.Show("Thêm sách mới thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm sách mới thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListBook();
            }
            else
            {
                return;
            }

        }

        void EditBook(int id, string bookname, int categoryid, int publishid, string author)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BookDAO.Instance.UpdateBook(id, bookname,categoryid,publishid,author))
                {
                    MessageBox.Show("Cập nhật sách thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật sách thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListBook();
            }
            else
            {
                return;
            }
        }

        void DeleteBook(int id)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (BookDAO.Instance.DeleteBook(id))
                {
                    MessageBox.Show("Xoá sách thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xoá sách thất bại", "Thông báo", MessageBoxButtons.OK);
                }
                LoadListBook();
            }
            else
            {
                return;
            }
        }
        #endregion
        #region events
        private void btnCateInsert_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtCateID.Text);
            string CategoryName = txtCategoryName.Text;
            AddCategory(Id, CategoryName);
        }

        private void btnCateUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtCateID.Text);
            string CategoryName = txtCategoryName.Text;
            EditCategory(Id, CategoryName);
        }

        private void btnCateDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtCateID.Text);
            DeleteCategory(Id);
        }
        private void btnPublishSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPublishID.Text);
            string publishname = txtPublishName.Text;
            AddPublish(id, publishname);

        }

        private void btnPublishUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPublishID.Text);
            string publishname = txtPublishName.Text;
            EditPublish(id, publishname);
        }

        private void btnPublishDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPublishID.Text);
            DeletePublish(id);
        }
        
        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBook.SelectedCells.Count > 0)
                {
                    int id = (int)dgvBook.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCategory.Items)
                    {
                        if (item.Id == cateogory.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbCategory.SelectedIndex = index;
                }
            }
            catch { }
        }
        private void txtPublishingID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBook.SelectedCells.Count > 0)
                {
                    int id = (int)dgvBook.SelectedCells[0].OwningRow.Cells["PublishID"].Value;

                    Publish publish = PublishDAO.Instance.GetPublishByID(id);

                    cbPublish.SelectedItem = publish;

                    int index = -1;
                    int i = 0;
                    foreach (Publish item in cbPublish.Items)
                    {
                        if (item.Id == publish.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbPublish.SelectedIndex = index;
                }
            } catch { }
        }

        private void btnBookSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookID.Text);
            string bookname = txtBookName.Text;
            string author = txtAuthor.Text;
            int categoryid = (cbCategory.SelectedItem as Category).Id;
            int publishid = (cbPublish.SelectedItem as Publish).Id;
            AddBook(id, bookname, categoryid, publishid, author);
        }
        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookID.Text);
            DeleteBook(id);
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookID.Text);
            string bookname = txtBookName.Text;
            string author = txtAuthor.Text;
            int categoryid = (cbCategory.SelectedItem as Category).Id;
            int publishid = (cbPublish.SelectedItem as Publish).Id;
            EditBook(id, bookname, categoryid, publishid, author);
        }
        #endregion


    }
}
