namespace QuanLyNhaSach
{
    partial class frmBaoCao
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
            this.dtpReport = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbReportTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvReport = new System.Windows.Forms.ListView();
            this.clBookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clInPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clOutPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clOutQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clRevenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbResult = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpReport);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbReportTitle);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 150);
            this.panel1.TabIndex = 0;
            // 
            // dtpReport
            // 
            this.dtpReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReport.Location = new System.Drawing.Point(142, 62);
            this.dtpReport.Name = "dtpReport";
            this.dtpReport.Size = new System.Drawing.Size(276, 26);
            this.dtpReport.TabIndex = 2;
            this.dtpReport.Value = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(4, 62);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 23);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Chọn ngày:";
            // 
            // lbReportTitle
            // 
            this.lbReportTitle.AutoSize = true;
            this.lbReportTitle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReportTitle.Location = new System.Drawing.Point(4, 4);
            this.lbReportTitle.Name = "lbReportTitle";
            this.lbReportTitle.Size = new System.Drawing.Size(207, 22);
            this.lbReportTitle.TabIndex = 0;
            this.lbReportTitle.Text = "Báo cáo doanh thu theo ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Location = new System.Drawing.Point(676, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 159);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Beige;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(98, 85);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(98, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 45);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvReport);
            this.panel3.Location = new System.Drawing.Point(5, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 239);
            this.panel3.TabIndex = 2;
            // 
            // lsvReport
            // 
            this.lsvReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clBookID,
            this.clBookName,
            this.clInPrice,
            this.clOutPrice,
            this.clOutQuantity,
            this.clDate,
            this.clRevenue});
            this.lsvReport.HideSelection = false;
            this.lsvReport.Location = new System.Drawing.Point(3, 1);
            this.lsvReport.Name = "lsvReport";
            this.lsvReport.Size = new System.Drawing.Size(997, 236);
            this.lsvReport.TabIndex = 2;
            this.lsvReport.UseCompatibleStateImageBehavior = false;
            this.lsvReport.View = System.Windows.Forms.View.Details;
            // 
            // clBookID
            // 
            this.clBookID.Text = "Mã sách";
            this.clBookID.Width = 96;
            // 
            // clBookName
            // 
            this.clBookName.Text = "Tên sách";
            this.clBookName.Width = 167;
            // 
            // clInPrice
            // 
            this.clInPrice.Text = "Giá nhập";
            this.clInPrice.Width = 113;
            // 
            // clOutPrice
            // 
            this.clOutPrice.Text = "Giá bán";
            this.clOutPrice.Width = 99;
            // 
            // clOutQuantity
            // 
            this.clOutQuantity.Text = "Số lượng bán";
            this.clOutQuantity.Width = 114;
            // 
            // clDate
            // 
            this.clDate.Text = "Ngày bán";
            this.clDate.Width = 109;
            // 
            // clRevenue
            // 
            this.clRevenue.Text = "Doanh thu";
            this.clRevenue.Width = 107;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(22, 182);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(88, 25);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Kết quả";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.Location = new System.Drawing.Point(632, 470);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(147, 23);
            this.lbRevenue.TabIndex = 4;
            this.lbRevenue.Text = "Tổng doanh thu:";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(794, 470);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(205, 26);
            this.txtRevenue.TabIndex = 5;
            this.txtRevenue.TabStop = false;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1011, 510);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.lbRevenue);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbReportTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.ListView lsvReport;
        private System.Windows.Forms.ColumnHeader clBookID;
        private System.Windows.Forms.ColumnHeader clBookName;
        private System.Windows.Forms.ColumnHeader clInPrice;
        private System.Windows.Forms.ColumnHeader clOutPrice;
        private System.Windows.Forms.ColumnHeader clOutQuantity;
        private System.Windows.Forms.ColumnHeader clDate;
        private System.Windows.Forms.ColumnHeader clRevenue;
    }
}