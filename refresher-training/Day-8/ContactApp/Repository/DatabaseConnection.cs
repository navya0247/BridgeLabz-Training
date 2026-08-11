using Microsoft.Data.SqlClient;

namespace ContactApp.Repository
{
    // SQL Server connection
    public class DatabaseConnection
    {
        private readonly string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=ContactsDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}