using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
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
    internal partial class ThemHang : Form
    {
        public QLKDLTContext Context { get; set; }

        public HangThanhToan HangThanhToan { get; set; }

        public ThemHang(QLKDLTContext context)
        {
            InitializeComponent();
            Context = context;
            HangThanhToan = new();
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            var typeHolder = new { MaHang = "", TenHang = "" };
            var selectedHang = Program.Cast(typeHolder, ComboBox_TenHang.SelectedItem);
            HangThanhToan.MaHang = selectedHang.MaHang;
            HangThanhToan.TenHang = selectedHang.TenHang;
            HangThanhToan.DonGia = Convert.ToInt32(TextBox_DonGia.Text);
            HangThanhToan.SoLuong = Convert.ToInt32(TextBox_SoLuong.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ThemHang_Load(object sender, EventArgs e)
        {
            var listHang = Context.Hang
                .Select(hang => new { hang.MaHang, hang.TenHang })
                .ToList();
            ComboBox_TenHang.DataSource = listHang;
            ComboBox_TenHang.ValueMember = "TenHang";
            ComboBox_TenHang.DisplayMember = "TenHang";
        }
    }
}
