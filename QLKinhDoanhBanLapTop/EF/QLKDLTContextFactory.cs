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
