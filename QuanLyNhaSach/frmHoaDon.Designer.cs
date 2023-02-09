namespace QuanLyNhaSach
{
    partial class frmHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvInfoBill = new System.Windows.Forms.ListView();
            this.clIDBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clIDBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBillInfo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbBillID = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.txtTPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsvBillInfo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvInfoBill);
            this.panel1.Location = new System.Drawing.Point(4, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 280);
            this.panel1.TabIndex = 0;
            // 
            // lsvInfoBill
            // 
            this.lsvInfoBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIDBook,
            this.clBookName,
            this.clIDBill,
            this.clQuantity,
            this.clPrice,
            this.clTotalPrice});
            this.lsvInfoBill.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvInfoBill.HideSelection = false;
            this.lsvInfoBill.Location = new System.Drawing.Point(4, 4);
            this.lsvInfoBill.Name = "lsvInfoBill";
            this.lsvInfoBill.Size = new System.Drawing.Size(735, 276);
            this.lsvInfoBill.TabIndex = 0;
            this.lsvInfoBill.UseCompatibleStateImageBehavior = false;
            this.lsvInfoBill.View = System.Windows.Forms.View.Details;
            // 
            // clIDBook
            // 
            this.clIDBook.Text = "Mã sách";
            this.clIDBook.Width = 100;
            // 
            // clBookName
            // 
            this.clBookName.Text = "Tên sách";
            this.clBookName.Width = 113;
            // 
            // clIDBill
            // 
            this.clIDBill.Text = "Mã hoá đơn";
            this.clIDBill.Width = 116;
            // 
            // clQuantity
            // 
            this.clQuantity.Text = "Số lượng";
            this.clQuantity.Width = 115;
            // 
            // clPrice
            // 
            this.clPrice.Text = "Giá";
            this.clPrice.Width = 61;
            // 
            // clTotalPrice
            // 
            this.clTotalPrice.Text = "Thành tiền";
            this.clTotalPrice.Width = 131;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBillInfo);
            this.panel2.Location = new System.Drawing.Point(687, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 265);
            this.panel2.TabIndex = 1;
            // 
            // lsvBillInfo
            // 
            this.lsvBillInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lsvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lsvBillInfo.Location = new System.Drawing.Point(3, 3);
            this.lsvBillInfo.Name = "lsvBillInfo";
            this.lsvBillInfo.RowHeadersWidth = 62;
            this.lsvBillInfo.RowTemplate.Height = 28;
            this.lsvBillInfo.Size = new System.Drawing.Size(516, 259);
            this.lsvBillInfo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBill);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 209);
            this.panel3.TabIndex = 2;
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(8, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 62;
            this.dgvBill.RowTemplate.Height = 28;
            this.dgvBill.Size = new System.Drawing.Size(666, 203);
            this.dgvBill.TabIndex = 2;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(753, 400);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(84, 23);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Text = "Số lượng";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(752, 452);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(100, 23);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Thành tiền";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(869, 392);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(331, 30);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(869, 448);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(331, 26);
            this.txtPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1052, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm sách";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReceipt.Location = new System.Drawing.Point(549, 218);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(129, 49);
            this.btnAddReceipt.TabIndex = 8;
            this.btnAddReceipt.Text = "Thêm HĐ";
            this.btnAddReceipt.UseVisualStyleBackColor = true;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 49);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(753, 350);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(84, 23);
            this.lbBookName.TabIndex = 11;
            this.lbBookName.Text = "Tên sách";
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookID.Location = new System.Drawing.Point(752, 303);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(80, 23);
            this.lbBookID.TabIndex = 12;
            this.lbBookID.Text = "Mã sách";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(869, 300);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(331, 30);
            this.txtBookID.TabIndex = 13;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(869, 347);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(331, 30);
            this.txtBookName.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbBillID);
            this.panel4.Controls.Add(this.txtBillID);
            this.panel4.Location = new System.Drawing.Point(343, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 48);
            this.panel4.TabIndex = 26;
            // 
            // lbBillID
            // 
            this.lbBillID.AutoSize = true;
            this.lbBillID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillID.Location = new System.Drawing.Point(13, 13);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(68, 20);
            this.lbBillID.TabIndex = 23;
            this.lbBillID.Text = "Mã HĐ:";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(87, 10);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(100, 26);
            this.txtBillID.TabIndex = 24;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(755, 485);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(97, 23);
            this.lbTotalPrice.TabIndex = 27;
            this.lbTotalPrice.Text = "Tổng tiền:";
            // 
            // txtTPrice
            // 
            this.txtTPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPrice.Location = new System.Drawing.Point(759, 514);
            this.txtTPrice.Name = "txtTPrice";
            this.txtTPrice.ReadOnly = true;
            this.txtTPrice.Size = new System.Drawing.Size(201, 30);
            this.txtTPrice.TabIndex = 28;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1212, 562);
            this.Controls.Add(this.txtTPrice);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lbBookID);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddReceipt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lsvBillInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView lsvBillInfo;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbBillID;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox txtTPrice;
        private System.Windows.Forms.ListView lsvInfoBill;
        private System.Windows.Forms.ColumnHeader clIDBook;
        private System.Windows.Forms.ColumnHeader clBookName;
        private System.Windows.Forms.ColumnHeader clIDBill;
        private System.Windows.Forms.ColumnHeader clQuantity;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clTotalPrice;
    }
}