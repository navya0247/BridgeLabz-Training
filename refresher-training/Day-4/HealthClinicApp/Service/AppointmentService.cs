using Microsoft.Data.SqlClient;
using HealthClinicApp.Entities;

namespace HealthClinicApp.Service
{
    internal class AppointmentService
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // ---------------- ADD ----------------
        public void AddAppointment(Appointment appointment)
        {
            using SqlConnection connection = db.GetConnection();
            string query = "INSERT INTO Appointment (PatientId, DoctorId, AppointmentDate, Status) " +
                            "VALUES (@PatientId, @DoctorId, @AppointmentDate, @Status)";
            using SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
            cmd.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
            cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
            cmd.Parameters.AddWithValue("@Status", appointment.Status);

            connection.Open();
            cmd.ExecuteNonQuery();
            // trg_Appointment_Insert fires automatically, logs to AppointmentAudit
        }

        // ---------------- VIEW ALL ----------------
        public void ViewAllAppointments()
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand cmd = new SqlCommand("SELECT * FROM Appointment", connection);

            connection.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- All Appointments ---");
            while (reader.Read())
            {
                Appointment appointment = new Appointment(
                    (int)reader["PatientId"],
                    (int)reader["DoctorId"],
                    (DateTime)reader["AppointmentDate"],
                    reader["Status"].ToString()
                );
                appointment.AppointmentId = (int)reader["AppointmentId"];
                Console.WriteLine(appointment);
            }
        }

        // ---------------- UPDATE (status only) ----------------
        public bool UpdateAppointmentStatus(int appointmentId, string newStatus)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Appointment WHERE AppointmentId = @AppointmentId", connection);
            checkCmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

            connection.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0) return false;

            using SqlCommand updateCmd = new SqlCommand("UPDATE Appointment SET Status = @Status WHERE AppointmentId = @AppointmentId", connection);
            updateCmd.Parameters.AddWithValue("@Status", newStatus);
            updateCmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
            updateCmd.ExecuteNonQuery();
            // trg_Appointment_Update fires automatically, logs to AppointmentAudit

            return true;
        }

        // ---------------- DELETE ----------------
        public bool DeleteAppointment(int appointmentId)
        {
            using SqlConnection connection = db.GetConnection();
            using SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Appointment WHERE AppointmentId = @AppointmentId", connection);
            checkCmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

            connection.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0) return false;

            using SqlCommand deleteCmd = new SqlCommand("DELETE FROM Appointment WHERE AppointmentId = @AppointmentId", connection);
            deleteCmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
            deleteCmd.ExecuteNonQuery();
            // trg_Appointment_Delete fires automatically, logs to AppointmentAudit

            return true;
        }
    }
}