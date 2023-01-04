using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using System.ComponentModel;

namespace QLKinhDoanhBanLapTop.Forms
{
    public partial class FormXuLyMDI : Form
    {

        QLKDLTContext Context { get; }

        public FormXuLyMDI()
        {
            InitializeComponent();
            Context = new QLKDLTContextFactory().CreateDbContext(Array.Empty<string>());
        }

        private async void Btn_q1_Click(object sender, EventArgs e)
        {
            var result = await Context.Hang
                .Where(hang => hang.TenHang.Contains("laptop"))
                .ToListAsync();

            var source = new BindingList<Hang>(result);

            dataGridView1.DataSource = source;
            dataGridView1.Columns["TenHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async void Btn_q2_Click(object sender, EventArgs e)
        {
            var maKhachHang = string.Empty;
            var soLuongToiThieu = 0;
            var formGetParameterValue =
                new GetParameterValue("Nhap ma khach: ");
            if (formGetParameterValue.DialogResult == DialogResult.OK)
            {
                maKhachHang = formGetParameterValue.ParameterValue;
            }
            formGetParameterValue =
                new GetParameterValue("Nhap so luong toi thieu: ");
            if (formGetParameterValue.DialogResult == DialogResult.OK)
            {
                _ = int.TryParse(formGetParameterValue.ParameterValue, out int soLuong);
                soLuongToiThieu = soLuong;
            }
            var result = await Context.ChiTietHD
                .Include(chiTietHD => chiTietHD.HangNavigator)
                .Where(chiTietHD => chiTietHD.HoaDonNavigator.LoaiHDId == (char)ELoaiHD.Xuất)
                .Where(chiTietHD => chiTietHD.SoLuong > soLuongToiThieu)
                .Where(chiTietHD => chiTietHD.HoaDonNavigator.KhachHangNavigator.MaKH.Contains(maKhachHang))
                .Select(chiTietHD => new
                {
                    chiTietHD.HoaDonNavigator.MaKH,
                    chiTietHD.HangNavigator.TenHang,
                    chiTietHD.HoaDonNavigator.NgayPS,
                    chiTietHD.HangNavigator.DvTinh,
                    chiTietHD.Gia,
                    chiTietHD.SoLuong,
                    ThanhTien = chiTietHD.Gia * chiTietHD.SoLuong
                })
                .ToListAsync();

            //var source = new BindingList(result);

            dataGridView1.DataSource = result;

            dataGridView1.Columns["TenHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void Btn_q3_Click(object sender, EventArgs e)
        {
            var queryProduceData =
                Context.ChiTietHD
                .Select(chiTietHD => new
                {
                    chiTietHD.HangNavigator.TenHang,
                    Quy = chiTietHD.HoaDonNavigator.NgayPS.Date.ToString("M")
                });
        }
    }
}
