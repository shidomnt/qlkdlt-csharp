using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using System.Data;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class QLPhieuThuChi : Form
    {
        public event EventHandler? SelectedPhThuChiChanged;

        private PhThuChi? _selectedPhThuChi = null;

        public QLKDLTContext Context { get; set; }

        public PhThuChi? SelectedPhThuChi
        {
            get
            {
                return _selectedPhThuChi;
            }
            set
            {
                _selectedPhThuChi = value;
                OnSelectedPhThuChiChanged(new EventArgs());
            }
        }

        private EventHandler<SavedChangesEventArgs>? SavedChangeEventHandler { get; set; }

        public QLPhieuThuChi(QLKDLTContext context)
        {
            InitializeComponent();
            Context = context;

        }

        private async void QLPhThuChi_Load(object sender, EventArgs e)
        {
            SavedChangeEventHandler = new(async (sender, e) =>
                await LoadContextKHToGridView()
                );
            Context.SavedChanges += SavedChangeEventHandler;
            SelectedPhThuChiChanged += (sender, e) => ExtractFromSelectedPhThuChi();

            var listMaKHAndTenKH =
                Context.KhachHang
                .Select(khachHang => new { khachHang.MaKH, khachHang.TenKH })
                .ToList();
            ComboBox_MaKH.ValueMember = "MaKH";
            ComboBox_MaKH.DisplayMember = "TenKH";
            ComboBox_MaKH.DataSource = listMaKHAndTenKH;

            ComboBox_LoaiPhieu.DataSource = Enum.GetValues(typeof(LoaiPh));

            await LoadContextKHToGridView();
        }

        private void DataGridView_DSPhThuChi_SelectionChanged(object sender, EventArgs e)
        {
            var rowCount = DataGridView_DSPhThuChi.SelectedRows.Count;
            if (rowCount == 0)
            {
                SelectedPhThuChi = null;
                return;
            }
            var selectedRow = DataGridView_DSPhThuChi.SelectedRows[0];
            var selectedMa = selectedRow.Cells["SoPhieu"].Value.ToString();
            var queryPhThuChi = Context.PhThuChi
                .Where(PhThuChi => PhThuChi.SoPhieu == Convert.ToInt32(selectedMa));
            SelectedPhThuChi = queryPhThuChi.Any() ? queryPhThuChi.First() : null;
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            var PhThuChi = PhThuChiMakeFromTextBox();
            Context.ChangeTracker.Clear();
            try
            {
                Context.PhThuChi.Add(PhThuChi);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (SelectedPhThuChi == null) return;
            _ = int.TryParse(TextBox_SoTien.Text, out int soTien);
            _ = int.TryParse(TextBox_SoPhieu.Text, out int soPhieu);
            _ = Enum.TryParse(ComboBox_LoaiPhieu.SelectedValue.ToString(), out LoaiPh loaiPhieu);
            SelectedPhThuChi.SoPhieu = soPhieu;
            SelectedPhThuChi.Ngay = DatePicker_Ngay.Value;
            SelectedPhThuChi.SoTien = soTien;
            SelectedPhThuChi.LoaiPhieu = loaiPhieu;
            SelectedPhThuChi.MaKH = ComboBox_MaKH.SelectedValue.ToString() ?? string.Empty;

            try
            {
                Context.PhThuChi.Update(SelectedPhThuChi);
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
                if (SelectedPhThuChi == null) return;
                Context.PhThuChi.Remove(SelectedPhThuChi);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private void Btn_ResetInput_Click(object sender, EventArgs e)
        {
            SelectedPhThuChi = null;
        }

        private PhThuChi PhThuChiMakeFromTextBox()
        {
            _ = int.TryParse(TextBox_SoTien.Text, out int soTien);
            _ = int.TryParse(TextBox_SoPhieu.Text, out int soPhieu);
            _ = Enum.TryParse(ComboBox_LoaiPhieu.SelectedValue.ToString(), out LoaiPh loaiPhieu);
            PhThuChi PhThuChi = new()
            {
                SoPhieu = soPhieu,
                Ngay = DatePicker_Ngay.Value,
                SoTien = soTien,
                LoaiPhieu = loaiPhieu,
                MaKH = ComboBox_MaKH.SelectedValue.ToString() ?? string.Empty
            };
            return PhThuChi;
        }

        private async Task LoadContextKHToGridView()
        {
            await Context.PhThuChi.LoadAsync();
            void callback() => DataGridView_DSPhThuChi.DataSource = Context.PhThuChi.Local.ToBindingList();
            if (DataGridView_DSPhThuChi.InvokeRequired)
            {
                DataGridView_DSPhThuChi.Invoke(callback);
            }
            else
            {
                callback();
            }
        }

        protected virtual void OnSelectedPhThuChiChanged(EventArgs e)
        {
            SelectedPhThuChiChanged?.Invoke(this, e);
        }

        private void ExtractFromSelectedPhThuChi()
        {

            try
            {
                var selectedPhThuChi_MaKH = SelectedPhThuChi?.MaKH;
                var selectedPhThuChi_LoaiPhieu = SelectedPhThuChi?.LoaiPhieu;
                TextBox_SoPhieu.Text = SelectedPhThuChi?.SoPhieu.ToString();
                DatePicker_Ngay.Value = SelectedPhThuChi?.Ngay ?? DateTime.Now;
                TextBox_SoTien.Text = SelectedPhThuChi?.SoTien.ToString();
                var check = selectedPhThuChi_LoaiPhieu.ToString() == string.Empty;
                ComboBox_LoaiPhieu.SelectedValue =
                    check ? LoaiPh.Chi.ToString() : selectedPhThuChi_LoaiPhieu;
                if (selectedPhThuChi_MaKH != string.Empty)
                {
                    ComboBox_MaKH.SelectedValue = selectedPhThuChi_MaKH;
                }
            }
            catch (Exception) { }
        }

        private void QLKH_FormClosing(object sender, FormClosingEventArgs e)
            => Context.SavedChanges -= SavedChangeEventHandler;
    }
}
