using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Service
{
    internal class DatabaseConnection
    {
        private readonly string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=HealthCare;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}