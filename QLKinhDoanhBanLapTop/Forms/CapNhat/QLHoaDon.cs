using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.Classes;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using QLKinhDoanhBanLapTop.Helpers;

namespace QLKinhDoanhBanLapTop.Forms
{
    internal partial class QLHoaDon : Form
    {
        public QLKDLTContext Context { get; set; }

        public event EventHandler? SelectedHoaDonChanged;

        private HoaDon? _selectedHoaDon = null;

        public HoaDon? SelectedHoaDon
        {
            get
            {
                return _selectedHoaDon;
            }
            set
            {
                _selectedHoaDon = value;
                OnSelectedHoaDonChanged(new EventArgs());
            }
        }

        private EventHandler<SavedChangesEventArgs>? SavedChangeEventHandler { get; set; }

        public QLHoaDon()
        {
            InitializeComponent();
            Context =
                new QLKDLTContextFactory().CreateDbContext(Array.Empty<string>());

        }

        private void Btn_ChiTietHD_Click(object sender, EventArgs e)
        {
            if (SelectedHoaDon == null)
            {
                var message = "Hãy chọn 1 hóa đơn để xem chi tiết";
                Notification.Show(message);
                return;
            }
            var form_ChiTietHD = new QLChiTietHD(SelectedHoaDon.SoHD);
            form_ChiTietHD.ShowDialog();
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            var hoaDon = HoaDonMakeFromTextBox();
            try
            {
                Context.HoaDon.Add(hoaDon);
                await Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Context.HoaDon.Entry(hoaDon).State = EntityState.Detached;
                Notification.Show(ex);
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (SelectedHoaDon == null) return;


            try
            {
                SelectedHoaDon.NgayPS = DatePicker_Ngay.Value;
                SelectedHoaDon.SoTienTT = ConvertHelpers.DeFormatCurrency(TextBox_SoTienTT.Text);
                SelectedHoaDon.LoaiHD = (ELoaiHD)ComboBox_LoaiHD.SelectedValue;
                SelectedHoaDon.MaKH = (string)ComboBox_MaKH.SelectedValue;

                await Context.SaveChangesAsync();
            }
            catch (Exception ex) { Notification.Show(ex); }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (SelectedHoaDon == null) return;
            try
            {
                Context.HoaDon.Remove(SelectedHoaDon);
                await Context.SaveChangesAsync();
            }
            catch (Exception ex) { Notification.Show(ex); }
        }

        private async void QLHoaDon_Load(object sender, EventArgs e)
        {

            SavedChangeEventHandler = new(async (sender, e) =>
                await LoadContextHoaDonToGridView()
                );
            Context.SavedChanges += SavedChangeEventHandler;
            SelectedHoaDonChanged += (sender, e) => ExtractFromSelectedHoaDon();
            SelectedHoaDonChanged += (sender, e) => TextBox_SoHD.ReadOnly = SelectedHoaDon != null;
            SelectedHoaDonChanged += (sender, e) => Btn_Them.Enabled = SelectedHoaDon == null;

            ComboBox_LoaiHD.DataSource = Enum.GetValues(typeof(ELoaiHD));

            var listKH = Context.KhachHang
                .Select(khachhang => new { khachhang.MaKH, khachhang.TenKH })
                .ToList();
            if (listKH.Any())
            {
                ComboBox_MaKH.DataSource = listKH;
                ComboBox_MaKH.ValueMember = nameof(KhachHang.MaKH);
                ComboBox_MaKH.DisplayMember = nameof(KhachHang.TenKH);
            }

            TextBox_SoTienTT.Text = "0";

            await LoadContextHoaDonToGridView();
        }

        private void Btn_ResetInput_Click(object sender, EventArgs e)
        {
            SelectedHoaDon = null;
        }

        private void DataGridView_DSHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            var rowCount = DataGridView_DSHoaDon.SelectedRows.Count;
            if (rowCount == 0)
            {
                SelectedHoaDon = null;
                return;
            }

            var selectedRow = DataGridView_DSHoaDon.SelectedRows[0];
            var selectedMa = selectedRow.Cells["SoHD"].Value.ToString();
            var queryHoaDon = Context.HoaDon
                .Where(HoaDon => HoaDon.SoHD == selectedMa);
            SelectedHoaDon = queryHoaDon.Any() ? queryHoaDon.First() : null;
        }

        private HoaDon HoaDonMakeFromTextBox()
        {
            _ = Enum.TryParse(ComboBox_LoaiHD.SelectedValue.ToString(), out ELoaiHD loaiHD);
            var soTienTT = ConvertHelpers.DeFormatCurrency(TextBox_SoTienTT.Text);
            var hoaDon = new HoaDon()
            {
                SoHD = TextBox_SoHD.Text,
                NgayPS = DatePicker_Ngay.Value,
                SoTienTT = soTienTT,
                LoaiHD = loaiHD,
                MaKH = ComboBox_MaKH.SelectedValue.ToString() ?? string.Empty,
            };

            return hoaDon;
        }
        private async Task LoadContextHoaDonToGridView()
        {
            await Context.HoaDon.LoadAsync();
            void callback() => DataGridView_DSHoaDon.DataSource =
                Context.HoaDon.Local.ToBindingList();
            if (DataGridView_DSHoaDon.InvokeRequired)
            {
                DataGridView_DSHoaDon.Invoke(callback);
            }
            else
            {
                callback();
            }

        }

        protected virtual void OnSelectedHoaDonChanged(EventArgs e)
        {
            SelectedHoaDonChanged?.Invoke(this, e);
        }

        private void ExtractFromSelectedHoaDon()
        {
            if (SelectedHoaDon == null)
                return;
            try
            {
                var selectedIndex = ComboBox_LoaiHD.FindStringExact(SelectedHoaDon.LoaiHD.ToString());
                TextBox_SoHD.Text = SelectedHoaDon.SoHD;
                DatePicker_Ngay.Value = SelectedHoaDon.NgayPS;
                TextBox_SoTienTT.Text = ConvertHelpers.FormatCurrency(SelectedHoaDon.SoTienTT);
                ComboBox_LoaiHD.SelectedIndex = selectedIndex;
                ComboBox_MaKH.SelectedValue = SelectedHoaDon.MaKH;

            }
            catch (Exception) { }
        }

        private void QLHoaDon_FormClosing(object sender, FormClosingEventArgs e)
            => Context.SavedChanges -= SavedChangeEventHandler;

        private void TextBox_SoTienTT_Enter(object sender, EventArgs e)
        {
            TextBox_SoTienTT.Text = ConvertHelpers.DeFormatCurrency(TextBox_SoTienTT.Text).ToString();
        }

        private void TextBox_SoTienTT_Leave(object sender, EventArgs e)
        {
            _ = int.TryParse(TextBox_SoTienTT.Text, out int soTienTT);
            TextBox_SoTienTT.Text = ConvertHelpers.FormatCurrency(soTienTT);
        }
    }
}
