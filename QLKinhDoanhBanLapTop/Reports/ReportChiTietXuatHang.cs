using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QLKinhDoanhBanLapTop.Classes;
using QLKinhDoanhBanLapTop.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKinhDoanhBanLapTop.Reports
{
    internal partial class ReportChiTietXuatHang : Form
    {
        private readonly ReportViewer reportViewer;

        public ReportChiTietXuatHang(string maKH, DateTime ngayBD, DateTime ngayKT)
        {
            Text = "Report viewer";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            Context = new QLKDLTContextFactory().CreateDbContext();
            MaKH = maKH;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
        }

        public QLKDLTContext Context { get; set; }
        public string MaKH { get; }
        public DateTime NgayBD { get; }
        public DateTime NgayKT { get; }

        protected override async void OnLoad(EventArgs e)
        {

            var khachHang = await Context.KhachHang
                .Where(e => e.MaKH == MaKH)
                .FirstOrDefaultAsync();

            if (khachHang is null) return;

            var source = await Context.ChiTietHD
                .Where(e => e.HoaDonNavigator.MaKH == MaKH)
                .Where(e => e.HoaDonNavigator.NgayPS >= NgayBD)
                .Where(e => e.HoaDonNavigator.NgayPS <= NgayKT)
                .Select(e => new
                {
                    e.SoHD,
                    e.HangNavigator.TenHang,
                    e.Gia,
                    e.ThanhTien,
                    e.SoLuong,
                    e.HoaDonNavigator.KhachHangNavigator.TenKH,
                    e.HoaDonNavigator.NgayPS,
                }).ToListAsync();

            ReportHelper.Load(reportViewer.LocalReport, khachHang.TenKH, source, NgayBD, NgayKT);
            reportViewer.RefreshReport();
            //base.OnLoad(e);
        }
    }
}
