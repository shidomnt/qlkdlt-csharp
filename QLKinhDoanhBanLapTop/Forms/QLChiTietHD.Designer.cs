namespace QLKinhDoanhBanLapTop.Forms
{
    partial class QLChiTietHD
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
            this.TextBox_SoLuong = new System.Windows.Forms.TextBox();
            this.TextBox_DonGia = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_ResetInput = new System.Windows.Forms.Button();
            this.DataGridView_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox_Hang = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ChiTietHD)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.TextBox_SoLuong, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_DonGia, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ResetInput, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView_ChiTietHD, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_Hang, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_SoHD
            // 
            this.TextBox_SoHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SoHD.Location = new System.Drawing.Point(185, 84);
            this.TextBox_SoHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_SoHD.Name = "TextBox_SoHD";
            this.TextBox_SoHD.ReadOnly = true;
            this.TextBox_SoHD.Size = new System.Drawing.Size(542, 27);
            this.TextBox_SoHD.TabIndex = 0;
            // 
            // TextBox_SoLuong
            // 
            this.TextBox_SoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SoLuong.Location = new System.Drawing.Point(185, 164);
            this.TextBox_SoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_SoLuong.Name = "TextBox_SoLuong";
            this.TextBox_SoLuong.Size = new System.Drawing.Size(542, 27);
            this.TextBox_SoLuong.TabIndex = 2;
            // 
            // TextBox_DonGia
            // 
            this.TextBox_DonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_DonGia.Location = new System.Drawing.Point(185, 204);
            this.TextBox_DonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_DonGia.Name = "TextBox_DonGia";
            this.TextBox_DonGia.Size = new System.Drawing.Size(542, 27);
            this.TextBox_DonGia.TabIndex = 3;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(185, 284);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(542, 59);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Btn_Them
            // 
            this.Btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Them.Location = new System.Drawing.Point(3, 4);
            this.Btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(174, 51);
            this.Btn_Them.TabIndex = 0;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Sua.Location = new System.Drawing.Point(183, 4);
            this.Btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(174, 51);
            this.Btn_Sua.TabIndex = 1;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = true;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Xoa.Location = new System.Drawing.Point(363, 4);
            this.Btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(176, 51);
            this.Btn_Xoa.TabIndex = 2;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_ResetInput
            // 
            this.Btn_ResetInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_ResetInput.Location = new System.Drawing.Point(733, 244);
            this.Btn_ResetInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_ResetInput.Name = "Btn_ResetInput";
            this.Btn_ResetInput.Size = new System.Drawing.Size(86, 32);
            this.Btn_ResetInput.TabIndex = 4;
            this.Btn_ResetInput.Text = "Làm mới";
            this.Btn_ResetInput.UseVisualStyleBackColor = true;
            this.Btn_ResetInput.Click += new System.EventHandler(this.Btn_ResetInput_Click);
            // 
            // DataGridView_ChiTietHD
            // 
            this.DataGridView_ChiTietHD.AllowUserToAddRows = false;
            this.DataGridView_ChiTietHD.AllowUserToDeleteRows = false;
            this.DataGridView_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.MaHang,
            this.SoLuong,
            this.Gia});
            this.tableLayoutPanel1.SetColumnSpan(this.DataGridView_ChiTietHD, 3);
            this.DataGridView_ChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_ChiTietHD.Location = new System.Drawing.Point(3, 390);
            this.DataGridView_ChiTietHD.Name = "DataGridView_ChiTietHD";
            this.DataGridView_ChiTietHD.ReadOnly = true;
            this.DataGridView_ChiTietHD.RowHeadersWidth = 51;
            this.DataGridView_ChiTietHD.RowTemplate.Height = 29;
            this.DataGridView_ChiTietHD.Size = new System.Drawing.Size(908, 207);
            this.DataGridView_ChiTietHD.TabIndex = 12;
            this.DataGridView_ChiTietHD.TabStop = false;
            this.DataGridView_ChiTietHD.SelectionChanged += new System.EventHandler(this.DataGridView_DSHang_SelectionChanged);
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
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Đơn giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // ComboBox_Hang
            // 
            this.ComboBox_Hang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_Hang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_Hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Hang.FormattingEnabled = true;
            this.ComboBox_Hang.Location = new System.Drawing.Point(185, 124);
            this.ComboBox_Hang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_Hang.Name = "ComboBox_Hang";
            this.ComboBox_Hang.Size = new System.Drawing.Size(542, 28);
            this.ComboBox_Hang.TabIndex = 1;
            this.ComboBox_Hang.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Hang_SelectedIndexChanged);
            // 
            // QLChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QLChiTietHD";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLChiTietHD_FormClosing);
            this.Load += new System.EventHandler(this.QLChiTietHD_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ChiTietHD)).EndInit();
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
        private TextBox TextBox_SoLuong;
        private TextBox TextBox_DonGia;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Btn_Them;
        private Button Btn_Sua;
        private Button Btn_Xoa;
        private Button Btn_ResetInput;
        private DataGridView DataGridView_ChiTietHD;
        private ComboBox ComboBox_Hang;
        private DataGridViewTextBoxColumn SoHD;
        private DataGridViewTextBoxColumn MaHang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn Gia;
    }
}