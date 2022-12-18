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
            this.TextBox_MaKH = new System.Windows.Forms.TextBox();
            this.TextBox_TenKH = new System.Windows.Forms.TextBox();
            this.TextBox_DiaChi = new System.Windows.Forms.TextBox();
            this.TextBox_SoDt = new System.Windows.Forms.TextBox();
            this.DataGridView_DSKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_ResetInput = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.TextBox_MaKH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_TenKH, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_DiaChi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_SoDt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView_DSKH, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ResetInput, 2, 5);
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
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.label1.Text = "Quản lý khách hàng";
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
            this.label2.Text = "Mã KH";
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
            this.label3.Text = "Tên KH";
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
            this.label4.Text = "Địa Chỉ";
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
            this.label5.Text = "Số điện thoại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_MaKH
            // 
            this.TextBox_MaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_MaKH.Location = new System.Drawing.Point(163, 63);
            this.TextBox_MaKH.Name = "TextBox_MaKH";
            this.TextBox_MaKH.Size = new System.Drawing.Size(474, 23);
            this.TextBox_MaKH.TabIndex = 5;
            // 
            // TextBox_TenKH
            // 
            this.TextBox_TenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_TenKH.Location = new System.Drawing.Point(163, 93);
            this.TextBox_TenKH.Name = "TextBox_TenKH";
            this.TextBox_TenKH.Size = new System.Drawing.Size(474, 23);
            this.TextBox_TenKH.TabIndex = 6;
            // 
            // TextBox_DiaChi
            // 
            this.TextBox_DiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_DiaChi.Location = new System.Drawing.Point(163, 123);
            this.TextBox_DiaChi.Name = "TextBox_DiaChi";
            this.TextBox_DiaChi.Size = new System.Drawing.Size(474, 23);
            this.TextBox_DiaChi.TabIndex = 7;
            // 
            // TextBox_SoDt
            // 
            this.TextBox_SoDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SoDt.Location = new System.Drawing.Point(163, 153);
            this.TextBox_SoDt.Name = "TextBox_SoDt";
            this.TextBox_SoDt.Size = new System.Drawing.Size(474, 23);
            this.TextBox_SoDt.TabIndex = 8;
            // 
            // DataGridView_DSKH
            // 
            this.DataGridView_DSKH.AllowUserToAddRows = false;
            this.DataGridView_DSKH.AllowUserToDeleteRows = false;
            this.DataGridView_DSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_DSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SDT});
            this.tableLayoutPanel1.SetColumnSpan(this.DataGridView_DSKH, 3);
            this.DataGridView_DSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_DSKH.Location = new System.Drawing.Point(3, 293);
            this.DataGridView_DSKH.Name = "DataGridView_DSKH";
            this.DataGridView_DSKH.ReadOnly = true;
            this.DataGridView_DSKH.RowTemplate.Height = 25;
            this.DataGridView_DSKH.Size = new System.Drawing.Size(794, 154);
            this.DataGridView_DSKH.TabIndex = 9;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SoDt";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 150;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 44);
            this.tableLayoutPanel2.TabIndex = 10;
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
            // 
            // Btn_ResetInput
            // 
            this.Btn_ResetInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_ResetInput.Location = new System.Drawing.Point(643, 183);
            this.Btn_ResetInput.Name = "Btn_ResetInput";
            this.Btn_ResetInput.Size = new System.Drawing.Size(75, 24);
            this.Btn_ResetInput.TabIndex = 11;
            this.Btn_ResetInput.Text = "Làm mới";
            this.Btn_ResetInput.UseVisualStyleBackColor = true;
            // 
            // QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QLHD";
            this.Text = "QLHD";
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
        private TextBox TextBox_MaKH;
        private TextBox TextBox_TenKH;
        private TextBox TextBox_DiaChi;
        private TextBox TextBox_SoDt;
        private DataGridView DataGridView_DSKH;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Btn_Them;
        private Button Btn_Sua;
        private Button Btn_Xoa;
        private Button Btn_ResetInput;
    }
}