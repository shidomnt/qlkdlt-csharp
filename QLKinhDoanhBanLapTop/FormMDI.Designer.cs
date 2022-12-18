namespace QLKinhDoanhBanLapTop
{
    partial class FormMDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngtinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.thôngtinToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // thôngtinToolStripMenuItem
            // 
            this.thôngtinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.hàngToolStripMenuItem});
            this.thôngtinToolStripMenuItem.Name = "thôngtinToolStripMenuItem";
            this.thôngtinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngtinToolStripMenuItem.Text = "Thông tin";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // hàngToolStripMenuItem
            // 
            this.hàngToolStripMenuItem.Name = "hàngToolStripMenuItem";
            this.hàngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.hàngToolStripMenuItem.Text = "Hàng";
            this.hàngToolStripMenuItem.Click += new System.EventHandler(this.hàngToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoaDonToolStripMenuItem,
            this.phiếuThuChiToolStripMenuItem});
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // hoaDonToolStripMenuItem
            // 
            this.hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            this.hoaDonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hoaDonToolStripMenuItem.Text = "Hóa đơn";
            this.hoaDonToolStripMenuItem.Click += new System.EventHandler(this.hoaDonToolStripMenuItem_Click);
            // 
            // phiếuThuChiToolStripMenuItem
            // 
            this.phiếuThuChiToolStripMenuItem.Name = "phiếuThuChiToolStripMenuItem";
            this.phiếuThuChiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phiếuThuChiToolStripMenuItem.Text = "Phiếu thu chi";
            this.phiếuThuChiToolStripMenuItem.Click += new System.EventHandler(this.phiếuThuChiToolStripMenuItem_Click);
            // 
            // QLKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 404);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLKD";
            this.Text = "Quản lý kinh doanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem thôngtinToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem hàngToolStripMenuItem;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
        private ToolStripMenuItem hoaDonToolStripMenuItem;
        private ToolStripMenuItem phiếuThuChiToolStripMenuItem;
    }
}