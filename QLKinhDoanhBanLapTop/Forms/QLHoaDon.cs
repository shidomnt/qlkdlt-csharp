using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using System.ComponentModel;

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
                if (value == null)
                {
                    TextBox_SoHD.ReadOnly = false;
                }
                else
                {
                    TextBox_SoHD.ReadOnly = true;
                }

                _selectedHoaDon = value;
                OnSelectedHoaDonChanged(new EventArgs());
            }
        }

        private EventHandler<SavedChangesEventArgs>? SavedChangeEventHandler { get; set; }

        public QLHoaDon(QLKDLTContext context)
        {
            InitializeComponent();
            Context = context;


            ComboBox_LoaiHD.DataSource = Enum.GetValues(typeof(ELoaiHD));

            var listKH = Context.KhachHang
                .Select(khachhang => new { khachhang.MaKH, khachhang.TenKH })
                .ToList();
            if (listKH.Any())
            {
                ComboBox_MaKH.DataSource = listKH;
                ComboBox_MaKH.ValueMember = "MaKH";
                ComboBox_MaKH.DisplayMember = "TenKH";
            }
        }

        private void Btn_DSHang_Click(object sender, EventArgs e)
        {
            if (SelectedHoaDon == null)
            {
                MessageBox.Show("Chon 1 hoa don de xem chi tiet");
                return;
            }
            //var form_ThemHang = new DSHangThanhToan(Context);
            //if (ListHangThanhToan != null)
            //{
            //    form_ThemHang.ListHangThanhToan = new BindingList<HangThanhToan>(ListHangThanhToan);
            //}
            //var result = form_ThemHang.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    ListHangThanhToan = form_ThemHang.ListHangThanhToan.ToList();
            //    SaveDSHangThanhToan();
            //}
            var form_ChiTietHD = new QLChiTietHD(Context, SelectedHoaDon.SoHD);
            form_ChiTietHD.MdiParent = this.MdiParent;
            form_ChiTietHD.Show();
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                var hoaDon = HoaDonMakeFromTextBox();
                Context.ChangeTracker.Clear();
                Context.HoaDon.Add(hoaDon);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (SelectedHoaDon == null) return;


            try
            {
                SelectedHoaDon.SoHD = TextBox_SoHD.Text;
                SelectedHoaDon.NgayPS = DatePicker_Ngay.Value;
                SelectedHoaDon.SoTienTT = Convert.ToInt32(TextBox_SoTienTT.Text);
                SelectedHoaDon.LoaiHD = (ELoaiHD)ComboBox_LoaiHD.SelectedValue;
                SelectedHoaDon.MaKH = (string)ComboBox_MaKH.SelectedValue;

                Context.HoaDon.Update(SelectedHoaDon);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (SelectedHoaDon == null) return;
            try
            {
                Context.HoaDon.Remove(SelectedHoaDon);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void ThanhToan_Load(object sender, EventArgs e)
        {

            SavedChangeEventHandler = new(async (sender, e) =>
                await LoadContextHoaDonToGridView()
                );
            Context.SavedChanges += SavedChangeEventHandler;
            SelectedHoaDonChanged += (sender, e) => ExtractFromSelectedHoaDon();

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
            _ = int.TryParse(TextBox_SoTienTT.Text, out int soTienTT);
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
            void callback() => DataGridView_DSHoaDon.DataSource = Context.HoaDon.Local.ToBindingList();
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
                TextBox_SoHD.Text = SelectedHoaDon.SoHD;
                DatePicker_Ngay.Value = SelectedHoaDon.NgayPS;
                TextBox_SoTienTT.Text = SelectedHoaDon.SoTienTT.ToString();
                ComboBox_LoaiHD.SelectedValue = SelectedHoaDon.LoaiHD.ToString();
                ComboBox_MaKH.SelectedValue = SelectedHoaDon.MaKH;

            }
            catch (Exception) { }
        }

        private void QLKH_FormClosing(object sender, FormClosingEventArgs e)
            => Context.SavedChanges -= SavedChangeEventHandler;

    }
    public class HangThanhToan
    {
        [Browsable(false)]
        public string MaHang { get; set; } = string.Empty;

        public string TenHang { get; set; } = string.Empty;

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

    }
}
