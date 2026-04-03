using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class Hospital
    {
            // Patient class 
            public class Patient
            {
                public string patientName;

                public Patient(string patientName)
                {
                    this.patientName = patientName;
                }
            }

            // Doctor class 
            public class Doctor
            {
                public string doctorName;
                public List<Patient> patients;   // association

                public Doctor(string doctorName)
                {
                    this.doctorName = doctorName;
                    patients = new List<Patient>();
                }

                public void Consult(Patient patient)
                {
                    patients.Add(patient);
                    Console.WriteLine("Doctor " + doctorName +
                                      " is consulting Patient " + patient.patientName);
                }
            }
            public static void Main(string[] args)
            {
                // Create doctors
                Doctor d1 = new Doctor("Dr.Yadav");
                Doctor d2 = new Doctor("Dr.Sharma");

                // Create patients
                Patient p1 = new Patient("Navya");
                Patient p2 = new Patient("Riya");

                d1.Consult(p1);
                d1.Consult(p2);

                d2.Consult(p1); 

                // Show doctor-patient relationships
                Console.WriteLine("\nConsultation Details:");

                Doctor[] doctors = { d1, d2 };

                for (int i = 0; i < doctors.Length; i++)
                {
                    Console.WriteLine("\nDoctor: " + doctors[i].doctorName);
                    Console.WriteLine("Patients Consulted:");

                    for (int j = 0; j < doctors[i].patients.Count; j++)
                    {
                        Console.WriteLine("- " + doctors[i].patients[j].patientName);
                    }
                }
            }
        }
    }
