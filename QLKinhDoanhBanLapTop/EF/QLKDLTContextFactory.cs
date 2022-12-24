using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace QLKinhDoanhBanLapTop.EF
{
    internal class QLKDLTContextFactory : IDesignTimeDbContextFactory<QLKDLTContext>
    {
        public QLKDLTContext CreateDbContext(string[] args)
        {
            if (!Program.IsServerConnected())
            {
                MessageBox.Show("Không thể kết nối Database, kiểm tra kết nối Database hoặc chỉnh sửa file appsettings.json để thay đổi cấu hình kết nối Database và thử lại",
                    "Lỗi kết nối Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
                .AddJsonFile("appsettings.json").Build();

            var optionsBuilder = new DbContextOptionsBuilder<QLKDLTContext>();
            optionsBuilder
                .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

            return new QLKDLTContext(optionsBuilder.Options);
        }
    }
}
