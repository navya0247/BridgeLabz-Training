using Microsoft.Data.SqlClient;
using System.Data;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Service
{
    internal class DoctorService
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // ---------------- ADD DOCTOR (Stored Procedure) ----------------
        public void AddDoctor(Doctor doctor)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand cmd = new SqlCommand("sp_InsertDoctor", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", doctor.FirstName);
            cmd.Parameters.AddWithValue("@LastName", doctor.LastName);
            cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            cmd.Parameters.AddWithValue("@Phone", doctor.Phone);

            connection.Open(); // connected
            cmd.ExecuteNonQuery();
            connection.Close();
            // trg_Doctor_Insert fires automatically, logs into DoctorAudit
        }

        // ---------------- VIEW ALL DOCTORS - CONNECTED (Query) ----------------
        public void ViewAllDoctors()
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand cmd = new SqlCommand("SELECT * FROM Doctor", connection);

            connection.Open(); // connected - stays open while reading
            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n================== DOCTOR LIST (Connected) ==================");
            while (reader.Read())
            {
                Doctor doctor = new Doctor(
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    reader["Specialization"].ToString(),
                    reader["Phone"].ToString()
                );
                doctor.DoctorId = (int)reader["DoctorId"];
                Console.WriteLine(doctor);
            }
        }

        // ---------------- VIEW ALL DOCTORS - DISCONNECTED (DataAdapter + DataTable) ----------------
        public void ViewDoctorsDisconnected()
        {
            using SqlConnection connection = db.GetConnection();
            string query = "SELECT * FROM Doctor";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table); // opens, fetches all rows, closes automatically - connection not held open

            Console.WriteLine("\n================== DOCTOR LIST (Disconnected) ==================");
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"ID: {row["DoctorId"]} | Name: {row["FirstName"]} {row["LastName"]} | " +
                                   $"Specialization: {row["Specialization"]} | Phone: {row["Phone"]}");
            }
        }

        // ---------------- UPDATE DOCTOR ----------------
        // fieldChoice: 1 = Specialization, 2 = Phone
        public bool UpdateDoctor(int doctorId, int fieldChoice, string newValue)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT * FROM Doctor WHERE DoctorId = @DoctorId", connection);
            checkCmd.Parameters.AddWithValue("@DoctorId", doctorId);

            connection.Open();
            using SqlDataReader reader = checkCmd.ExecuteReader();

            if (!reader.Read())
            {
                return false; // doctor not found
            }

            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string specialization = reader["Specialization"].ToString();
            string phone = reader["Phone"].ToString();
            reader.Close();

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
            // trg_Doctor_Update fires automatically, logs into DoctorAudit

            return true;
        }

        // ---------------- DELETE DOCTOR ----------------
        public bool DeleteDoctor(int doctorId)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Doctor WHERE DoctorId = @DoctorId", connection);
            checkCmd.Parameters.AddWithValue("@DoctorId", doctorId);

            connection.Open();
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                return false; // doctor not found
            }

            using SqlCommand deleteCmd = new SqlCommand("sp_DeleteDoctor", connection);
            deleteCmd.CommandType = CommandType.StoredProcedure;
            deleteCmd.Parameters.AddWithValue("@DoctorId", doctorId);
            deleteCmd.ExecuteNonQuery();
            // trg_Doctor_Delete fires automatically, logs into DoctorAudit

            return true;
        }
    }
}