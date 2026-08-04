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


--- DOCTOR AUDIT TABLE ---

CREATE TABLE DoctorAudit (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    DoctorId INT ,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Specialization VARCHAR(100),
    Phone VARCHAR(15),
    ActionType VARCHAR(10)             
);

-- INSERT TRIGGER --

create trigger trg_Doctor_Insert
on Doctor
after insert
as
begin
    insert into DoctorAudit (DoctorId, FirstName, LastName, Specialization, Phone, ActionType)
    select DoctorId, FirstName, LastName, Specialization, Phone, 'INSERT'
    from inserted;
end;

-- Update TRIGGER --
create trigger trg_Doctor_Update
on Doctor
after update
as
begin
    insert into DoctorAudit (DoctorId, FirstName, LastName, Specialization, Phone, ActionType)
    select DoctorId, FirstName, LastName, Specialization, Phone, 'UPDATE'
    from inserted;
end;

-- Delete TRIGGER --
create trigger trg_Doctor_Delete
on Doctor
after delete
as
begin
    insert into DoctorAudit (DoctorId, FirstName, LastName, Specialization, Phone, ActionType)
    select DoctorId, FirstName, LastName, Specialization, Phone, 'DELETE'
    from deleted;
end;

--Stored procedure for doctor
-- INSERT
create procedure sp_InsertDoctor
    @FirstName varchar(50),
    @LastName varchar(50),
    @Specialization varchar(100),
    @Phone varchar(15)
as
begin
    insert into Doctor (FirstName, LastName, Specialization, Phone)
    values (@FirstName, @LastName, @Specialization, @Phone);
end;


-- UPDATE
create procedure sp_UpdateDoctor
    @DoctorId int,
    @FirstName varchar(50),
    @LastName varchar(50),
    @Specialization varchar(100),
    @Phone varchar(15)
as
begin
    update Doctor
    set FirstName = @FirstName,
        LastName = @LastName,
        Specialization = @Specialization,
        Phone = @Phone
    where DoctorId = @DoctorId;
end;


-- DELETE
create procedure sp_DeleteDoctor
    @DoctorId int
as
begin
    delete from Doctor where DoctorId = @DoctorId;
end;


insert into Doctor (FirstName, LastName, Specialization, Phone) values
('Anil', 'Kapoor', 'Cardiology', '8765432100'),
('Meera', 'Nair', 'Dermatology', '8765432101'),
('Suresh', 'Reddy', 'Orthopedics', '8765432102'),
('Divya', 'Mehta', 'Pediatrics', '8765432103'),
('Vikram', 'Singh', 'Neurology', '8765432104');

insert into Rooms (RoomNumber, Floor, RoomType) values
('101', 1, 'Consultation'),
('102', 1, 'Consultation'),
('201', 2, 'Procedure'),
('202', 2, 'Consultation'),
('301', 3, 'Procedure');

insert into DoctorRoom (DoctorId, RoomId, AssignedDate) values
(1, 1, '2026-08-01'),
(2, 2, '2026-08-01'),
(3, 3, '2026-08-01'),
(4, 4, '2026-08-01'),
(5, 5, '2026-08-01');


-- PATIENT AUDIT TABLE --

create table PatientAudit (
    AuditId int identity(1,1) primary key,
    PatientId int,
    FirstName varchar(50),
    LastName varchar(50),
    DateOfBirth date,
    Phone varchar(15),
    Address varchar(100),
    Gender char(1),
    ActionType varchar(10)
);

-- INSERT TRIGGER --

create trigger trg_Patient_Insert
on Patient
after insert
as
begin
    insert into PatientAudit (PatientId, FirstName, LastName, DateOfBirth, Phone, Address, Gender, ActionType)
    select PatientId, FirstName, LastName, DateOfBirth, Phone, Address, Gender, 'INSERT'
    from inserted;
end;

-- Update TRIGGER --
create trigger trg_Patient_Update
on Patient
after update
as
begin
    insert into PatientAudit (PatientId, FirstName, LastName, DateOfBirth, Phone, Address, Gender, ActionType)
    select PatientId, FirstName, LastName, DateOfBirth, Phone, Address, Gender, 'UPDATE'
    from inserted;
end;

-- Delete TRIGGER --

create trigger trg_Patient_Delete
on Patient
after delete
as
begin
    insert into PatientAudit (PatientId, FirstName, LastName, DateOfBirth, Phone, Address, Gender, ActionType)
    select PatientId, FirstName, LastName, DateOfBirth, Phone, Address, Gender, 'DELETE'
    from deleted;
end;

insert into Patient (FirstName, LastName, DateOfBirth, Phone, Address, Gender) values
('Aman', 'Sharma', '1990-05-14', '9876543210', 'Jaipur, Rajasthan', 'M'),
('Priya', 'Verma', '1985-11-02', '9876543211', 'Delhi', 'F'),
('Rohan', 'Gupta', '1998-03-21', '9876543212', 'Mumbai', 'M'),
('Sneha', 'Iyer', '1993-07-09', '9876543213', 'Bangalore', 'F'),
('Karan', 'Malhotra', '2000-01-30', '9876543214', 'Chandigarh', 'M');



create table AppointmentAudit (
    AuditId int identity(1,1) primary key,
    AppointmentId int,
    PatientId int,
    DoctorId int,
    AppointmentDate date,
    Status varchar(20),
    ActionType varchar(10)
);

-- INSERT TRIGGER --

create trigger trg_Appointment_Insert
on Appointment
after insert
as
begin
    insert into AppointmentAudit (AppointmentId, PatientId, DoctorId, AppointmentDate, Status, ActionType)
    select AppointmentId, PatientId, DoctorId, AppointmentDate, Status, 'INSERT'
    from inserted;
end;

-- Update TRIGGER --

create trigger trg_Appointment_Update
on Appointment
after update
as
begin
    insert into AppointmentAudit (AppointmentId, PatientId, DoctorId, AppointmentDate, Status, ActionType)
    select AppointmentId, PatientId, DoctorId, AppointmentDate, Status, 'UPDATE'
    from inserted;
end;

-- Delete TRIGGER --
create trigger trg_Appointment_Delete
on Appointment
after delete
as
begin
    insert into AppointmentAudit (AppointmentId, PatientId, DoctorId, AppointmentDate, Status, ActionType)
    select AppointmentId, PatientId, DoctorId, AppointmentDate, Status, 'DELETE'
    from deleted;
end;


insert into Appointment (PatientId, DoctorId, AppointmentDate, Status) values
(1, 1, '2026-08-05', 'Scheduled'),
(2, 3, '2026-08-06', 'Completed'),
(3, 2, '2026-08-07', 'Scheduled'),
(4, 5, '2026-08-08', 'Cancelled'),
(5, 4, '2026-08-10', 'Scheduled');

--verify trigger
select * from Patient;
select * from PatientAudit;

select * from Doctor;
select * from DoctorAudit;

select * from Appointment;
select * from AppointmentAudit;

-- Test UPDATE
update Appointment set Status = 'Completed' where AppointmentId = 1;
select * from AppointmentAudit where AppointmentId = 1;

-- Test DELETE
delete from Appointment where AppointmentId = 4;
select * from AppointmentAudit where AppointmentId = 4;

--verify stored procedure

-- Insert a new doctor
exec sp_InsertDoctor 'Neha', 'Joshi', 'ENT', '8765432106';

-- Update an existing doctor
exec sp_UpdateDoctor @DoctorId = 1, @FirstName = 'Anil', @LastName = 'Kapoor', @Specialization = 'Cardiology', @Phone = '8765432199';

-- Delete a doctor
exec sp_DeleteDoctor @DoctorId = 6;