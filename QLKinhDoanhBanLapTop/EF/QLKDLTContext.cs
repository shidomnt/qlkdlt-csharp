using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF.Models;

namespace QLKinhDoanhBanLapTop.EF
{
    internal class QLKDLTContext : DbContext
    {
        public QLKDLTContext(DbContextOptions<QLKDLTContext> options) : base(options) { }

        public DbSet<KhachHang> KhachHang { get; set; }

        public DbSet<Hang> Hang { get; set; }

        public DbSet<HoaDon> HoaDon { get; set; }

        public DbSet<ChiTietHD> ChiTietHD { get; set; }

        public DbSet<PhThuChi> PhThuChi { get; set; }

    }
}
