namespace QLKinhDoanhBanLapTop.Forms
{
    partial class FormBaoCaoXuatHang
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
            this.CB_MaKhach = new System.Windows.Forms.ComboBox();
            this.DTPicker_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.DTPicker_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.Btn_XacNhan = new System.Windows.Forms.Button();
            this.Btn_KetThuc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CB_MaKhach, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DTPicker_NgayBD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTPicker_NgayKT, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_XacNhan, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn_KetThuc, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(87, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(87, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_MaKhach
            // 
            this.CB_MaKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_MaKhach.FormattingEnabled = true;
            this.CB_MaKhach.Location = new System.Drawing.Point(283, 63);
            this.CB_MaKhach.Name = "CB_MaKhach";
            this.CB_MaKhach.Size = new System.Drawing.Size(190, 23);
            this.CB_MaKhach.TabIndex = 3;
            // 
            // DTPicker_NgayBD
            // 
            this.DTPicker_NgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPicker_NgayBD.Location = new System.Drawing.Point(283, 92);
            this.DTPicker_NgayBD.Name = "DTPicker_NgayBD";
            this.DTPicker_NgayBD.Size = new System.Drawing.Size(190, 23);
            this.DTPicker_NgayBD.TabIndex = 4;
            // 
            // DTPicker_NgayKT
            // 
            this.DTPicker_NgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPicker_NgayKT.Location = new System.Drawing.Point(283, 121);
            this.DTPicker_NgayKT.Name = "DTPicker_NgayKT";
            this.DTPicker_NgayKT.Size = new System.Drawing.Size(190, 23);
            this.DTPicker_NgayKT.TabIndex = 5;
            // 
            // Btn_XacNhan
            // 
            this.Btn_XacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_XacNhan.Location = new System.Drawing.Point(144, 180);
            this.Btn_XacNhan.Name = "Btn_XacNhan";
            this.Btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.Btn_XacNhan.TabIndex = 6;
            this.Btn_XacNhan.Text = "Xác nhận";
            this.Btn_XacNhan.UseVisualStyleBackColor = true;
            this.Btn_XacNhan.Click += new System.EventHandler(this.Btn_XacNhan_Click);
            // 
            // Btn_KetThuc
            // 
            this.Btn_KetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_KetThuc.Location = new System.Drawing.Point(340, 180);
            this.Btn_KetThuc.Name = "Btn_KetThuc";
            this.Btn_KetThuc.Size = new System.Drawing.Size(75, 23);
            this.Btn_KetThuc.TabIndex = 7;
            this.Btn_KetThuc.Text = "Kết thúc";
            this.Btn_KetThuc.UseVisualStyleBackColor = true;
            this.Btn_KetThuc.Click += new System.EventHandler(this.Btn_KetThuc_Click);
            // 
            // LayTTBaoCaoKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 260);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LayTTBaoCaoKhach";
            this.Text = "LayTTBaoCaoKhach";
            this.Load += new System.EventHandler(this.LayTTBaoCaoKhach_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox CB_MaKhach;
        private DateTimePicker DTPicker_NgayBD;
        private DateTimePicker DTPicker_NgayKT;
        private Button Btn_XacNhan;
        private Button Btn_KetThuc;
    }
}