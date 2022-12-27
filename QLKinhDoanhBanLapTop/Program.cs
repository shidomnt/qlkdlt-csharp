using Microsoft.EntityFrameworkCore;
using QLKinhDoanhBanLapTop.EF;

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

            using (var context = new QLKDLTContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                context.Database.Migrate();
            }


            Application.Run(new QLBanHang());
        }

    }
}