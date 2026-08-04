# Refresher Training

 Building up a `HealthCare` database schema and exploring core RDBMS concepts.

## Day 1 — Core Schema Design

Designed the foundational `HealthCare` database with three related tables:

- **Patient** — stores patient details (name, date of birth, contact info, gender)
- **Doctor** — stores doctor details (name, specialization, contact info)
- **Appointment** — links a patient to a doctor for a scheduled visit, with a status field (`Scheduled`, `Completed`, `Cancelled`)

**Key concepts covered:**
- Primary keys and auto-incrementing IDs (`IDENTITY`)
- Foreign key relationships between tables
- Basic constraints (`NOT NULL`, `UNIQUE`, `CHECK`)
- Entity-Relationship (ER) diagram of the schema 



## Day 2 — Extending the Schema & Query Optimization

Built on the Day 1 schema with additional tables and deeper database concepts:

- **Rooms** — consultation/procedure rooms in the clinic
- **DoctorRoom** —  linking doctors to rooms with assignment dates
- **PatientPhones** — normalized table supporting multiple phone numbers per patient

**Key concepts covered:**

- Er diagram
- Attributes and its types
- Many-to-many relationships 
- Single-column vs. composite indexes
- Covering indexes 
- Normalization — verifying 1NF, 2NF, and 3NF compliance


# Day 3 – Stored Procedures & Triggers

## 📖 Topics Covered
- SQL Joins: `INNER`, `LEFT`, `RIGHT`, `FULL OUTER`
- Stored Procedures
- SQL Triggers
- INSERT Trigger
- UPDATE Trigger
- DELETE Trigger
- Audit Tables


## 🛠️ Practical Implementation
Enhanced the Health Clinic Database by implementing stored procedures and trigger-based automation for querying,  and auditing.

### Tasks Completed
- ✅ Created `DoctorAudit`, `PatientAudit`, `AppointmentAudit` tables
- ✅ Implemented `INSERT`, `UPDATE`, `DELETE` triggers for `Doctor`
- ✅ Implemented `INSERT`, `UPDATE`, `DELETE` triggers for `Patient`
- ✅ Implemented `INSERT`, `UPDATE`, `DELETE` triggers for `Appointment`
- ✅ Created parameterized Stored Procedures for `Doctor` (Insert, Update, Delete)
- ✅ Verified automatic audit logging through SQL Server triggers


## 🗄️ Database Enhancements

### Audit Tables Created
- `DoctorAudit`
- `PatientAudit`
- `AppointmentAudit`

### Triggers Implemented

**Doctor**
- `trg_Doctor_Insert`
- `trg_Doctor_Update`
- `trg_Doctor_Delete`

**Patient**
- `trg_Patient_Insert`
- `trg_Patient_Update`
- `trg_Patient_Delete`

**Appointment**
- `trg_Appointment_Insert`
- `trg_Appointment_Update`
- `trg_Appointment_Delete`







