using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF.Models;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class QLKH
    {

        private KhachHang KhachHangMakeFromTextBox()
        {
            KhachHang khachHang = new()
            {
                MaKH = TextBox_MaKH.Text,
                TenKH = TextBox_TenKH.Text,
                DiaChi = TextBox_DiaChi.Text,
                SoDt = TextBox_SoDt.Text,
            };
            return khachHang;
        }

        private async Task LoadContextKHToGridView()
        {
            await Context.KhachHang.LoadAsync();
            void callback() => DataGridView_DSKH.DataSource = Context.KhachHang.Local.ToBindingList();
            if (DataGridView_DSKH.InvokeRequired)
            {
                DataGridView_DSKH.Invoke(callback);
            }
            else
            {
                callback();
            }

        }

        protected virtual void OnSelectedKhachHangChanged(EventArgs e)
        {
            SelectedKhachHangChanged?.Invoke(this, e);
        }

        private void ExtractFromSelectedKhachHang()
        {
            TextBox_MaKH.Text = SelectedKhachHang?.MaKH;
            TextBox_TenKH.Text = SelectedKhachHang?.TenKH;
            TextBox_DiaChi.Text = SelectedKhachHang?.DiaChi;
            TextBox_SoDt.Text = SelectedKhachHang?.SoDt;
        }

        private void QLKH_FormClosing(object sender, FormClosingEventArgs e)
            => Context.SavedChanges -= SavedChangeEventHandler;

    }
}
