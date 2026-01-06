using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{
    // interface for medical record related work
        interface IMedicalRecord
        {
            void AddRecord(string diagnosis);
            void ViewRecords();
        }

        // abstract base class
        abstract class Patient
        {
            // encapsulation using private fields
            private int patientId;
            private string name;
            private int age;

            public int PatientId
            {
                get { return patientId; }
                set { patientId = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            // abstract method
            public abstract double CalculateBill();

            // concrete method
            public void GetPatientDetails()
            {
                Console.WriteLine("Patient ID : " + PatientId);
                Console.WriteLine("Name       : " + Name);
                Console.WriteLine("Age        : " + Age);
            }
        }

        // inpatient class
        class InPatient : Patient, IMedicalRecord
        {
            // sensitive medical data
            private string diagnosis;
            public int DaysAdmitted { get; set; }
            public double DailyCharge { get; set; }

            public override double CalculateBill()
            {
                return DaysAdmitted * DailyCharge;
            }

            public void AddRecord(string record)
            {
                diagnosis = record;
            }

            public void ViewRecords()
            {
                Console.WriteLine("Diagnosis : " + diagnosis);
            }
        }

        // outpatient class
        class OutPatient : Patient, IMedicalRecord
        {
           
            private string diagnosis;
            public double ConsultationFee { get; set; }

            public override double CalculateBill()
            {
                return ConsultationFee;
            }

            public void AddRecord(string record)
            {
                diagnosis = record;
            }

            public void ViewRecords()
            {
                Console.WriteLine("Diagnosis : " + diagnosis);
            }
        }

        // main class
        internal class HospitalPatientManagement
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter number of patients: ");
                int count = int.Parse(Console.ReadLine());

                // array of Patient reference for polymorphism
                Patient[] patients = new Patient[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nEnter patient type (1-InPatient, 2-OutPatient): ");
                    int choice = int.Parse(Console.ReadLine());

                    Patient p;

                    if (choice == 1)
                    {
                        InPatient ip = new InPatient();

                        Console.Write("Enter days admitted: ");
                        ip.DaysAdmitted = int.Parse(Console.ReadLine());

                        Console.Write("Enter daily charge: ");
                        ip.DailyCharge = double.Parse(Console.ReadLine());

                        p = ip;
                    }
                    else
                    {
                        OutPatient op = new OutPatient();

                        Console.Write("Enter consultation fee: ");
                        op.ConsultationFee = double.Parse(Console.ReadLine());

                        p = op;
                    }

                    Console.Write("Enter patient id: ");
                    p.PatientId = int.Parse(Console.ReadLine());

                    Console.Write("Enter name: ");
                    p.Name = Console.ReadLine();

                    Console.Write("Enter age: ");
                    p.Age = int.Parse(Console.ReadLine());

                    Console.Write("Enter diagnosis: ");
                    string diag = Console.ReadLine();

                    if (p is IMedicalRecord record)
                    {
                        record.AddRecord(diag);
                    }

                    patients[i] = p;
                }

                Console.WriteLine("\nPatient details and billing");

                for (int i = 0; i < patients.Length; i++)
                {
                    patients[i].GetPatientDetails();

                    Console.WriteLine("Bill Amount : " + patients[i].CalculateBill());

                    if (patients[i] is IMedicalRecord record)
                    {
                        record.ViewRecords();
                    }

                    Console.WriteLine();
                }
            }
        }
    }

