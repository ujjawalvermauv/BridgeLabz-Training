using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Data
{
    public class DbConnection
    {
        private static readonly string connectionString =
            @"Server=localhost\SQLEXPRESS;Database=HealthcareDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static string GetDbConnection()
        {
            return connectionString;
        }
    }
}