namespace QLKinhDoanhBanLapTop.Forms
{
    partial class DSHangThanhToan
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
            this.DataGridView_ThemHang = new System.Windows.Forms.DataGridView();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_ChapNhan = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ThemHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_ThemHang
            // 
            this.DataGridView_ThemHang.AllowUserToAddRows = false;
            this.DataGridView_ThemHang.AllowUserToDeleteRows = false;
            this.DataGridView_ThemHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ThemHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.SoLuong,
            this.DonGia});
            this.tableLayoutPanel1.SetColumnSpan(this.DataGridView_ThemHang, 2);
            this.DataGridView_ThemHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_ThemHang.Location = new System.Drawing.Point(3, 2);
            this.DataGridView_ThemHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView_ThemHang.Name = "DataGridView_ThemHang";
            this.DataGridView_ThemHang.ReadOnly = true;
            this.DataGridView_ThemHang.RowHeadersWidth = 51;
            this.DataGridView_ThemHang.RowTemplate.Height = 29;
            this.DataGridView_ThemHang.Size = new System.Drawing.Size(546, 274);
            this.DataGridView_ThemHang.TabIndex = 0;
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridView_ThemHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ChapNhan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Them, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 304);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Btn_ChapNhan
            // 
            this.Btn_ChapNhan.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_ChapNhan.Location = new System.Drawing.Point(3, 280);
            this.Btn_ChapNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ChapNhan.Name = "Btn_ChapNhan";
            this.Btn_ChapNhan.Size = new System.Drawing.Size(82, 22);
            this.Btn_ChapNhan.TabIndex = 1;
            this.Btn_ChapNhan.Text = "Chấp nhận";
            this.Btn_ChapNhan.UseVisualStyleBackColor = true;
            this.Btn_ChapNhan.Click += new System.EventHandler(this.Btn_ChapNhan_Click);
            // 
            // Btn_Them
            // 
            this.Btn_Them.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Them.Location = new System.Drawing.Point(467, 280);
            this.Btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(82, 22);
            this.Btn_Them.TabIndex = 2;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // DSHangThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 304);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DSHangThanhToan";
            this.Text = "Thêm hàng";
            this.Load += new System.EventHandler(this.DSHangThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ThemHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataGridView_ThemHang;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Btn_ChapNhan;
        private Button Btn_Them;
    }
}