using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using QLKinhDoanhBanLapTop.Helpers;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class QLChiTietHD : Form
    {
        public event EventHandler? SelectedChiTietHDChanged;

        private ChiTietHD? _selectedChiTietHD = null;

        public QLKDLTContext Context { get; set; }

        public string ForSoHD { get; set; }

        public ChiTietHD? SelectedChiTietHD
        {
            get
            {
                return _selectedChiTietHD;
            }
            set
            {
                _selectedChiTietHD = value;
                OnSelectedChiTietHDChanged(new EventArgs());
            }
        }

        private EventHandler<SavedChangesEventArgs>? SavedChangeEventHandler { get; set; }

        public QLChiTietHD(string soHD)
        {
            InitializeComponent();
            Context =
                new QLKDLTContextFactory().CreateDbContext(Array.Empty<string>());
            ForSoHD = soHD;
        }

        private async void QLChiTietHD_Load(object sender, EventArgs e)
        {
            SavedChangeEventHandler = new(async (sender, e) =>
                await LoadContextChiTietHDToGridView()
                );
            Context.SavedChanges += SavedChangeEventHandler;
            SelectedChiTietHDChanged += (sender, e) => ExtractFromSelectedChiTietHD();
            SelectedChiTietHDChanged += (sender, e) => ComboBox_Hang.Enabled = SelectedChiTietHD == null;

            var listHang = Context.Hang
                .Select(hang => new { hang.MaHang, hang.TenHang, hang.DonGia })
                .ToList();

            ComboBox_Hang.DataSource = listHang;
            ComboBox_Hang.DisplayMember = nameof(Hang.TenHang);
            ComboBox_Hang.ValueMember = nameof(Hang.MaHang);

            TextBox_SoHD.Text = ForSoHD;

            await LoadContextChiTietHDToGridView();
        }

        private void DataGridView_DSHang_SelectionChanged(object sender, EventArgs e)
        {
            var rowCount = DataGridView_ChiTietHD.SelectedRows.Count;
            if (rowCount == 0)
            {
                SelectedChiTietHD = null;
                return;
            }

            var selectedRow = DataGridView_ChiTietHD.SelectedRows[0];
            var selectedSoHD = selectedRow.Cells[nameof(HoaDon.SoHD)].Value.ToString();
            var selectedMaHang = selectedRow.Cells[nameof(Hang.MaHang)].Value.ToString();
            SelectedChiTietHD = Context.ChiTietHD
                .Where(chiTietHD => chiTietHD.SoHD == selectedSoHD && chiTietHD.MaHang == selectedMaHang)
                .First();
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            var ChiTietHD = ChiTietHDMakeFromTextBox();
            Context.ChangeTracker.Clear();
            try
            {
                Context.ChiTietHD.Add(ChiTietHD);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (SelectedChiTietHD == null) return;
            _ = int.TryParse(TextBox_SoLuong.Text, out int soLuong);
            var donGia = CurrencyHelpers.DeFormatCurrency(TextBox_DonGia.Text);
            SelectedChiTietHD.SoHD = TextBox_SoHD.Text;
            SelectedChiTietHD.MaHang = ComboBox_Hang.SelectedValue.ToString() ?? string.Empty;
            SelectedChiTietHD.SoLuong = soLuong;
            SelectedChiTietHD.Gia = donGia;
            try
            {
                Context.ChiTietHD.Update(SelectedChiTietHD);
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
                if (SelectedChiTietHD == null) return;
                Context.ChiTietHD.Remove(SelectedChiTietHD);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private void Btn_ResetInput_Click(object sender, EventArgs e)
        {
            SelectedChiTietHD = null;
        }

        private ChiTietHD ChiTietHDMakeFromTextBox()
        {
            _ = int.TryParse(TextBox_SoLuong.Text, out int soLuong);
            var donGia = CurrencyHelpers.DeFormatCurrency(TextBox_DonGia.Text);
            ChiTietHD ChiTietHD = new()
            {
                SoHD = TextBox_SoHD.Text,
                MaHang = ComboBox_Hang.SelectedValue.ToString() ?? string.Empty,
                SoLuong = soLuong,
                Gia = donGia,
            };
            return ChiTietHD;
        }
        private async Task LoadContextChiTietHDToGridView()
        {
            await Context.ChiTietHD
                .Where(chiTietHD => chiTietHD.SoHD == ForSoHD)
                .LoadAsync();
            void callback() => DataGridView_ChiTietHD.DataSource =
                Context.ChiTietHD.Local.ToBindingList();
            if (DataGridView_ChiTietHD.InvokeRequired)
            {
                DataGridView_ChiTietHD.Invoke(callback);
            }
            else
            {
                callback();
            }
        }

        protected virtual void OnSelectedChiTietHDChanged(EventArgs e)
        {
            SelectedChiTietHDChanged?.Invoke(this, e);
        }

        private void ExtractFromSelectedChiTietHD()
        {
            if (SelectedChiTietHD == null) return;
            TextBox_SoHD.Text = SelectedChiTietHD.SoHD;
            ComboBox_Hang.SelectedValue = SelectedChiTietHD.MaHang;
            TextBox_SoLuong.Text = SelectedChiTietHD.SoLuong.ToString();
            TextBox_DonGia.Text = CurrencyHelpers.FormatCurrency(SelectedChiTietHD.Gia);
        }

        private void QLChiTietHD_FormClosing(object sender, FormClosingEventArgs e)
            => Context.SavedChanges -= SavedChangeEventHandler;

        private void ComboBox_Hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox == null)
            {
                return;
            }
            var typeHolder = new { MaHang = "", TenHang = "", DonGia = 0 };
            var selectedHang = Program.Cast(typeHolder, combobox.SelectedItem);
            var donGiaGoc = selectedHang.DonGia;
            TextBox_DonGia.Text = CurrencyHelpers.FormatCurrency(donGiaGoc);
        }

        private void TextBox_DonGia_Enter(object sender, EventArgs e)
        {
            TextBox_DonGia.Text = CurrencyHelpers.DeFormatCurrency(TextBox_DonGia.Text).ToString();
        }

        private void TextBox_DonGia_Leave(object sender, EventArgs e)
        {
            _ = int.TryParse(TextBox_DonGia.Text, out int donGia);
            TextBox_DonGia.Text = CurrencyHelpers.FormatCurrency(donGia);
        }
    }
}
