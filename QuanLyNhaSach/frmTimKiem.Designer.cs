namespace QuanLyNhaSach
{
    partial class frmTimKiem
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
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvFindBook = new System.Windows.Forms.DataGridView();
            this.lbList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadData);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.lbBookName);
            this.panel1.Controls.Add(this.lbAuthor);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 121);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLoadData.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(616, 22);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(91, 78);
            this.btnLoadData.TabIndex = 9;
            this.btnLoadData.Text = "Xem";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(112, 24);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(339, 26);
            this.txtAuthor.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Beige;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(727, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 70);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(508, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 78);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Tìm ";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(112, 74);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(339, 26);
            this.txtBookName.TabIndex = 5;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(13, 76);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(80, 22);
            this.lbBookName.TabIndex = 4;
            this.lbBookName.Text = "Tên sách";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(13, 26);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(69, 22);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "Tác giả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFindBook);
            this.panel2.Controls.Add(this.lbList);
            this.panel2.Location = new System.Drawing.Point(13, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 343);
            this.panel2.TabIndex = 1;
            // 
            // dgvFindBook
            // 
            this.dgvFindBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFindBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindBook.Location = new System.Drawing.Point(17, 41);
            this.dgvFindBook.Name = "dgvFindBook";
            this.dgvFindBook.RowHeadersWidth = 62;
            this.dgvFindBook.RowTemplate.Height = 28;
            this.dgvFindBook.Size = new System.Drawing.Size(778, 284);
            this.dgvFindBook.TabIndex = 1;
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(17, 14);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(178, 23);
            this.lbList.TabIndex = 0;
            this.lbList.Text = "Danh sách tìm kiếm";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(840, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvFindBook;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnExit;
    }
}