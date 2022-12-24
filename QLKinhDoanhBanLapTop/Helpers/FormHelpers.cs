namespace QLKinhDoanhBanLapTop.Helpers
{
    internal static class FormHelpers
    {
        public static void Close<T>(T formInstance) where T : Form
        {
            var result = MessageBox.Show("Đóng Form ngay?", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                formInstance.Close();
            }
        }
    }
}
