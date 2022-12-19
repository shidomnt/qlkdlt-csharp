﻿using QLKinhDoanhBanLapTop.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class DSHangThanhToan : Form
    {
        public BindingList<HangThanhToan> ListHangThanhToan { get; set; }

        public QLKDLTContext Context { get; set; }

        public DSHangThanhToan(QLKDLTContext context)
        {
            InitializeComponent();
            ListHangThanhToan = new();
            Context = context;
        }

        private void Btn_ChapNhan_Click(object sender, EventArgs e)
        {
            
            DialogResult= DialogResult.OK;
            Close();
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            var form_ThemHang = new ThemHang(Context);
            if (form_ThemHang.ShowDialog() == DialogResult.OK)
            {
                ListHangThanhToan.Add(form_ThemHang.HangThanhToan);
            }
        }

        private void DSHangThanhToan_Load(object sender, EventArgs e)
        {
            DataGridView_ThemHang.DataSource = ListHangThanhToan;
        }
    }
}
