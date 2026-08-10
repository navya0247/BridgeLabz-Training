using Microsoft.Data.SqlClient;

namespace ContactsApp.Repository
{
    // only job: hand out a ready connection whenever a repository needs one
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