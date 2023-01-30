using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using QLKinhDoanhBanLapTop.Reports;
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
    internal partial class FormBaoCaoXuatHang : Form
    {
        public FormBaoCaoXuatHang()
        {
            InitializeComponent();
            Context = new QLKDLTContextFactory().CreateDbContext();
        }

        public QLKDLTContext Context { get; set; }

        private async void LayTTBaoCaoKhach_Load(object sender, EventArgs e)
        {
            var dsKhachHang = await Context.KhachHang.ToListAsync();

            if (dsKhachHang.Any())
            {
                CB_MaKhach.DataSource = dsKhachHang;
            }
            CB_MaKhach.ValueMember = nameof(KhachHang.MaKH);
            CB_MaKhach.DisplayMember = nameof(KhachHang.TenKH);
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (CB_MaKhach.SelectedItem is not KhachHang khachHang) return;

            var report = new ReportChiTietXuatHang(khachHang.MaKH, DTPicker_NgayBD.Value, DTPicker_NgayKT.Value);
            report.Show();
        }

        private void Btn_KetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
