using Microsoft.Data.SqlClient;
using ContactApp.Models;

namespace ContactApp.Repository
{
    public class ContactRepository
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // create table if it doesn't exist yet
        public void EnsureTableExists()
        {
            using SqlConnection connection = db.GetConnection();
            string query = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Contact' AND xtype='U')
                              CREATE TABLE Contact (
                                  ContactId INT IDENTITY(1,1) PRIMARY KEY,
                                  Name VARCHAR(50) NOT NULL,
                                  Phone VARCHAR(15) NOT NULL,
                                  Email VARCHAR(50)
                              )";
            using SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
        }

        // get all contacts
        public List<Contact> GetAll()
        {
            List<Contact> contacts = new List<Contact>();
            using SqlConnection connection = db.GetConnection();
            using SqlCommand cmd = new SqlCommand("SELECT * FROM Contact", connection);

            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contacts.Add(new Contact
                {
                    ContactId = (int)reader["ContactId"],
                    Name = reader["Name"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    Email = reader["Email"].ToString()
                });
            }
            return contacts;
        }

        // add a new contact
        public void Add(Contact contact)
        {
            using SqlConnection connection = db.GetConnection();
            string query = "INSERT INTO Contact (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", contact.Name);
            cmd.Parameters.AddWithValue("@Phone", contact.Phone);
            cmd.Parameters.AddWithValue("@Email", contact.Email);

            connection.Open();
            cmd.ExecuteNonQuery();
        }

        // update an existing contact
        public bool Update(int id, Contact contact)
        {
            using SqlConnection connection = db.GetConnection();
            string query = "UPDATE Contact SET Name=@Name, Phone=@Phone, Email=@Email WHERE ContactId=@Id";
            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", contact.Name);
            cmd.Parameters.AddWithValue("@Phone", contact.Phone);
            cmd.Parameters.AddWithValue("@Email", contact.Email);
            cmd.Parameters.AddWithValue("@Id", id);

            connection.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }

        // delete a contact
        public bool Delete(int id)
        {
            using SqlConnection connection = db.GetConnection();
            string query = "DELETE FROM Contact WHERE ContactId=@Id";
            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", id);

            connection.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
    }
}