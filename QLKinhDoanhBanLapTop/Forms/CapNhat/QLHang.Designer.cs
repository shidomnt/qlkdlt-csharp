namespace QLKinhDoanhBanLapTop.Forms
{
    partial class QLHang
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
            this.TextBox_MaHang = new System.Windows.Forms.TextBox();
            this.TextBox_TenHang = new System.Windows.Forms.TextBox();
            this.TextBox_DonGia = new System.Windows.Forms.TextBox();
            this.DataGridView_DSKH = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DvTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_ResetInput = new System.Windows.Forms.Button();
            this.ComboBox_DvTinh = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DSKH)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.TextBox_MaHang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_TenHang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_DonGia, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView_DSKH, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ResetInput, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_DvTinh, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_MaHang
            // 
            this.TextBox_MaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_MaHang.Location = new System.Drawing.Point(163, 63);
            this.TextBox_MaHang.Name = "TextBox_MaHang";
            this.TextBox_MaHang.Size = new System.Drawing.Size(474, 23);
            this.TextBox_MaHang.TabIndex = 0;
            // 
            // TextBox_TenHang
            // 
            this.TextBox_TenHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_TenHang.Location = new System.Drawing.Point(163, 93);
            this.TextBox_TenHang.Name = "TextBox_TenHang";
            this.TextBox_TenHang.Size = new System.Drawing.Size(474, 23);
            this.TextBox_TenHang.TabIndex = 1;
            // 
            // TextBox_DonGia
            // 
            this.TextBox_DonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_DonGia.Location = new System.Drawing.Point(163, 153);
            this.TextBox_DonGia.Name = "TextBox_DonGia";
            this.TextBox_DonGia.Size = new System.Drawing.Size(474, 23);
            this.TextBox_DonGia.TabIndex = 3;
            // 
            // DataGridView_DSKH
            // 
            this.DataGridView_DSKH.AllowUserToAddRows = false;
            this.DataGridView_DSKH.AllowUserToDeleteRows = false;
            this.DataGridView_DSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_DSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.DvTinh,
            this.DonGia});
            this.tableLayoutPanel1.SetColumnSpan(this.DataGridView_DSKH, 3);
            this.DataGridView_DSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_DSKH.Location = new System.Drawing.Point(3, 293);
            this.DataGridView_DSKH.Name = "DataGridView_DSKH";
            this.DataGridView_DSKH.ReadOnly = true;
            this.DataGridView_DSKH.RowHeadersWidth = 51;
            this.DataGridView_DSKH.RowTemplate.Height = 25;
            this.DataGridView_DSKH.Size = new System.Drawing.Size(794, 154);
            this.DataGridView_DSKH.TabIndex = 9;
            this.DataGridView_DSKH.TabStop = false;
            this.DataGridView_DSKH.SelectionChanged += new System.EventHandler(this.DataGridView_DSKH_SelectionChanged);
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
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // DvTinh
            // 
            this.DvTinh.DataPropertyName = "DvTinh";
            this.DvTinh.HeaderText = "Đơn vị tính";
            this.DvTinh.MinimumWidth = 6;
            this.DvTinh.Name = "DvTinh";
            this.DvTinh.ReadOnly = true;
            this.DvTinh.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 190;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(163, 213);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 44);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Btn_Them
            // 
            this.Btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Them.Location = new System.Drawing.Point(3, 3);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(152, 38);
            this.Btn_Them.TabIndex = 0;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Sua.Location = new System.Drawing.Point(161, 3);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(152, 38);
            this.Btn_Sua.TabIndex = 1;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = true;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Xoa.Location = new System.Drawing.Point(319, 3);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(152, 38);
            this.Btn_Xoa.TabIndex = 2;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_ResetInput
            // 
            this.Btn_ResetInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_ResetInput.Location = new System.Drawing.Point(643, 183);
            this.Btn_ResetInput.Name = "Btn_ResetInput";
            this.Btn_ResetInput.Size = new System.Drawing.Size(75, 24);
            this.Btn_ResetInput.TabIndex = 4;
            this.Btn_ResetInput.Text = "Làm mới";
            this.Btn_ResetInput.UseVisualStyleBackColor = true;
            this.Btn_ResetInput.Click += new System.EventHandler(this.Btn_ResetInput_Click);
            // 
            // ComboBox_DvTinh
            // 
            this.ComboBox_DvTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox_DvTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_DvTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_DvTinh.FormattingEnabled = true;
            this.ComboBox_DvTinh.Location = new System.Drawing.Point(163, 123);
            this.ComboBox_DvTinh.Name = "ComboBox_DvTinh";
            this.ComboBox_DvTinh.Size = new System.Drawing.Size(474, 23);
            this.ComboBox_DvTinh.TabIndex = 2;
            // 
            // QLHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QLHang";
            this.Text = "Quản lý hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLKH_FormClosing);
            this.Load += new System.EventHandler(this.QLH_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DSKH)).EndInit();
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
        private TextBox TextBox_MaHang;
        private TextBox TextBox_TenHang;
        private TextBox TextBox_DonGia;
        private DataGridView DataGridView_DSKH;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Btn_Them;
        private Button Btn_Sua;
        private Button Btn_Xoa;
        private Button Btn_ResetInput;
        private DataGridViewTextBoxColumn MaHang;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn DvTinh;
        private DataGridViewTextBoxColumn DonGia;
        private ComboBox ComboBox_DvTinh;
    }
}