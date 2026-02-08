
using System;
using Microsoft.Data.SqlClient;

class StudentConnection
{
    public static void Main(string[] args)
    {
        string query = "SELECT * FROM Books";

        string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            Console.WriteLine("Connection established");

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["BookID"].ToString() + " | " +
                    reader["Title"].ToString() + " | " +
                    reader["CategoryID"].ToString()
                );
            }

            reader.Close(); // optional
        } // connection auto closed
    }
}
