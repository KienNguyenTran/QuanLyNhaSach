namespace QuanLyNhaSach
{
    partial class frmQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcManage = new System.Windows.Forms.TabControl();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lbCateList = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCateUpdate = new System.Windows.Forms.Button();
            this.btnCateDelete = new System.Windows.Forms.Button();
            this.btnCateInsert = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.tpPublish = new System.Windows.Forms.TabPage();
            this.txtPublishName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPublish = new System.Windows.Forms.DataGridView();
            this.lbPublishList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPublishDelete = new System.Windows.Forms.Button();
            this.btnPublishUpdate = new System.Windows.Forms.Button();
            this.btnPublishSave = new System.Windows.Forms.Button();
            this.txtPublishID = new System.Windows.Forms.TextBox();
            this.lbPublishName = new System.Windows.Forms.Label();
            this.lbPublishID = new System.Windows.Forms.Label();
            this.tpBook = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lbBookList = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBookEdit = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPublishingID = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lbPublishingID = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.cbPublish = new System.Windows.Forms.ComboBox();
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbBookPublish = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbBookCate = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.tcManage.SuspendLayout();
            this.tpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpPublish.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublish)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpBook.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManage
            // 
            this.tcManage.Controls.Add(this.tpCategory);
            this.tcManage.Controls.Add(this.tpPublish);
            this.tcManage.Controls.Add(this.tpBook);
            this.tcManage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManage.Location = new System.Drawing.Point(1, 2);
            this.tcManage.Name = "tcManage";
            this.tcManage.SelectedIndex = 0;
            this.tcManage.Size = new System.Drawing.Size(991, 517);
            this.tcManage.TabIndex = 0;
            // 
            // tpCategory
            // 
            this.tpCategory.BackColor = System.Drawing.Color.Lavender;
            this.tpCategory.Controls.Add(this.txtCategoryName);
            this.tpCategory.Controls.Add(this.lbCateList);
            this.tpCategory.Controls.Add(this.dgvCategory);
            this.tpCategory.Controls.Add(this.panel1);
            this.tpCategory.Controls.Add(this.lbName);
            this.tpCategory.Controls.Add(this.txtCateID);
            this.tpCategory.Controls.Add(this.lbID);
            this.tpCategory.ForeColor = System.Drawing.Color.Navy;
            this.tpCategory.Location = new System.Drawing.Point(4, 32);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(983, 481);
            this.tpCategory.TabIndex = 0;
            this.tpCategory.Text = "Thể loại";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(129, 79);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(268, 30);
            this.txtCategoryName.TabIndex = 7;
            // 
            // lbCateList
            // 
            this.lbCateList.AutoSize = true;
            this.lbCateList.ForeColor = System.Drawing.Color.Navy;
            this.lbCateList.Location = new System.Drawing.Point(456, 7);
            this.lbCateList.Name = "lbCateList";
            this.lbCateList.Size = new System.Drawing.Size(163, 23);
            this.lbCateList.TabIndex = 6;
            this.lbCateList.Text = "Danh sách thể loại";
            // 
            // dgvCategory
            // 
            this.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(456, 37);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.RowTemplate.Height = 28;
            this.dgvCategory.Size = new System.Drawing.Size(521, 438);
            this.dgvCategory.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCateUpdate);
            this.panel1.Controls.Add(this.btnCateDelete);
            this.panel1.Controls.Add(this.btnCateInsert);
            this.panel1.Location = new System.Drawing.Point(11, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 291);
            this.panel1.TabIndex = 4;
            // 
            // btnCateUpdate
            // 
            this.btnCateUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnCateUpdate.Location = new System.Drawing.Point(83, 118);
            this.btnCateUpdate.Name = "btnCateUpdate";
            this.btnCateUpdate.Size = new System.Drawing.Size(134, 49);
            this.btnCateUpdate.TabIndex = 2;
            this.btnCateUpdate.Text = "Sửa";
            this.btnCateUpdate.UseVisualStyleBackColor = true;
            this.btnCateUpdate.Click += new System.EventHandler(this.btnCateUpdate_Click);
            // 
            // btnCateDelete
            // 
            this.btnCateDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnCateDelete.Location = new System.Drawing.Point(83, 195);
            this.btnCateDelete.Name = "btnCateDelete";
            this.btnCateDelete.Size = new System.Drawing.Size(135, 48);
            this.btnCateDelete.TabIndex = 1;
            this.btnCateDelete.Text = "Xoá";
            this.btnCateDelete.UseVisualStyleBackColor = true;
            this.btnCateDelete.Click += new System.EventHandler(this.btnCateDelete_Click);
            // 
            // btnCateInsert
            // 
            this.btnCateInsert.ForeColor = System.Drawing.Color.Navy;
            this.btnCateInsert.Location = new System.Drawing.Point(83, 41);
            this.btnCateInsert.Name = "btnCateInsert";
            this.btnCateInsert.Size = new System.Drawing.Size(134, 50);
            this.btnCateInsert.TabIndex = 0;
            this.btnCateInsert.Text = "Thêm";
            this.btnCateInsert.UseVisualStyleBackColor = true;
            this.btnCateInsert.Click += new System.EventHandler(this.btnCateInsert_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Navy;
            this.lbName.Location = new System.Drawing.Point(7, 79);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 23);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Thể loại";
            // 
            // txtCateID
            // 
            this.txtCateID.Location = new System.Drawing.Point(129, 18);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.Size = new System.Drawing.Size(268, 30);
            this.txtCateID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.Color.Navy;
            this.lbID.Location = new System.Drawing.Point(7, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(105, 23);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã thể loại";
            // 
            // tpPublish
            // 
            this.tpPublish.BackColor = System.Drawing.Color.Lavender;
            this.tpPublish.Controls.Add(this.txtPublishName);
            this.tpPublish.Controls.Add(this.panel3);
            this.tpPublish.Controls.Add(this.panel2);
            this.tpPublish.Controls.Add(this.txtPublishID);
            this.tpPublish.Controls.Add(this.lbPublishName);
            this.tpPublish.Controls.Add(this.lbPublishID);
            this.tpPublish.ForeColor = System.Drawing.Color.Navy;
            this.tpPublish.Location = new System.Drawing.Point(4, 32);
            this.tpPublish.Name = "tpPublish";
            this.tpPublish.Padding = new System.Windows.Forms.Padding(3);
            this.tpPublish.Size = new System.Drawing.Size(983, 481);
            this.tpPublish.TabIndex = 1;
            this.tpPublish.Text = "Nhà xuất bản";
            // 
            // txtPublishName
            // 
            this.txtPublishName.Location = new System.Drawing.Point(126, 91);
            this.txtPublishName.Name = "txtPublishName";
            this.txtPublishName.Size = new System.Drawing.Size(278, 30);
            this.txtPublishName.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPublish);
            this.panel3.Controls.Add(this.lbPublishList);
            this.panel3.Location = new System.Drawing.Point(6, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 322);
            this.panel3.TabIndex = 8;
            // 
            // dgvPublish
            // 
            this.dgvPublish.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPublish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublish.Location = new System.Drawing.Point(3, 30);
            this.dgvPublish.Name = "dgvPublish";
            this.dgvPublish.RowHeadersWidth = 62;
            this.dgvPublish.RowTemplate.Height = 28;
            this.dgvPublish.Size = new System.Drawing.Size(965, 289);
            this.dgvPublish.TabIndex = 1;
            // 
            // lbPublishList
            // 
            this.lbPublishList.AutoSize = true;
            this.lbPublishList.Location = new System.Drawing.Point(3, 0);
            this.lbPublishList.Name = "lbPublishList";
            this.lbPublishList.Size = new System.Drawing.Size(141, 23);
            this.lbPublishList.TabIndex = 0;
            this.lbPublishList.Text = "Danh sách NXB";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPublishDelete);
            this.panel2.Controls.Add(this.btnPublishUpdate);
            this.panel2.Controls.Add(this.btnPublishSave);
            this.panel2.Location = new System.Drawing.Point(596, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 136);
            this.panel2.TabIndex = 7;
            // 
            // btnPublishDelete
            // 
            this.btnPublishDelete.Location = new System.Drawing.Point(117, 70);
            this.btnPublishDelete.Name = "btnPublishDelete";
            this.btnPublishDelete.Size = new System.Drawing.Size(135, 48);
            this.btnPublishDelete.TabIndex = 4;
            this.btnPublishDelete.Text = "Xoá";
            this.btnPublishDelete.UseVisualStyleBackColor = true;
            this.btnPublishDelete.Click += new System.EventHandler(this.btnPublishDelete_Click);
            // 
            // btnPublishUpdate
            // 
            this.btnPublishUpdate.Location = new System.Drawing.Point(198, 15);
            this.btnPublishUpdate.Name = "btnPublishUpdate";
            this.btnPublishUpdate.Size = new System.Drawing.Size(134, 49);
            this.btnPublishUpdate.TabIndex = 3;
            this.btnPublishUpdate.Text = "Sửa";
            this.btnPublishUpdate.UseVisualStyleBackColor = true;
            this.btnPublishUpdate.Click += new System.EventHandler(this.btnPublishUpdate_Click);
            // 
            // btnPublishSave
            // 
            this.btnPublishSave.Location = new System.Drawing.Point(24, 14);
            this.btnPublishSave.Name = "btnPublishSave";
            this.btnPublishSave.Size = new System.Drawing.Size(134, 50);
            this.btnPublishSave.TabIndex = 1;
            this.btnPublishSave.Text = "Thêm";
            this.btnPublishSave.UseVisualStyleBackColor = true;
            this.btnPublishSave.Click += new System.EventHandler(this.btnPublishSave_Click);
            // 
            // txtPublishID
            // 
            this.txtPublishID.Location = new System.Drawing.Point(126, 36);
            this.txtPublishID.Name = "txtPublishID";
            this.txtPublishID.Size = new System.Drawing.Size(278, 30);
            this.txtPublishID.TabIndex = 4;
            // 
            // lbPublishName
            // 
            this.lbPublishName.AutoSize = true;
            this.lbPublishName.ForeColor = System.Drawing.Color.Navy;
            this.lbPublishName.Location = new System.Drawing.Point(7, 94);
            this.lbPublishName.Name = "lbPublishName";
            this.lbPublishName.Size = new System.Drawing.Size(87, 23);
            this.lbPublishName.TabIndex = 2;
            this.lbPublishName.Text = "Tên NXB";
            // 
            // lbPublishID
            // 
            this.lbPublishID.AutoSize = true;
            this.lbPublishID.ForeColor = System.Drawing.Color.Navy;
            this.lbPublishID.Location = new System.Drawing.Point(7, 39);
            this.lbPublishID.Name = "lbPublishID";
            this.lbPublishID.Size = new System.Drawing.Size(83, 23);
            this.lbPublishID.TabIndex = 1;
            this.lbPublishID.Text = "Mã NXB";
            // 
            // tpBook
            // 
            this.tpBook.BackColor = System.Drawing.Color.Lavender;
            this.tpBook.Controls.Add(this.panel6);
            this.tpBook.Controls.Add(this.panel5);
            this.tpBook.Controls.Add(this.panel4);
            this.tpBook.ForeColor = System.Drawing.Color.Navy;
            this.tpBook.Location = new System.Drawing.Point(4, 32);
            this.tpBook.Name = "tpBook";
            this.tpBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpBook.Size = new System.Drawing.Size(983, 481);
            this.tpBook.TabIndex = 2;
            this.tpBook.Text = "Sách";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Lavender;
            this.panel6.Controls.Add(this.dgvBook);
            this.panel6.Controls.Add(this.lbBookList);
            this.panel6.Location = new System.Drawing.Point(4, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(973, 279);
            this.panel6.TabIndex = 11;
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(3, 31);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 62;
            this.dgvBook.RowTemplate.Height = 28;
            this.dgvBook.Size = new System.Drawing.Size(963, 248);
            this.dgvBook.TabIndex = 1;
            // 
            // lbBookList
            // 
            this.lbBookList.AutoSize = true;
            this.lbBookList.Location = new System.Drawing.Point(4, 4);
            this.lbBookList.Name = "lbBookList";
            this.lbBookList.Size = new System.Drawing.Size(138, 23);
            this.lbBookList.TabIndex = 0;
            this.lbBookList.Text = "Danh sách sách";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Controls.Add(this.btnBookEdit);
            this.panel5.Controls.Add(this.btnBookDelete);
            this.panel5.Controls.Add(this.btnBookSave);
            this.panel5.Location = new System.Drawing.Point(850, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 185);
            this.panel5.TabIndex = 10;
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.Location = new System.Drawing.Point(22, 125);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.Size = new System.Drawing.Size(79, 35);
            this.btnBookEdit.TabIndex = 6;
            this.btnBookEdit.Text = "Sửa";
            this.btnBookEdit.UseVisualStyleBackColor = true;
            this.btnBookEdit.Click += new System.EventHandler(this.btnBookEdit_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(22, 65);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(79, 36);
            this.btnBookDelete.TabIndex = 5;
            this.btnBookDelete.Text = "Xoá";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnBookSave
            // 
            this.btnBookSave.Location = new System.Drawing.Point(22, 10);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(79, 36);
            this.btnBookSave.TabIndex = 2;
            this.btnBookSave.Text = "Thêm";
            this.btnBookSave.UseVisualStyleBackColor = true;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.txtPublishingID);
            this.panel4.Controls.Add(this.txtCategoryID);
            this.panel4.Controls.Add(this.lbPublishingID);
            this.panel4.Controls.Add(this.lbCategoryID);
            this.panel4.Controls.Add(this.cbPublish);
            this.panel4.Controls.Add(this.lbBookID);
            this.panel4.Controls.Add(this.lbBookPublish);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Controls.Add(this.txtBookID);
            this.panel4.Controls.Add(this.txtAuthor);
            this.panel4.Controls.Add(this.lbBookCate);
            this.panel4.Controls.Add(this.txtBookName);
            this.panel4.Controls.Add(this.lbBookName);
            this.panel4.Controls.Add(this.lbAuthor);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 185);
            this.panel4.TabIndex = 9;
            // 
            // txtPublishingID
            // 
            this.txtPublishingID.Location = new System.Drawing.Point(594, 52);
            this.txtPublishingID.Name = "txtPublishingID";
            this.txtPublishingID.ReadOnly = true;
            this.txtPublishingID.Size = new System.Drawing.Size(216, 30);
            this.txtPublishingID.TabIndex = 13;
            this.txtPublishingID.TextChanged += new System.EventHandler(this.txtPublishingID_TextChanged);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(594, 10);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(216, 30);
            this.txtCategoryID.TabIndex = 12;
            this.txtCategoryID.TextChanged += new System.EventHandler(this.txtCategoryID_TextChanged);
            // 
            // lbPublishingID
            // 
            this.lbPublishingID.AutoSize = true;
            this.lbPublishingID.Location = new System.Drawing.Point(481, 52);
            this.lbPublishingID.Name = "lbPublishingID";
            this.lbPublishingID.Size = new System.Drawing.Size(101, 23);
            this.lbPublishingID.TabIndex = 11;
            this.lbPublishingID.Text = "ID Nhà XB";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(481, 13);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(104, 23);
            this.lbCategoryID.TabIndex = 10;
            this.lbCategoryID.Text = "ID Thể loại";
            // 
            // cbPublish
            // 
            this.cbPublish.FormattingEnabled = true;
            this.cbPublish.Location = new System.Drawing.Point(594, 137);
            this.cbPublish.Name = "cbPublish";
            this.cbPublish.Size = new System.Drawing.Size(233, 31);
            this.cbPublish.TabIndex = 9;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Location = new System.Drawing.Point(3, 10);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(80, 23);
            this.lbBookID.TabIndex = 0;
            this.lbBookID.Text = "Mã sách";
            // 
            // lbBookPublish
            // 
            this.lbBookPublish.AutoSize = true;
            this.lbBookPublish.Location = new System.Drawing.Point(484, 141);
            this.lbBookPublish.Name = "lbBookPublish";
            this.lbBookPublish.Size = new System.Drawing.Size(75, 23);
            this.lbBookPublish.TabIndex = 4;
            this.lbBookPublish.Text = "Nhà XB";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(594, 94);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(233, 31);
            this.cbCategory.TabIndex = 8;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(103, 10);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(328, 30);
            this.txtBookID.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(103, 134);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(328, 30);
            this.txtAuthor.TabIndex = 5;
            // 
            // lbBookCate
            // 
            this.lbBookCate.AutoSize = true;
            this.lbBookCate.Location = new System.Drawing.Point(481, 97);
            this.lbBookCate.Name = "lbBookCate";
            this.lbBookCate.Size = new System.Drawing.Size(78, 23);
            this.lbBookCate.TabIndex = 3;
            this.lbBookCate.Text = "Thể loại";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(103, 71);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(328, 30);
            this.txtBookName.TabIndex = 6;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(3, 72);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(84, 23);
            this.lbBookName.TabIndex = 1;
            this.lbBookName.Text = "Tên sách";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(11, 137);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(72, 23);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "Tác giả";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 521);
            this.Controls.Add(this.tcManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.tcManage.ResumeLayout(false);
            this.tpCategory.ResumeLayout(false);
            this.tpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpPublish.ResumeLayout(false);
            this.tpPublish.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublish)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tpBook.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManage;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpPublish;
        private System.Windows.Forms.TabPage tpBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCateUpdate;
        private System.Windows.Forms.Button btnCateDelete;
        private System.Windows.Forms.Button btnCateInsert;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label lbCateList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPublishSave;
        private System.Windows.Forms.TextBox txtPublishID;
        private System.Windows.Forms.Label lbPublishName;
        private System.Windows.Forms.Label lbPublishID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPublishList;
        private System.Windows.Forms.Button btnPublishDelete;
        private System.Windows.Forms.Button btnPublishUpdate;
        private System.Windows.Forms.DataGridView dgvPublish;
        private System.Windows.Forms.Label lbBookPublish;
        private System.Windows.Forms.Label lbBookCate;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPublish;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Button btnBookEdit;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lbBookList;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtPublishName;
        private System.Windows.Forms.TextBox txtPublishingID;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lbPublishingID;
        private System.Windows.Forms.Label lbCategoryID;
    }
}