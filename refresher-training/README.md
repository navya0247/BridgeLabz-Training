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





