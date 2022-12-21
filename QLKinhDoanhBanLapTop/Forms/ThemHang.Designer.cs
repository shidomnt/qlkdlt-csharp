namespace QLKinhDoanhBanLapTop.Forms
{
    partial class ThemHang
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
            this.Btn_Them = new System.Windows.Forms.Button();
            this.TextBox_SoLuong = new System.Windows.Forms.TextBox();
            this.TextBox_DonGia = new System.Windows.Forms.TextBox();
            this.ComboBox_TenHang = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Them, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_SoLuong, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_DonGia, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox_TenHang, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Them
            // 
            this.Btn_Them.Location = new System.Drawing.Point(620, 121);
            this.Btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(82, 22);
            this.Btn_Them.TabIndex = 4;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // TextBox_SoLuong
            // 
            this.TextBox_SoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SoLuong.Location = new System.Drawing.Point(157, 67);
            this.TextBox_SoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_SoLuong.Name = "TextBox_SoLuong";
            this.TextBox_SoLuong.Size = new System.Drawing.Size(457, 23);
            this.TextBox_SoLuong.TabIndex = 6;
            // 
            // TextBox_DonGia
            // 
            this.TextBox_DonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_DonGia.Location = new System.Drawing.Point(157, 94);
            this.TextBox_DonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox_DonGia.Name = "TextBox_DonGia";
            this.TextBox_DonGia.Size = new System.Drawing.Size(457, 23);
            this.TextBox_DonGia.TabIndex = 7;
            // 
            // ComboBox_TenHang
            // 
            this.ComboBox_TenHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_TenHang.FormattingEnabled = true;
            this.ComboBox_TenHang.Location = new System.Drawing.Point(157, 40);
            this.ComboBox_TenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox_TenHang.Name = "ComboBox_TenHang";
            this.ComboBox_TenHang.Size = new System.Drawing.Size(457, 23);
            this.ComboBox_TenHang.TabIndex = 8;
            // 
            // ThemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(773, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemHang";
            this.Text = "ThemHang";
            this.Load += new System.EventHandler(this.ThemHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Btn_Them;
        private TextBox TextBox_SoLuong;
        private TextBox TextBox_DonGia;
        private ComboBox ComboBox_TenHang;
    }
}