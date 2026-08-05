namespace HealthClinicApp.Entities
{
    
    internal class Patient
    {
        public int PatientId { get; set; }          
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }

        //  constructor 
        public Patient(string firstName, string lastName, DateTime dateOfBirth, string phone, string address, char gender)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Address = address;
            Gender = gender;
        }

        public override string ToString()
        {
            return "ID: " + PatientId + ", " + FirstName + " " + LastName + ", DOB: " + DateOfBirth.ToShortDateString() + ", " + Phone;
        }
    }
}