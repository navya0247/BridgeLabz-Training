using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Service
{
    internal class PatientService
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // ---------------- ADD ----------------
        public void AddPatient(Patient patient)
        {
            using SqlConnection connection = db.GetConnection();
            string query = "INSERT INTO Patient (FirstName, LastName, DateOfBirth, Phone, Address, Gender) " +
                            "VALUES (@FirstName, @LastName, @DateOfBirth, @Phone, @Address, @Gender)";
            using SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
            cmd.Parameters.AddWithValue("@LastName", patient.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
            cmd.Parameters.AddWithValue("@Phone", patient.Phone);
            cmd.Parameters.AddWithValue("@Address", patient.Address);
            cmd.Parameters.AddWithValue("@Gender", patient.Gender);

            connection.Open();
            cmd.ExecuteNonQuery();
            // trg_Patient_Insert fires automatically, logs to PatientAudit
        }

        // ---------------- VIEW ALL ----------------
        public void ViewAllPatients()
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand cmd = new SqlCommand("SELECT * FROM Patient", connection);

            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- All Patients ---");
            while (reader.Read())
            {
                Patient patient = new Patient(
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    (DateTime)reader["DateOfBirth"],
                    reader["Phone"].ToString(),
                    reader["Address"].ToString(),
                    Convert.ToChar(reader["Gender"])
                );
                patient.PatientId = (int)reader["PatientId"];
                Console.WriteLine(patient);
            }
        }

        // ---------------- UPDATE ----------------
        // fieldChoice: 1 = Phone, 2 = Address
        public bool UpdatePatient(int patientId, int fieldChoice, string newValue)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Patient WHERE PatientId = @PatientId", connection);
            checkCmd.Parameters.AddWithValue("@PatientId", patientId);

            connection.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0) return false;

            string column = fieldChoice == 1 ? "Phone" : "Address";
            string query = "UPDATE Patient SET " + column + " = @NewValue WHERE PatientId = @PatientId";
            using SqlCommand updateCmd = new SqlCommand(query, connection);
            updateCmd.Parameters.AddWithValue("@NewValue", newValue);
            updateCmd.Parameters.AddWithValue("@PatientId", patientId);
            updateCmd.ExecuteNonQuery();
            // trg_Patient_Update fires automatically, logs to PatientAudit

            return true;
        }

        // ---------------- DELETE ----------------
        public bool DeletePatient(int patientId)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Patient WHERE PatientId = @PatientId", connection);
            checkCmd.Parameters.AddWithValue("@PatientId", patientId);

            connection.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0) return false;

            using SqlCommand deleteCmd = new SqlCommand("DELETE FROM Patient WHERE PatientId = @PatientId", connection);
            deleteCmd.Parameters.AddWithValue("@PatientId", patientId);
            deleteCmd.ExecuteNonQuery();
            // trg_Patient_Delete fires automatically, logs to PatientAudit

            return true;
        }
    }
}