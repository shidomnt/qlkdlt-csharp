using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using QLKinhDoanhBanLapTop.Classes;
using QLKinhDoanhBanLapTop.Helpers;

namespace QLKinhDoanhBanLapTop.EF
{
    internal class QLKDLTContextFactory : IDesignTimeDbContextFactory<QLKDLTContext>
    {
        public QLKDLTContext CreateDbContext(string[] args)
        {
            if (!DatabaseHelpers.IsServerConnected())
            {
                var errorMessage = "Không thể kết nối Database, kiểm tra kết nối Database hoặc chỉnh sửa file appsettings.json để thay đổi cấu hình kết nối Database và thử lại";
                Notification.Show(new Exception(errorMessage));
                Application.Exit();
            }

            var configuration = DatabaseHelpers.GetConfiguration();

            var optionsBuilder = new DbContextOptionsBuilder<QLKDLTContext>();
            optionsBuilder
                .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

            return new QLKDLTContext(optionsBuilder.Options);
        }

        public QLKDLTContext CreateDbContext()
        => CreateDbContext(Array.Empty<string>());
    }
}
