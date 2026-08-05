using Microsoft.Data.SqlClient;
using System.Data;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Service
{
    internal class DoctorService
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // ---------------- ADD ----------------
        // stored procedure sp_InsertDoctor -> trg_Doctor_Insert fires automatically
        public void AddDoctor(Doctor doctor)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand cmd = new SqlCommand("sp_InsertDoctor", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", doctor.FirstName);
            cmd.Parameters.AddWithValue("@LastName", doctor.LastName);
            cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            cmd.Parameters.AddWithValue("@Phone", doctor.Phone);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // ---------------- VIEW ALL ----------------
        // connected read, prints directly, no List<> used
        public void ViewAllDoctors()
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand cmd = new SqlCommand("SELECT * FROM Doctor", connection);

            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- All Doctors ---");
            while (reader.Read())
            {
                Doctor doctor = new Doctor(
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    reader["Specialization"].ToString(),
                    reader["Phone"].ToString()
                );
                doctor.DoctorId = (int)reader["DoctorId"];   // set after construction, since constructor has no ID
                Console.WriteLine(doctor);
            }
        }

        // ---------------- UPDATE ----------------
        // Takes the field choice + new value directly, so Menu has zero decision-making
        // fieldChoice: 1 = Specialization, 2 = Phone
        // stored procedure sp_UpdateDoctor -> trg_Doctor_Update fires automatically
        public bool UpdateDoctor(int doctorId, int fieldChoice, string newValue)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT * FROM Doctor WHERE DoctorId = @DoctorId", connection);
            checkCmd.Parameters.AddWithValue("@DoctorId", doctorId);

            connection.Open();
            using SqlDataReader reader = checkCmd.ExecuteReader();

            if (!reader.Read())
            {
                return false;   // doctor not found, nothing updated
            }

            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string specialization = reader["Specialization"].ToString();
            string phone = reader["Phone"].ToString();
            reader.Close();

            // only change the field the user picked, keep everything else as-is
            if (fieldChoice == 1) specialization = newValue;
            if (fieldChoice == 2) phone = newValue;

            using SqlCommand updateCmd = new SqlCommand("sp_UpdateDoctor", connection);
            updateCmd.CommandType = CommandType.StoredProcedure;
            updateCmd.Parameters.AddWithValue("@DoctorId", doctorId);
            updateCmd.Parameters.AddWithValue("@FirstName", firstName);
            updateCmd.Parameters.AddWithValue("@LastName", lastName);
            updateCmd.Parameters.AddWithValue("@Specialization", specialization);
            updateCmd.Parameters.AddWithValue("@Phone", phone);
            updateCmd.ExecuteNonQuery();

            return true;
        }

        // ---------------- DELETE ----------------
        // stored procedure sp_DeleteDoctor -> trg_Doctor_Delete fires automatically
        public bool DeleteDoctor(int doctorId)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Doctor WHERE DoctorId = @DoctorId", connection);
            checkCmd.Parameters.AddWithValue("@DoctorId", doctorId);

            connection.Open();
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                return false;   // doctor not found, nothing deleted
            }

            using SqlCommand deleteCmd = new SqlCommand("sp_DeleteDoctor", connection);
            deleteCmd.CommandType = CommandType.StoredProcedure;
            deleteCmd.Parameters.AddWithValue("@DoctorId", doctorId);
            deleteCmd.ExecuteNonQuery();

            return true;
        }
    }
}