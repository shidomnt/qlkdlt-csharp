namespace QLKinhDoanhBanLapTop.Forms
{
    partial class FormXuLyMDI
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
            this.Btn_q1 = new System.Windows.Forms.Button();
            this.Btn_q2 = new System.Windows.Forms.Button();
            this.Btn_q3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Btn_q1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_q2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_q3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 445);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xử lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 5);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright - HaTQ - UDPM1K12";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_q1
            // 
            this.Btn_q1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_q1.Location = new System.Drawing.Point(129, 103);
            this.Btn_q1.Name = "Btn_q1";
            this.Btn_q1.Size = new System.Drawing.Size(120, 34);
            this.Btn_q1.TabIndex = 5;
            this.Btn_q1.Text = "Hàng laptop";
            this.Btn_q1.UseVisualStyleBackColor = true;
            this.Btn_q1.Click += new System.EventHandler(this.Btn_q1_Click);
            // 
            // Btn_q2
            // 
            this.Btn_q2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_q2.Location = new System.Drawing.Point(255, 103);
            this.Btn_q2.Name = "Btn_q2";
            this.Btn_q2.Size = new System.Drawing.Size(120, 34);
            this.Btn_q2.TabIndex = 6;
            this.Btn_q2.Text = "Liệt kê CTHĐ";
            this.Btn_q2.UseVisualStyleBackColor = true;
            this.Btn_q2.Click += new System.EventHandler(this.Btn_q2_Click);
            // 
            // Btn_q3
            // 
            this.Btn_q3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_q3.Location = new System.Drawing.Point(381, 103);
            this.Btn_q3.Name = "Btn_q3";
            this.Btn_q3.Size = new System.Drawing.Size(120, 34);
            this.Btn_q3.TabIndex = 7;
            this.Btn_q3.Text = "Tổng hợp";
            this.Btn_q3.UseVisualStyleBackColor = true;
            this.Btn_q3.Click += new System.EventHandler(this.Btn_q3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(627, 176);
            this.dataGridView1.TabIndex = 11;
            // 
            // FormXuLyMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormXuLyMDI";
            this.Text = "FormXuLyMDI";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button Btn_q1;
        private Button Btn_q2;
        private Button Btn_q3;
        private DataGridView dataGridView1;
    }
}