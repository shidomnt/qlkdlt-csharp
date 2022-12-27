using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace QLKinhDoanhBanLapTop.Helpers
{
    internal static class DatabaseHelpers
    {
        public static bool IsServerConnected()
        {
            var configuration = GetConfiguration();

            using var l_oConnection = new SqlConnection(
                configuration["ConnectionStrings:DefaultConnection"]
                );
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

        public static IConfigurationRoot GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
                .AddJsonFile("appsettings.json").Build();
        }
    }
}
