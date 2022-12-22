namespace QLKinhDoanhBanLapTop.Forms
{
    partial class QLHoaDon
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_SoHD = new System.Windows.Forms.TextBox();
            this.TextBox_SoTienTT = new System.Windows.Forms.TextBox();
            this.DataGridView_DSHoaDon = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_ResetInput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_MaKH = new System.Windows.Forms.ComboBox();
            this.ComboBox_LoaiHD = new System.Windows.Forms.ComboBox();
            this.DatePicker_Ngay = new System.Windows.Forms.DateTimePicker();
            this.Btn_ThemHang = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DSHoaDon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_SoHD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_SoTienTT, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView_DSHoaDon, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ResetInput, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_MaKH, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_LoaiHD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DatePicker_Ngay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ThemHang, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày phát sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền thanh toán";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại hóa đơn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_SoHD
            // 
            this.TextBox_SoHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SoHD.Location = new System.Drawing.Point(190, 84);
            this.TextBox_SoHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_SoHD.Name = "TextBox_SoHD";
            this.TextBox_SoHD.Size = new System.Drawing.Size(557, 27);
            this.TextBox_SoHD.TabIndex = 0;
            // 
            // TextBox_SoTienTT
            // 
            this.TextBox_SoTienTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SoTienTT.Location = new System.Drawing.Point(190, 154);
            this.TextBox_SoTienTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_SoTienTT.Name = "TextBox_SoTienTT";
            this.TextBox_SoTienTT.Size = new System.Drawing.Size(557, 27);
            this.TextBox_SoTienTT.TabIndex = 2;
            // 
            // DataGridView_DSHoaDon
            // 
            this.DataGridView_DSHoaDon.AllowUserToAddRows = false;
            this.DataGridView_DSHoaDon.AllowUserToDeleteRows = false;
            this.DataGridView_DSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_DSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.NgayPS,
            this.SoTienTT,
            this.LoaiHD,
            this.MaKH});
            this.tableLayoutPanel1.SetColumnSpan(this.DataGridView_DSHoaDon, 3);
            this.DataGridView_DSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_DSHoaDon.Location = new System.Drawing.Point(3, 368);
            this.DataGridView_DSHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridView_DSHoaDon.Name = "DataGridView_DSHoaDon";
            this.DataGridView_DSHoaDon.ReadOnly = true;
            this.DataGridView_DSHoaDon.RowHeadersWidth = 51;
            this.DataGridView_DSHoaDon.RowTemplate.Height = 25;
            this.DataGridView_DSHoaDon.Size = new System.Drawing.Size(933, 188);
            this.DataGridView_DSHoaDon.TabIndex = 1;
            this.DataGridView_DSHoaDon.TabStop = false;
            this.DataGridView_DSHoaDon.SelectionChanged += new System.EventHandler(this.DataGridView_DSHoaDon_SelectionChanged);
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số hóa đơn";
            this.SoHD.MinimumWidth = 6;
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            this.SoHD.Width = 125;
            // 
            // NgayPS
            // 
            this.NgayPS.DataPropertyName = "NgayPS";
            this.NgayPS.HeaderText = "Ngày phát sinh";
            this.NgayPS.MinimumWidth = 6;
            this.NgayPS.Name = "NgayPS";
            this.NgayPS.ReadOnly = true;
            this.NgayPS.Width = 200;
            // 
            // SoTienTT
            // 
            this.SoTienTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTienTT.DataPropertyName = "SoTienTT";
            this.SoTienTT.HeaderText = "Số tiền TT";
            this.SoTienTT.MinimumWidth = 6;
            this.SoTienTT.Name = "SoTienTT";
            this.SoTienTT.ReadOnly = true;
            // 
            // LoaiHD
            // 
            this.LoaiHD.DataPropertyName = "LoaiHD";
            this.LoaiHD.HeaderText = "Loại hóa đơn";
            this.LoaiHD.MinimumWidth = 6;
            this.LoaiHD.Name = "LoaiHD";
            this.LoaiHD.ReadOnly = true;
            this.LoaiHD.Width = 150;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 170;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_Them, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Sua, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Xoa, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(190, 301);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 59);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // Btn_Them
            // 
            this.Btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Them.Location = new System.Drawing.Point(3, 4);
            this.Btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(179, 51);
            this.Btn_Them.TabIndex = 0;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Sua.Location = new System.Drawing.Point(188, 4);
            this.Btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(179, 51);
            this.Btn_Sua.TabIndex = 1;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = true;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Xoa.Location = new System.Drawing.Point(373, 4);
            this.Btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(181, 51);
            this.Btn_Xoa.TabIndex = 2;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_ResetInput
            // 
            this.Btn_ResetInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_ResetInput.Location = new System.Drawing.Point(753, 261);
            this.Btn_ResetInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_ResetInput.Name = "Btn_ResetInput";
            this.Btn_ResetInput.Size = new System.Drawing.Size(86, 32);
            this.Btn_ResetInput.TabIndex = 6;
            this.Btn_ResetInput.Text = "Làm mới";
            this.Btn_ResetInput.UseVisualStyleBackColor = true;
            this.Btn_ResetInput.Click += new System.EventHandler(this.Btn_ResetInput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên khách hàng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox_MaKH
            // 
            this.ComboBox_MaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_MaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_MaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_MaKH.FormattingEnabled = true;
            this.ComboBox_MaKH.Location = new System.Drawing.Point(190, 225);
            this.ComboBox_MaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_MaKH.Name = "ComboBox_MaKH";
            this.ComboBox_MaKH.Size = new System.Drawing.Size(557, 28);
            this.ComboBox_MaKH.TabIndex = 4;
            // 
            // ComboBox_LoaiHD
            // 
            this.ComboBox_LoaiHD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_LoaiHD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_LoaiHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_LoaiHD.FormattingEnabled = true;
            this.ComboBox_LoaiHD.Location = new System.Drawing.Point(190, 189);
            this.ComboBox_LoaiHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_LoaiHD.Name = "ComboBox_LoaiHD";
            this.ComboBox_LoaiHD.Size = new System.Drawing.Size(557, 28);
            this.ComboBox_LoaiHD.TabIndex = 3;
            // 
            // DatePicker_Ngay
            // 
            this.DatePicker_Ngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatePicker_Ngay.Location = new System.Drawing.Point(190, 119);
            this.DatePicker_Ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePicker_Ngay.Name = "DatePicker_Ngay";
            this.DatePicker_Ngay.Size = new System.Drawing.Size(557, 27);
            this.DatePicker_Ngay.TabIndex = 1;
            // 
            // Btn_ThemHang
            // 
            this.Btn_ThemHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_ThemHang.Location = new System.Drawing.Point(190, 260);
            this.Btn_ThemHang.Name = "Btn_ThemHang";
            this.Btn_ThemHang.Size = new System.Drawing.Size(157, 34);
            this.Btn_ThemHang.TabIndex = 5;
            this.Btn_ThemHang.Text = "Chi tiết hóa đơn";
            this.Btn_ThemHang.UseVisualStyleBackColor = true;
            this.Btn_ThemHang.Click += new System.EventHandler(this.Btn_DSHang_Click);
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QLHoaDon";
            this.Text = "Thanh toán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLKH_FormClosing);
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DSHoaDon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextBox_SoHD;
        private TextBox TextBox_SoTienTT;
        private DataGridView DataGridView_DSHoaDon;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Btn_Them;
        private Button Btn_Sua;
        private Button Btn_Xoa;
        private Button Btn_ResetInput;
        private Label label6;
        private ComboBox ComboBox_MaKH;
        private ComboBox ComboBox_LoaiHD;
        private DateTimePicker DatePicker_Ngay;
        private DataGridViewTextBoxColumn SoHD;
        private DataGridViewTextBoxColumn NgayPS;
        private DataGridViewTextBoxColumn SoTienTT;
        private DataGridViewTextBoxColumn LoaiHD;
        private DataGridViewTextBoxColumn MaKH;
        private Button Btn_ThemHang;
    }
}