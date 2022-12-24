using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.Forms;
using QLKinhDoanhBanLapTop.Helpers;

namespace QLKinhDoanhBanLapTop
{
    internal partial class QLBanHang : Form
    {
        public QLKDLTContext Context { get; set; }

        public QLBanHang(QLKDLTContext context)
        {
            InitializeComponent();
            Context = context;
        }

        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            var formCapNhatMDI = new FormCapNhatMDI(Context);
            formCapNhatMDI.ShowDialog();
        }

        private void Btn_KetThuc_Click(object sender, EventArgs e)
        {
            FormHelpers.Close(this);
        }
    }
}
