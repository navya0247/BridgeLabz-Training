namespace HealthClinicApp.Entities
{
    
    internal class Appointment
    {
        public int AppointmentId { get; set; }      
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }

        //  constructor 
        public Appointment(int patientId, int doctorId, DateTime appointmentDate, string status)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentDate = appointmentDate;
            Status = status;
        }

        public override string ToString()
        {
            return "ID: " + AppointmentId + ", Patient: " + PatientId + ", Doctor: " + DoctorId + ", Date: " + AppointmentDate.ToShortDateString() + ", Status: " + Status;
        }
    }
}