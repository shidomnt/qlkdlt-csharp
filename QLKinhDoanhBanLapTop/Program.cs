using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QLKinhDoanhBanLapTop.EF;
using System.Reflection;

namespace QLKinhDoanhBanLapTop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!IsServerConnected())
            {
                MessageBox.Show("Không thể kết nối Database, chỉnh sửa file appsettings.json để thay đổi cấu hình kết nối Database", "Lỗi kết nối Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var context = new QLKDLTContextFactory().CreateDbContext(Array.Empty<string>());

            context.Database.Migrate();

            Application.Run(new QLBanHang(context));
        }

        public static bool IsServerConnected()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
                .AddJsonFile("appsettings.json").Build();

            using var l_oConnection = new SqlConnection(configuration["ConnectionStrings:DefaultConnection"]);
            try
            {
                l_oConnection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public static T Cast<T>(T typeHolder, object x)
        {
            return (T)x;
        }

    }
}