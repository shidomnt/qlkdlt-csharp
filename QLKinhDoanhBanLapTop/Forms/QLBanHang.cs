using QLKinhDoanhBanLapTop.Forms;
using QLKinhDoanhBanLapTop.Helpers;

namespace QLKinhDoanhBanLapTop
{
    internal partial class QLBanHang : Form
    {
        public QLBanHang()
        {
            InitializeComponent();
        }

        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            var formCapNhatMDI = new FormCapNhatMDI();
            formCapNhatMDI.ShowDialog();
        }

        private void Btn_KetThuc_Click(object sender, EventArgs e)
        {
            FormHelpers.Close(this);
        }

        private void Btn_XuLy_Click(object sender, EventArgs e)
        {
            var formXuLy = new FormXuLyMDI();
            formXuLy.ShowDialog();
        }
    }
}
