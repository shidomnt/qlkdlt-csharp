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

            //var configuration = new ConfigurationBuilder()
            //    .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
            //    .AddJsonFile("appsettings.json").Build();

            //var connectionString = configuration["ConnectionStrings:DefaultConnection"];

            //var databaseName = connectionString?.Split(';')[1];


            //SqlConnection connection = new(connectionString);

            //if (!IsDatabaseExists(connection))
            //{
            //    CreateDatabase(connection, databaseName);
            //}

            var context = new QLKDLTContextFactory().CreateDbContext(Array.Empty<string>());

            context.Database.Migrate();

            Application.Run(new QLKD(context));
        }
        static bool IsDatabaseExists(SqlConnection connection)
        {
            string sqlQuery =
                @$"SELECT database_id 
                FROM sys.databases 
                WHERE Name = 'master'";
            bool result = false;
            try
            {
                var command = connection.CreateCommand();
                command.CommandText = sqlQuery;
                connection.Open();
                var resultObj = command.ExecuteScalar();
                int databaseID = 0;

                if (resultObj != null)
                {
                    int.TryParse(resultObj.ToString(), out databaseID);
                }

                connection.Close();

                result = (databaseID > 0);
            } catch (Exception)
            {
            }
            return result;
        }

        static void CreateDatabase(SqlConnection connection, string? databaseName = "QLKDBLT")
        {
            string sqlQuery =
                @$"CREATE DATABASE {databaseName}";
            var command = connection.CreateCommand();
            command.CommandText = sqlQuery;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi tạo Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
    }
}