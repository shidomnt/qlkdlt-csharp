using QLKinhDoanhBanLapTop.Classes;
using QLKinhDoanhBanLapTop.Helpers;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class FormCapNhatMDI : Form
    {
        public FormCapNhatMDI()
        {
            InitializeComponent();

        }

        private void Btn_Hang_Click(object sender, EventArgs e)
        {
            var form_QLHang = new QLHang();
            form_QLHang.ShowDialog();
        }

        private void Btn_KhachHang_Click(object sender, EventArgs e)
        {
            var form_QLKH = new QLKhachHang();
            form_QLKH.ShowDialog();
        }

        private void Btn_PhThuChi_Click(object sender, EventArgs e)
        {
            var form_QLPhThuChi = new QLPhieuThuChi();
            form_QLPhThuChi.ShowDialog();
        }

        private void Btn_HoaDon_Click(object sender, EventArgs e)
        {
            var form_thanhToan = new QLHoaDon();
            form_thanhToan.ShowDialog();
        }

        private void Btn_ChiTietHD_Click(object sender, EventArgs e)
        {
            var message =
                "Vui lòng xem chi tiết hóa đơn tại giao diện Form Hóa đơn";
            var result = Notification.Show(
                message,
                MessageBoxButtons.OKCancel
                );
            if (result == DialogResult.OK)
            {
                Btn_HoaDon.PerformClick();
            }
        }

        private void Btn_KetThuc_Click(object sender, EventArgs e)
        {
            FormHelpers.Close(this);
        }
    }
}