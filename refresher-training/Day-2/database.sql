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



-- creating rooms table --
create table Rooms (
    RoomId int identity(1,1) primary key,
    RoomNumber varchar(10) not null unique,
    Floor int not null,
    RoomType varchar(30)
);

-- which doctor is assigned to which room, and when
create table DoctorRoom(
    DoctorRoomId int identity(1,1) primary key,
    DoctorId int not null,
    RoomId int not null,
    AssignedDate date not null,
    foreign key(DoctorId) references Doctor(DoctorId),
    foreign key(RoomId) references Rooms(RoomId)
);

-- INSERT 5 PATIENTS 
insert into Patient (FirstName, LastName, DateOfBirth, Phone, Address, Gender) values
('Aman', 'Sharma', '1990-05-14', '9876543210', 'Jaipur, Rajasthan', 'M'),
('Priya', 'Verma', '1985-11-02', '9876543211', 'Delhi', 'F'),
('Rohan', 'Gupta', '1998-03-21', '9876543212', 'Mumbai', 'M'),
('Sneha', 'Iyer', '1993-07-09', '9876543213', 'Bangalore', 'F'),
('Karan', 'Malhotra', '2000-01-30', '9876543214', 'Chandigarh', 'M');


-- INSERT 5 DOCTORS --
insert into Doctor (FirstName, LastName, Specialization, Phone) values
('Anil', 'Kapoor', 'Cardiology', '8765432100'),
('Meera', 'Nair', 'Dermatology', '8765432101'),
('Suresh', 'Reddy', 'Orthopedics', '8765432102'),
('Divya', 'Mehta', 'Pediatrics', '8765432103'),
('Vikram', 'Singh', 'Neurology', '8765432104');


-- INSERT 5 APPOINTMENTS --
insert into Appointment (PatientId, DoctorId, AppointmentDate, Status) values
(1, 1, '2026-08-05', 'Scheduled'),
(2, 3, '2026-08-06', 'Completed'),
(3, 2, '2026-08-07', 'Scheduled'),
(4, 5, '2026-08-08', 'Cancelled'),
(5, 4, '2026-08-10', 'Scheduled');

-- INSERT 5 ROOMS --
insert into Rooms (RoomNumber, Floor, RoomType) values
('101', 1, 'Consultation'),
('102', 1, 'Consultation'),
('201', 2, 'Procedure'),
('202', 2, 'Consultation'),
('301', 3, 'Procedure');

-- INSERT 5 DOCTOR_ROOM ASSIGNMENTS --
insert into DoctorRoom (DoctorId, RoomId, AssignedDate) values
(1, 1, '2026-08-01'),
(2, 2, '2026-08-01'),
(3, 3, '2026-08-01'),
(4, 4, '2026-08-01'),
(5, 5, '2026-08-01');

--Question 2
-- (a) No index 
 select * from Appointment where status = 'Scheduled';

 -- Add a single-column index
create index idx_doctor ON Appointment(DoctorId);

-- (b) Single-column index
select * from Appointment where DoctorId = 5;

-- Add a composite index
create index idx_doctor_date ON Appointment(DoctorId, AppointmentDate);

-- (c) Composite index
select * from Appointment where DoctorId = 5 and AppointmentDate = '2026-08-10';

--Question 3

create table patient_phones (
    patient_id int NOT NULL,
    phone_number varchar(15) NOT NULL,
    phone_type varchar(20), 
    primary key (patient_id, phone_number),
    foreign key (patient_id) references patient(PatientId)
);

--Question 4

-- Covering index
create index idx_covering on Appointment(DoctorId, AppointmentDate, Status);

select DoctorId, AppointmentDate, Status
from Appointment
where DoctorId = 5;