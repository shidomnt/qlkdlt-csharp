using QLKinhDoanhBanLapTop.Classes;

namespace QLKinhDoanhBanLapTop.Helpers
{
    internal static class FormHelpers
    {
        public static void Close<T>(T formInstance) where T : Form
        {
            var message = "Đóng Form ngay?";
            var result = Notification.Show(message, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                formInstance.Close();
            }
        }
    }
}
