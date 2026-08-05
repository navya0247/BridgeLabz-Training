namespace HealthClinicApp.Entities
{
    
    internal class Doctor
    {
        public int DoctorId { get; set; }         
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string Phone { get; set; }

        //  constructor 
        public Doctor(string firstName, string lastName, string specialization, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Specialization = specialization;
            Phone = phone;
        }

        public override string ToString()
        {
            return "ID: " + DoctorId + ", " + FirstName + " " + LastName + ", " + Specialization + ", " + Phone;
        }
    }
}