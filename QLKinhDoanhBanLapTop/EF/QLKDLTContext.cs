using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF.Models;

namespace QLKinhDoanhBanLapTop.EF
{
    internal class QLKDLTContext : DbContext
    {
        public QLKDLTContext(DbContextOptions<QLKDLTContext> options) : base(options)
        {
            SavedChanges += new EventHandler<SavedChangesEventArgs>((sender, e) =>
            {
                MessageBox.Show("Thay đổi đã được lưu vào Database", "Thành công");
            });

            SaveChangesFailed += new EventHandler<SaveChangesFailedEventArgs>((sender, e) =>
            {
                MessageBox.Show(
                    e.Exception?.InnerException?.Message ?? e?.Exception?.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            });
        }

        public DbSet<KhachHang> KhachHang { get; set; }

        public DbSet<Hang> Hang { get; set; }

        public DbSet<HoaDon> HoaDon { get; set; }

        public DbSet<ChiTietHD> ChiTietHD { get; set; }

        public DbSet<PhThuChi> PhThuChi { get; set; }

    }
}
