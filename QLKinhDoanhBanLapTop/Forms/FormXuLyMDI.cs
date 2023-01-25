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
                new GetParameterValue("Nhập mã khách: ");
            formGetParameterValue.ShowDialog();
            if (formGetParameterValue.DialogResult == DialogResult.OK)
            {
                maKhachHang = formGetParameterValue.ParameterValue;
            }
            formGetParameterValue =
                new GetParameterValue("Nhập số lượng tối thiểu: ");
            formGetParameterValue.ShowDialog();
            if (formGetParameterValue.DialogResult == DialogResult.OK)
            {
                _ = int.TryParse(formGetParameterValue.ParameterValue, out int soLuong);
                soLuongToiThieu = soLuong;
            }
            var result = await Context.ChiTietHD
                .Include(chiTietHD => chiTietHD.HangNavigator)
                .Where(chiTietHD => chiTietHD.HoaDonNavigator.LoaiHDId == (char)ELoaiHD.Xuất)
                .Where(chiTietHD => chiTietHD.SoLuong >= soLuongToiThieu)
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
            using var cmd =
                Context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = $@"SELECT
                        TenHang, [Quy1], [Quy2], [Quy3], [Quy4]
                        FROM
                        (
                            SELECT Hang.TenHang, CONCAT('Quy', DATEPART(q, NgayPS)) AS Quy, (ChiTietHD.Gia * ChiTietHD.SoLuong) AS ThanhTien FROM 
                            Hang INNER JOIN ChiTietHD 
                            ON Hang.MaHang = ChiTietHD.MaHang 
                            INNER JOIN HoaDon ON HoaDon.SoHD = ChiTietHD.SoHD
                        )
                        AS SourceQuery
                        PIVOT
                        (
                            SUM(ThanhTien)
                            FOR Quy
                            IN ([Quy1], [Quy2], [Quy3], [Quy4])
                        ) AS J;";
            Context.Database.OpenConnection();

            using var result = cmd.ExecuteReader();

            var source = new List<object>();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    dynamic obj = new
                    {
                        TenHang = result["TenHang"],
                        Quy1 = result["Quy1"],
                        Quy2 = result["Quy2"],
                        Quy3 = result["Quy3"],
                        Quy4 = result["Quy4"],
                    };
                    source.Add(obj);
                }
            }

            dataGridView1.DataSource = source;
        }
    }
}
