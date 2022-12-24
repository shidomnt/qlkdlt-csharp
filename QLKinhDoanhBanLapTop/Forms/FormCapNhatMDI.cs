using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.Helpers;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class FormCapNhatMDI : Form
    {
        private QLKDLTContext Context { get; set; }

        public FormCapNhatMDI(QLKDLTContext context)
        {
            InitializeComponent();

            Context = context;

        }

        private void Btn_Hang_Click(object sender, EventArgs e)
        {
            var form_QLHang = new QLHang(Context);
            form_QLHang.ShowDialog();
        }

        private void Btn_KhachHang_Click(object sender, EventArgs e)
        {
            var form_QLKH = new QLKhachHang(Context);
            form_QLKH.ShowDialog();
        }

        private void Btn_PhThuChi_Click(object sender, EventArgs e)
        {
            var form_QLPhThuChi = new QLPhieuThuChi(Context);
            form_QLPhThuChi.ShowDialog();
        }

        private void Btn_HoaDon_Click(object sender, EventArgs e)
        {
            var form_thanhToan = new QLHoaDon(Context);
            form_thanhToan.ShowDialog();
        }

        private void Btn_ChiTietHD_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Vui lòng xem chi tiết hóa đơn tại giao diện Form Hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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