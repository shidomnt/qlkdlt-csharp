namespace QLKinhDoanhBanLapTop
{
    partial class QLBanHang
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
            this.Btn_CapNhat = new System.Windows.Forms.Button();
            this.Btn_XuLy = new System.Windows.Forms.Button();
            this.Btn_BaoCao = new System.Windows.Forms.Button();
            this.Btn_KetThuc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_CapNhat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_XuLy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_BaoCao, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Btn_KetThuc, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 304);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright - HaTQ - UDPM1K12";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_CapNhat
            // 
            this.Btn_CapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_CapNhat.Location = new System.Drawing.Point(139, 103);
            this.Btn_CapNhat.Name = "Btn_CapNhat";
            this.Btn_CapNhat.Size = new System.Drawing.Size(130, 34);
            this.Btn_CapNhat.TabIndex = 1;
            this.Btn_CapNhat.Text = "Cập nhật";
            this.Btn_CapNhat.UseVisualStyleBackColor = true;
            this.Btn_CapNhat.Click += new System.EventHandler(this.Btn_CapNhat_Click);
            // 
            // Btn_XuLy
            // 
            this.Btn_XuLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_XuLy.Location = new System.Drawing.Point(275, 103);
            this.Btn_XuLy.Name = "Btn_XuLy";
            this.Btn_XuLy.Size = new System.Drawing.Size(130, 34);
            this.Btn_XuLy.TabIndex = 2;
            this.Btn_XuLy.Text = "Xử lý";
            this.Btn_XuLy.UseVisualStyleBackColor = true;
            this.Btn_XuLy.Click += new System.EventHandler(this.Btn_XuLy_Click);
            // 
            // Btn_BaoCao
            // 
            this.Btn_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_BaoCao.Location = new System.Drawing.Point(139, 183);
            this.Btn_BaoCao.Name = "Btn_BaoCao";
            this.Btn_BaoCao.Size = new System.Drawing.Size(130, 34);
            this.Btn_BaoCao.TabIndex = 3;
            this.Btn_BaoCao.Text = "Báo cáo";
            this.Btn_BaoCao.UseVisualStyleBackColor = true;
            // 
            // Btn_KetThuc
            // 
            this.Btn_KetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_KetThuc.Location = new System.Drawing.Point(275, 183);
            this.Btn_KetThuc.Name = "Btn_KetThuc";
            this.Btn_KetThuc.Size = new System.Drawing.Size(130, 34);
            this.Btn_KetThuc.TabIndex = 4;
            this.Btn_KetThuc.Text = "Kết thúc";
            this.Btn_KetThuc.UseVisualStyleBackColor = true;
            this.Btn_KetThuc.Click += new System.EventHandler(this.Btn_KetThuc_Click);
            // 
            // QLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 304);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QLBanHang";
            this.Text = "Quản lý bán hàng";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button Btn_CapNhat;
        private Button Btn_XuLy;
        private Button Btn_BaoCao;
        private Button Btn_KetThuc;
    }
}