using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.Classes;
using QLKinhDoanhBanLapTop.EF;
using QLKinhDoanhBanLapTop.EF.Models;
using QLKinhDoanhBanLapTop.Helpers;
using System.Data;

namespace QLKinhDoanhBanLapTop.Forms
{

    internal partial class QLHang : Form
    {
        public event EventHandler? SelectedHangChanged;

        private Hang? _selectedHang = null;

        public QLKDLTContext Context { get; set; }

        public Hang? SelectedHang
        {
            get
            {
                return _selectedHang;
            }
            set
            {
                _selectedHang = value;
                OnSelectedHangChanged(new EventArgs());
            }
        }

        private EventHandler<SavedChangesEventArgs>? SavedChangeEventHandler { get; set; }

        public QLHang()
        {
            InitializeComponent();
            Context =
                new QLKDLTContextFactory().CreateDbContext(Array.Empty<string>());

        }

        private async void QLH_Load(object sender, EventArgs e)
        {
            SavedChangeEventHandler = new(async (sender, e) =>
                await LoadContextKHToGridView()
                );
            Context.SavedChanges += SavedChangeEventHandler;
            SelectedHangChanged += (sender, e) => ExtractFromSelectedHang();
            SelectedHangChanged += (sender, e) => TextBox_MaHang.ReadOnly = SelectedHang != null;
            SelectedHangChanged += (sender, e) => Btn_Them.Enabled = SelectedHang == null;

            ComboBox_DvTinh.DataSource = Enum.GetValues(typeof(EDvTinh));

            await LoadContextKHToGridView();
        }

        private void DataGridView_DSKH_SelectionChanged(object sender, EventArgs e)
        {
            var rowCount = DataGridView_DSHang.SelectedRows.Count;
            if (rowCount == 0)
            {
                SelectedHang = null;
                return;
            }
            var selectedRow = DataGridView_DSHang.SelectedRows[0];
            var selectedMa = selectedRow.Cells["MaHang"].Value.ToString();
            var queryHang = Context.Hang
                .Where(Hang => Hang.MaHang == selectedMa);
            SelectedHang = queryHang.Any() ? queryHang.First() : null;
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            var Hang = HangMakeFromTextBox();
            //Context.ChangeTracker.Clear();
            try
            {
                Context.Hang.Add(Hang);
                await Context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Context.Hang.Entry(Hang).State = EntityState.Detached;
                Notification.Show(ex);
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (SelectedHang == null) return;
            var donGia = ConvertHelpers.DeFormatCurrency(TextBox_DonGia.Text);
            _ = Enum.TryParse(ComboBox_DvTinh.SelectedValue.ToString(), out EDvTinh dvTinh);
            //SelectedHang.MaHang = TextBox_MaHang.Text;
            SelectedHang.TenHang = TextBox_TenHang.Text;
            SelectedHang.DvTinh = dvTinh.ToString();
            SelectedHang.DonGia = donGia;
            try
            {
                //Context.Hang.Update(SelectedHang);
                await Context.SaveChangesAsync();
            }
            catch (Exception ex) { Notification.Show(ex); }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedHang == null) return;
                Context.Hang.Remove(SelectedHang);
                await Context.SaveChangesAsync();
            }
            catch (Exception ex) { Notification.Show(ex); }
        }

        private void Btn_ResetInput_Click(object sender, EventArgs e)
        {
            SelectedHang = null;
        }

        private Hang HangMakeFromTextBox()
        {
            var donGia = ConvertHelpers.DeFormatCurrency(TextBox_DonGia.Text);
            _ = Enum.TryParse(ComboBox_DvTinh.SelectedValue.ToString(), out EDvTinh dvTinh);
            Hang Hang = new()
            {
                MaHang = TextBox_MaHang.Text,
                TenHang = TextBox_TenHang.Text,
                DvTinh = dvTinh.ToString(),
                DonGia = donGia,
            };
            return Hang;
        }
        private async Task LoadContextKHToGridView()
        {
            await Context.Hang.LoadAsync();
            void callback() => DataGridView_DSHang.DataSource = Context.Hang.Local.ToBindingList();
            if (DataGridView_DSHang.InvokeRequired)
            {
                DataGridView_DSHang.Invoke(callback);
            }
            else
            {
                callback();
            }

        }

        protected virtual void OnSelectedHangChanged(EventArgs e)
        {
            SelectedHangChanged?.Invoke(this, e);
        }

        private void ExtractFromSelectedHang()
        {
            var dvTinhIndex = ComboBox_DvTinh.FindStringExact(SelectedHang?.DvTinh);
            TextBox_MaHang.Text = SelectedHang?.MaHang;
            TextBox_TenHang.Text = SelectedHang?.TenHang;
            ComboBox_DvTinh.SelectedIndex = dvTinhIndex > 0 ? dvTinhIndex : ((int)EDvTinh.Kg);
            TextBox_DonGia.Text = ConvertHelpers.FormatCurrency(SelectedHang?.DonGia ?? 0);
        }

        private void QLKH_FormClosing(object sender, FormClosingEventArgs e)
            => Context.SavedChanges -= SavedChangeEventHandler;

        enum EDvTinh
        {
            Kg,
            Cái,
            Chiếc,
            Lít,
            Tạ,
            Tấn
        }

        private void TextBox_DonGia_Enter(object sender, EventArgs e)
        {
            TextBox_DonGia.Text = ConvertHelpers.DeFormatCurrency(TextBox_DonGia.Text).ToString();
        }

        private void TextBox_DonGia_Leave(object sender, EventArgs e)
        {
            _ = int.TryParse(TextBox_DonGia.Text, out int donGia);
            TextBox_DonGia.Text = ConvertHelpers.FormatCurrency(donGia);
        }
    }
}
