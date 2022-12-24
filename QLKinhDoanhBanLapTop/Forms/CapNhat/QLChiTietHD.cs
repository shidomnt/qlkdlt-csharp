using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;

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

        public QLChiTietHD(QLKDLTContext context, string soHD)
        {
            InitializeComponent();
            Context = context;
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
                .Select(hang => new { hang.MaHang, hang.TenHang })
                .ToList();

            ComboBox_Hang.DataSource = listHang;
            ComboBox_Hang.DisplayMember = "TenHang";
            ComboBox_Hang.ValueMember = "MaHang";

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
            var selectedSoHD = selectedRow.Cells["SoHD"].Value.ToString();
            var selectedMaHang = selectedRow.Cells["MaHang"].Value.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (SelectedChiTietHD == null) return;
            _ = int.TryParse(TextBox_SoLuong.Text, out int soLuong);
            _ = int.TryParse(TextBox_DonGia.Text, out int donGia);
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
            _ = int.TryParse(TextBox_DonGia.Text, out int donGia);
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
            await Context.ChiTietHD.LoadAsync();
            void callback() => DataGridView_ChiTietHD.DataSource = Context.ChiTietHD
                .Local.ToBindingList()
                .Where(chiTietHD => chiTietHD.SoHD == ForSoHD)
                .ToList();
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
            TextBox_DonGia.Text = SelectedChiTietHD.Gia.ToString();
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
            var typeHolder = new { MaHang = "", TenHang = "" };
            var selectedHang = Program.Cast(typeHolder, combobox.SelectedItem);
            var selectedHangDonGia = Context.Hang
                .Where(hang => hang.MaHang == selectedHang.MaHang)
                .Select(hang => hang.DonGia);
            if (selectedHangDonGia.Any())
            {
                TextBox_DonGia.Text = selectedHangDonGia.First().ToString();
            }
        }
    }
}
