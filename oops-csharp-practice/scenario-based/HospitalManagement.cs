/*using System;
using System.Collections.Generic;
using System.Text;

class Patient
{
    protected int PatientId;
    protected string Name;
    protected int Age;
    public Patient(int patientId, string name, int age)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
    }
}
class InPatient : Patient
{
    int RoomNumber;
    int DaysAdmit;
    public InPatient(int patientId, string name, int age, int roomNumber, int daysAdmit)
       : base(patientId, name, age)
    {
        RoomNumber = roomNumber;
        DaysAdmit = daysAdmit;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}, roomNumber: {RoomNumber}, DaysAdmit: {DaysAdmit}");
    }
}
class Doctor
{
    int DoctorId;
    string Name;
    string Specialization;
    public Doctor(int doctorId, string name, string specialization)
    {
        DoctorId = doctorId;
        Name = name;
        Specialization = specialization;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Doctor ID: {DoctorId}, Name: {Name}, Specialization: {Specialization}");
    }
}
interface Ipayable
{
    double CalculateBill();
}
class Bill : Ipayable
{
    double amount;
    public Bill(double amount)
    {
        this.amount = amount;
    }
    double Ipayable.CalculateBill()
    {
        return amount;
    }
}
class HospitalManagement
{
    public static void Main(string[] args)
    {
        Patient patient = new Patient(1, "Riya Yadav", 22);
        patient.DisplayInfo();
        Doctor doctor = new Doctor(102, "Dr. Sharma", "Cardiology");
        doctor.DisplayInfo();
        Ipayable bill = new Bill(8000.00);
        Console.WriteLine($"Total Bill Amount: {bill.CalculateBill()}");
    }
}*/