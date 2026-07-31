-- CREATING DATABASE --

Create Database HealthCare;

-- USING THE DATABASE--
Use HealthCare;

-- CREATING PATIENT TABLE --
create table Patient(
PatientId int Identity(1,1) primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
DateOfBirth date not null,
Phone varchar(15) unique,
Address varchar(100),
Gender char(1) check(gender in ('M','F'))
);

-- CREATING DOCTOR TABLE --
create table Doctor(
DoctorId int Identity(1,1) primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
Specialization varchar(100) not null,
phone varchar(15) unique
);

-- CREATING APPOINTMENT TABLE --
create table Appointment(
AppointmentId int identity(1,1) primary key,
PatientId int not null foreign key references Patient(PatientId),
DoctorId int not null foreign key references Doctor(DoctorId),
AppointmentDate date not null,
Status varchar(20) default 'Scheduled'
);