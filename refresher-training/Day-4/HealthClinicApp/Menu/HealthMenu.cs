using HealthClinicApp.Entities;
using HealthClinicApp.Service;

namespace HealthClinicApp.Menu
{
    internal class HealthMenu
    {
        private readonly DoctorService doctorService = new DoctorService();
        private readonly PatientService patientService = new PatientService();
        private readonly AppointmentService appointmentService = new AppointmentService();

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n===== Health Clinic App =====");
                Console.WriteLine("1. Doctor Menu");
                Console.WriteLine("2. Patient Menu");
                Console.WriteLine("3. Appointment Menu");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1": DoctorMenu(); break;
                    case "2": PatientMenu(); break;
                    case "3": AppointmentMenu(); break;
                    case "0": exit = true; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }

        // ---------------- DOCTOR SUBMENU ----------------
        private void DoctorMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n--- Doctor Menu ---");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. View All Doctors");
                Console.WriteLine("3. Update Doctor");
                Console.WriteLine("4. Delete Doctor");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("First Name: ");
                         string fn = Console.ReadLine();
                        Console.Write("Last Name: "); 
                        string ln = Console.ReadLine();
                        Console.Write("Specialization: ");
                         string spec = Console.ReadLine();
                        Console.Write("Phone: "); 
                        string phone = Console.ReadLine();
                        doctorService.AddDoctor(new Doctor(fn, ln, spec, phone));
                        Console.WriteLine("Doctor added successfully.");
                        break;

                    case "2":
                        doctorService.ViewAllDoctors();
                        break;

                    case "3":
                        Console.Write("Doctor ID: "); 
                        int updateId = int.Parse(Console.ReadLine());
                        Console.WriteLine("1. Update Specialization");
                        Console.WriteLine("2. Update Phone");
                        Console.Write("Choose field: ");
                         int fieldChoice = int.Parse(Console.ReadLine());
                        Console.Write("New Value: "); 
                        string newValue = Console.ReadLine();
                        bool updated = doctorService.UpdateDoctor(updateId, fieldChoice, newValue);
                        Console.WriteLine(updated ? "Doctor updated successfully." : "Doctor not found.");
                        break;

                    case "4":
                        Console.Write("Doctor ID: "); 
                        int deleteId = int.Parse(Console.ReadLine());
                        bool deleted = doctorService.DeleteDoctor(deleteId);
                        Console.WriteLine(deleted ? "Doctor deleted successfully." : "Doctor not found.");
                        break;

                    case "0": back = true; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }

        // ---------------- PATIENT SUBMENU ----------------
        private void PatientMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n--- Patient Menu ---");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View All Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("First Name: "); 
                        string fn = Console.ReadLine();
                        Console.Write("Last Name: "); 
                        string ln = Console.ReadLine();
                        Console.Write("Date of Birth (yyyy-mm-dd): ");
                         DateTime dob = DateTime.Parse(Console.ReadLine());
                        Console.Write("Phone: "); 
                        string phone = Console.ReadLine();
                        Console.Write("Address: ");
                         string address = Console.ReadLine();
                        Console.Write("Gender (M/F): ");
                         char gender = Convert.ToChar(Console.ReadLine());
                        patientService.AddPatient(new Patient(fn, ln, dob, phone, address, gender));
                        Console.WriteLine("Patient added successfully.");
                        break;

                    case "2":
                        patientService.ViewAllPatients();
                        break;

                    case "3":
                        Console.Write("Patient ID: ");
                         int updateId = int.Parse(Console.ReadLine());
                        Console.WriteLine("1. Update Phone");
                        Console.WriteLine("2. Update Address");
                        Console.Write("Choose field: ");
                         int fieldChoice = int.Parse(Console.ReadLine());
                        Console.Write("New Value: ");
                         string newValue = Console.ReadLine();
                        bool updated = patientService.UpdatePatient(updateId, fieldChoice, newValue);
                        Console.WriteLine(updated ? "Patient updated successfully." : "Patient not found.");
                        break;

                    case "4":
                        Console.Write("Patient ID: "); 
                        int deleteId = int.Parse(Console.ReadLine());
                        bool deleted = patientService.DeletePatient(deleteId);
                        Console.WriteLine(deleted ? "Patient deleted successfully." : "Patient not found.");
                        break;

                    case "0": back = true; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }

        // ---------------- APPOINTMENT SUBMENU ----------------
        private void AppointmentMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n--- Appointment Menu ---");
                Console.WriteLine("1. Book Appointment");
                Console.WriteLine("2. View All Appointments");
                Console.WriteLine("3. Update Appointment Status");
                Console.WriteLine("4. Delete Appointment");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Patient ID: "); 
                        int pid = int.Parse(Console.ReadLine());
                        Console.Write("Doctor ID: "); 
                        int did = int.Parse(Console.ReadLine());
                        Console.Write("Appointment Date (yyyy-mm-dd): ");
                         DateTime date = DateTime.Parse(Console.ReadLine());
                        appointmentService.AddAppointment(new Appointment(pid, did, date, "Scheduled"));
                        Console.WriteLine("Appointment booked successfully.");
                        break;

                    case "2":
                        appointmentService.ViewAllAppointments();
                        break;

                    case "3":
                        Console.Write("Appointment ID: ");
                         int updateId = int.Parse(Console.ReadLine());
                        Console.Write("New Status (Scheduled/Completed/Cancelled): ");
                         string status = Console.ReadLine();
                        bool updated = appointmentService.UpdateAppointmentStatus(updateId, status);
                        Console.WriteLine(updated ? "Appointment updated successfully." : "Appointment not found.");
                        break;

                    case "4":
                        Console.Write("Appointment ID: ");
                         int deleteId = int.Parse(Console.ReadLine());
                        bool deleted = appointmentService.DeleteAppointment(deleteId);
                        Console.WriteLine(deleted ? "Appointment deleted successfully." : "Appointment not found.");
                        break;

                    case "0": back = true; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }
    }
}