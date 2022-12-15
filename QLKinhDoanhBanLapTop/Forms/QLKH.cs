using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using System.Data;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class QLKH : Form
    {
        public event EventHandler? SelectedKhachHangChanged;

        private KhachHang? _selectedKhachhang = null;

        public QLKDLTContext Context { get; set; }

        public KhachHang? SelectedKhachHang {
            get 
            {
                return _selectedKhachhang;
            } 
            set
            {
                _selectedKhachhang = value;
                OnSelectedKhachHangChanged(new EventArgs());
            }
        }

        private EventHandler<SavedChangesEventArgs>? SavedChangeEventHandler { get; set; }

        public QLKH(QLKDLTContext context)
        {
            InitializeComponent();
            Context = context;
            SavedChangeEventHandler = new(async (sender, e) =>
                await LoadContextKHToGridView()
                );
            Context.SavedChanges += SavedChangeEventHandler;
            SelectedKhachHangChanged += (sender, e) => ExtractFromSelectedKhachHang();
        }

        private async void QLKH_Load(object sender, EventArgs e)
        {
            await LoadContextKHToGridView();
        }

        private void DataGridView_DSKH_SelectionChanged(object sender, EventArgs e)
        {
            var rowCount = DataGridView_DSKH.SelectedRows.Count;
            if (rowCount == 0)
            {
                SelectedKhachHang = null;
                return;
            }
            var selectedRow = DataGridView_DSKH.SelectedRows[0];
            var selectedMaKH = selectedRow.Cells["MaKH"].Value.ToString();
            SelectedKhachHang = Context.KhachHang
                .Where(khachHang => khachHang.MaKH == selectedMaKH)
                .First();
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            var khachHang = KhachHangMakeFromTextBox();
            Context.ChangeTracker.Clear();
            try
            {
                Context.KhachHang.Add(khachHang);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (SelectedKhachHang == null) return;
            SelectedKhachHang.MaKH = TextBox_MaKH.Text;
            SelectedKhachHang.TenKH = TextBox_TenKH.Text;
            SelectedKhachHang.DiaChi = TextBox_DiaChi.Text;
            SelectedKhachHang.SoDt = TextBox_SoDt.Text;
            try
            {
                Context.KhachHang.Update(SelectedKhachHang);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedKhachHang == null) return;
                Context.KhachHang.Remove(SelectedKhachHang);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private void Btn_ResetInput_Click(object sender, EventArgs e)
        {
            SelectedKhachHang = null;
        }

    }
}
