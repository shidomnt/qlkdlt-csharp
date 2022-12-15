using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.Forms;

namespace QLKinhDoanhBanLapTop
{
    internal partial class QLKD : Form
    {
        private QLKDLTContext Context { get; set; }

        private QLKH? Form_QLKH { get; set; } = null;

        public QLKD(QLKDLTContext context)
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

        public void Button_QLKH_Click(object sender, EventArgs eventArgs)
        {
            Form_QLKH ??= new(Context);
            if (Form_QLKH.IsDisposed)
            {
                Form_QLKH = new(Context);
            }
            Form_QLKH.Show();
        }
    }
}