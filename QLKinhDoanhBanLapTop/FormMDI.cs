using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.Forms;

namespace QLKinhDoanhBanLapTop
{
    internal partial class FormMDI : Form
    {
        private QLKDLTContext Context { get; set; }

        public FormMDI(QLKDLTContext context)
        {
            InitializeComponent();

            Context = context;

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_QLKH = new QLKhachHang(Context);
            form_QLKH.MdiParent = this;
            form_QLKH.Show();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_QLHang = new QLHang(Context);
            form_QLHang.MdiParent = this;
            form_QLHang.Show();
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_thanhToan = new QLHoaDon(Context);
            form_thanhToan.MdiParent = this;
            form_thanhToan.Show();
        }

        private void phiếuThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_QLPhThuChi = new QLPhieuThuChi(Context);
            form_QLPhThuChi.MdiParent = this;
            form_QLPhThuChi.Show();
        }
    }
}