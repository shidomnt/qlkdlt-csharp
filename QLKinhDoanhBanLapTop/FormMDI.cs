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

            Context.SavedChanges += new EventHandler<SavedChangesEventArgs>((sender, e) =>
            {
                MessageBox.Show("Thay đổi đã được lưu vào Database", "Thành công");
            });

            Context.SaveChangesFailed += new EventHandler<SaveChangesFailedEventArgs>((sender, e) =>
            {
                MessageBox.Show(
                    e.Exception?.InnerException?.Message ?? e?.Exception?.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            });
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
            var form_thanhToan = new ThanhToan(Context);
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