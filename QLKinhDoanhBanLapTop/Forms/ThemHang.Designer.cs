﻿namespace QLKinhDoanhBanLapTop.Forms
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 199);
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
            this.label1.Size = new System.Drawing.Size(526, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Them
            // 
            this.Btn_Them.Location = new System.Drawing.Point(428, 153);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(94, 29);
            this.Btn_Them.TabIndex = 4;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // TextBox_SoLuong
            // 
            this.TextBox_SoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SoLuong.Location = new System.Drawing.Point(109, 87);
            this.TextBox_SoLuong.Name = "TextBox_SoLuong";
            this.TextBox_SoLuong.Size = new System.Drawing.Size(313, 27);
            this.TextBox_SoLuong.TabIndex = 6;
            // 
            // TextBox_DonGia
            // 
            this.TextBox_DonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_DonGia.Location = new System.Drawing.Point(109, 120);
            this.TextBox_DonGia.Name = "TextBox_DonGia";
            this.TextBox_DonGia.Size = new System.Drawing.Size(313, 27);
            this.TextBox_DonGia.TabIndex = 7;
            // 
            // ComboBox_TenHang
            // 
            this.ComboBox_TenHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_TenHang.FormattingEnabled = true;
            this.ComboBox_TenHang.Location = new System.Drawing.Point(109, 53);
            this.ComboBox_TenHang.Name = "ComboBox_TenHang";
            this.ComboBox_TenHang.Size = new System.Drawing.Size(313, 28);
            this.ComboBox_TenHang.TabIndex = 8;
            // 
            // ThemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(532, 199);
            this.Controls.Add(this.tableLayoutPanel1);
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