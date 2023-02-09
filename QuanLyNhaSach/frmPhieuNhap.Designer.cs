namespace QuanLyNhaSach
{
    partial class frmPhieuNhap
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
            this.dgvFill = new System.Windows.Forms.DataGridView();
            this.txtTotalPrice = new System.Windows.Forms.Panel();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.btnDeleteAB = new System.Windows.Forms.Button();
            this.btnAddFill = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvFillInfo = new System.Windows.Forms.ListView();
            this.clBookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clIDFill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbFillinID = new System.Windows.Forms.Label();
            this.txtFillID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.txtTPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFill)).BeginInit();
            this.txtTotalPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFill);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 299);
            this.panel1.TabIndex = 0;
            // 
            // dgvFill
            // 
            this.dgvFill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFill.Location = new System.Drawing.Point(3, 3);
            this.dgvFill.Name = "dgvFill";
            this.dgvFill.RowHeadersWidth = 62;
            this.dgvFill.RowTemplate.Height = 28;
            this.dgvFill.Size = new System.Drawing.Size(611, 293);
            this.dgvFill.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Controls.Add(this.dgvBookInfo);
            this.txtTotalPrice.Location = new System.Drawing.Point(626, 1);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(429, 357);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.RowHeadersWidth = 62;
            this.dgvBookInfo.RowTemplate.Height = 28;
            this.dgvBookInfo.Size = new System.Drawing.Size(417, 351);
            this.dgvBookInfo.TabIndex = 0;
            // 
            // btnDeleteAB
            // 
            this.btnDeleteAB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAB.Location = new System.Drawing.Point(12, 306);
            this.btnDeleteAB.Name = "btnDeleteAB";
            this.btnDeleteAB.Size = new System.Drawing.Size(75, 49);
            this.btnDeleteAB.TabIndex = 11;
            this.btnDeleteAB.Text = "Xoá";
            this.btnDeleteAB.UseVisualStyleBackColor = true;
            this.btnDeleteAB.Click += new System.EventHandler(this.btnDeleteAB_Click);
            // 
            // btnAddFill
            // 
            this.btnAddFill.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFill.Location = new System.Drawing.Point(436, 306);
            this.btnAddFill.Name = "btnAddFill";
            this.btnAddFill.Size = new System.Drawing.Size(180, 49);
            this.btnAddFill.TabIndex = 12;
            this.btnAddFill.Text = "Thêm phiếu nhập";
            this.btnAddFill.UseVisualStyleBackColor = true;
            this.btnAddFill.Click += new System.EventHandler(this.btnAddFill_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvFillInfo);
            this.panel3.Location = new System.Drawing.Point(2, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 273);
            this.panel3.TabIndex = 14;
            // 
            // lsvFillInfo
            // 
            this.lsvFillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clBookID,
            this.clBookName,
            this.clIDFill,
            this.clQuantity,
            this.clPrice,
            this.clTotalPrice});
            this.lsvFillInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvFillInfo.HideSelection = false;
            this.lsvFillInfo.Location = new System.Drawing.Point(3, 4);
            this.lsvFillInfo.Name = "lsvFillInfo";
            this.lsvFillInfo.Size = new System.Drawing.Size(635, 266);
            this.lsvFillInfo.TabIndex = 0;
            this.lsvFillInfo.UseCompatibleStateImageBehavior = false;
            this.lsvFillInfo.View = System.Windows.Forms.View.Details;
            // 
            // clBookID
            // 
            this.clBookID.Text = "Mã sách";
            this.clBookID.Width = 116;
            // 
            // clBookName
            // 
            this.clBookName.Text = "Tên sách";
            this.clBookName.Width = 96;
            // 
            // clIDFill
            // 
            this.clIDFill.Text = "Mã phiếu nhập";
            this.clIDFill.Width = 112;
            // 
            // clQuantity
            // 
            this.clQuantity.Text = "Số lượng";
            // 
            // clPrice
            // 
            this.clPrice.Text = "Giá";
            // 
            // clTotalPrice
            // 
            this.clTotalPrice.Text = "Thành tiền";
            this.clTotalPrice.Width = 111;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(649, 481);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(91, 23);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Số lượng:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(784, 478);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(262, 30);
            this.txtQuantity.TabIndex = 15;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(649, 528);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(107, 23);
            this.lbPrice.TabIndex = 16;
            this.lbPrice.Text = "Thành tiền:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(784, 524);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(262, 26);
            this.txtPrice.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(898, 570);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 54);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm sách";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(784, 428);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(262, 30);
            this.txtBookName.TabIndex = 19;
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(784, 378);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(262, 30);
            this.txtBookID.TabIndex = 20;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(649, 431);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(91, 23);
            this.lbBookName.TabIndex = 21;
            this.lbBookName.Text = "Tên sách:";
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookID.Location = new System.Drawing.Point(649, 386);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(87, 23);
            this.lbBookID.TabIndex = 22;
            this.lbBookID.Text = "Mã sách:";
            // 
            // lbFillinID
            // 
            this.lbFillinID.AutoSize = true;
            this.lbFillinID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFillinID.Location = new System.Drawing.Point(15, 13);
            this.lbFillinID.Name = "lbFillinID";
            this.lbFillinID.Size = new System.Drawing.Size(66, 20);
            this.lbFillinID.TabIndex = 23;
            this.lbFillinID.Text = "Mã PN:";
            // 
            // txtFillID
            // 
            this.txtFillID.Location = new System.Drawing.Point(87, 10);
            this.txtFillID.Name = "txtFillID";
            this.txtFillID.Size = new System.Drawing.Size(100, 26);
            this.txtFillID.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbFillinID);
            this.panel4.Controls.Add(this.txtFillID);
            this.panel4.Location = new System.Drawing.Point(230, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 48);
            this.panel4.TabIndex = 25;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(649, 568);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(97, 23);
            this.lbTotalPrice.TabIndex = 26;
            this.lbTotalPrice.Text = "Tổng tiền:";
            // 
            // txtTPrice
            // 
            this.txtTPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPrice.Location = new System.Drawing.Point(653, 601);
            this.txtTPrice.Name = "txtTPrice";
            this.txtTPrice.ReadOnly = true;
            this.txtTPrice.Size = new System.Drawing.Size(201, 30);
            this.txtTPrice.TabIndex = 27;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1058, 645);
            this.Controls.Add(this.txtTPrice);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbBookID);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAddFill);
            this.Controls.Add(this.btnDeleteAB);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFill)).EndInit();
            this.txtTotalPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel txtTotalPrice;
        private System.Windows.Forms.Button btnDeleteAB;
        private System.Windows.Forms.Button btnAddFill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvFill;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Label lbFillinID;
        private System.Windows.Forms.TextBox txtFillID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox txtTPrice;
        private System.Windows.Forms.ListView lsvFillInfo;
        private System.Windows.Forms.ColumnHeader clBookID;
        private System.Windows.Forms.ColumnHeader clBookName;
        private System.Windows.Forms.ColumnHeader clIDFill;
        private System.Windows.Forms.ColumnHeader clQuantity;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clTotalPrice;
    }
}