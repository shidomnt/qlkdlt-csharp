using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.Classes;
using QLKinhDoanhBanLapTop.EF.Models;

namespace QLKinhDoanhBanLapTop.EF
{
    internal class QLKDLTContext : DbContext
    {
        public QLKDLTContext(DbContextOptions<QLKDLTContext> options) : base(options)
        {
            SavedChanges += new EventHandler<SavedChangesEventArgs>((sender, e) =>
            {
                Notification.Show("Thay đổi đã được lưu vào Database", ENotifycationType.Successful);
            });

            SaveChangesFailed += new EventHandler<SaveChangesFailedEventArgs>((sender, e) =>
            {
                Notification.Show(e.Exception?.InnerException ?? e.Exception);
            });
        }

        public DbSet<KhachHang> KhachHang { get; set; }

        public DbSet<Hang> Hang { get; set; }

        public DbSet<HoaDon> HoaDon { get; set; }

        public DbSet<ChiTietHD> ChiTietHD { get; set; }

        public DbSet<PhThuChi> PhThuChi { get; set; }

    }
}
