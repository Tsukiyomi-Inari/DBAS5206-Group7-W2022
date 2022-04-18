/**
	Project Name:	LakeRidge Hospital
	Course:			DBAS 5206-06
	Group:			7
	Members:		Samuel Jeremiah Kayongo-Mutumba Jr
					Katherine Bellman
					Sanjivkumar Patel
	Date:			March 29th 2022
	Title:			Insert Table Scripts
	Purpose:		Insert data into the tables nessessary to demo the hospital system
					Demonstrate all the dependencies, data types and relationships of tables
					Demonstrate table behaviour
**/


---DROP DATABASE
DROP DATABASE IF EXISTS LakeRidgeHospital
GO
CREATE DATABASE LakeRidgeHospital
GO

USE LakeRidgeHospital
GO
---CREATE TABLES

-- Create table to hold financial status providers
CREATE TABLE LakeRidgeHospital.dbo.FINANCIAL_STATUS
(
	STATUS_ID SMALLINT IDENTITY(100, 1) PRIMARY KEY,
	PROVIDER VARCHAR(30) NOT NULL,
)

-- Create table of transactions made
CREATE TABLE LakeRidgeHospital.dbo.CHARGE_TRANSACTION
(
	TRANSACTION_NUMBER INT IDENTITY(1000,1) PRIMARY KEY,
	STATUS_ID SMALLINT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.FINANCIAL_STATUS(STATUS_ID) NOT NULL,
	DATE DATETIME NOT NULL,
	PAID money NOT NULL,
)

-- Create table of Patients
CREATE TABLE LakeRidgeHospital.dbo.PATIENT
(
	PATIENT_NUMBER INT IDENTITY(100000,1) PRIMARY KEY,
	PATIENT_NAME VARCHAR(40) NOT NULL,
	PATIENT_ADDRESS VARCHAR(25) NOT NULL,
	CITY	VARCHAR(15) NOT NULL,
	PROVINCE CHAR(2) NOT NULL,
	POSTAL_CODE CHAR(7) NOT NULL,
	TELEPHONE CHAR(12) NOT NULL,
	SEX VARCHAR(6) NOT NULL,
	STATUS_ID SMALLINT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.FINANCIAL_STATUS(STATUS_ID) NOT NULL,

)

-- Create table of appointments
CREATE TABLE LakeRidgeHospital.dbo.APPOINTMENT
(
	APPOINTMENT_NUMBER INT IDENTITY(100000000, 1) PRIMARY KEY,
	PATIENT_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.PATIENT(PATIENT_NUMBER) NOT NULL,
	TIME DATETIME NOT NULL,
	DESCRIPTION VARCHAR(200) NOT NULL, 
)

-- Create table of types of users 
CREATE TABLE LakeRidgeHospital.dbo.USER_TYPE
(
	USER_TYPE_NUMBER SMALLINT IDENTITY(1,1) PRIMARY KEY,
	USER_TYPE VARCHAR(10) NOT NULL,
)

-- Create table of users
CREATE TABLE LakeRidgeHospital.dbo.DB_USER
(
	USER_ID INT IDENTITY(1000, 1) PRIMARY KEY,
	USER_TYPE_NUMBER SMALLINT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.USER_TYPE(USER_TYPE_NUMBER) NOT NULL,
	PASSWORD CHAR(40) NOT NULL,
)

-- Create table of different specialities
CREATE TABLE LakeRidgeHospital.dbo.PHYSICIAN_SPECIALTY
(
	SPECIALTY_ID VARCHAR(3) PRIMARY KEY NOT NULL,
	SPECIALTY VARCHAR(25) NOT NULL,
)

-- Create table of physicians
CREATE TABLE LakeRidgeHospital.dbo.PHYSICIAN
(
	PHYSICIAN_NUMBER INT IDENTITY(100,1) PRIMARY KEY,
	USER_ID INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.DB_USER(USER_ID) NOT NULL,
	PHYSICIAN_NAME VARCHAR(40) NOT NULL,
	TELEPHONE CHAR(12) NOT NULL,
	SPECIALTY_ID VARCHAR(3) FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.PHYSICIAN_SPECIALTY(SPECIALTY_ID) NOT NULL,

)

-- Create table of diagnosis
CREATE TABLE LakeRidgeHospital.dbo.DIAGNOSIS
(
	DIAGNOSIS_NUMBER INT IDENTITY(100,1) PRIMARY KEY,
	DIAGNOSIS VARCHAR(200) NOT NULL,
)

-- Create table of treatment
CREATE TABLE LakeRidgeHospital.dbo.TREATMENT
(
	TREATMENT_NUMBER INT IDENTITY(100000000, 1) PRIMARY KEY,
	DIAGNOSIS_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.DIAGNOSIS(DIAGNOSIS_NUMBER) NOT NULL,
	PHYSICIAN_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.PHYSICIAN(PHYSICIAN_NUMBER) NOT NULL,
	PATIENT_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.PATIENT(PATIENT_NUMBER) NOT NULL,
	DESCRIPTION VARCHAR(200) NOT NULL,
)

-- Create table of room types
CREATE TABLE LakeRidgeHospital.dbo.ROOM_TYPE
(
	ROOM_TYPE_ID CHAR(2) PRIMARY KEY,
	DESCRIPTION VARCHAR(20) NOT NULL,
)

-- Create table of rooms 
CREATE TABLE LakeRidgeHospital.dbo.ROOM
(
	ROOM_NUMBER SMALLINT PRIMARY KEY,
	ROOM_TYPE_NUMBER CHAR(2) FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.ROOM_TYPE(ROOM_TYPE_ID) NOT NULL,
)

-- Create table of beds
CREATE TABLE LakeRidgeHospital.dbo.BED
(
	ROOM_NUMBER SMALLINT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.ROOM(ROOM_NUMBER) NOT NULL,
	BED_CHAR CHAR NOT NULL,
	EXTENSION SMALLINT NOT NULL,
	PRIMARY KEY (ROOM_NUMBER, BED_CHAR),

)

-- Create table to contain admissions
CREATE TABLE LakeRidgeHospital.dbo.ADMISSION
(
	ADMISSION_NUMBER INT IDENTITY(1000000,1) PRIMARY KEY,
	PATIENT_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.PATIENT(PATIENT_NUMBER) NOT NULL,
	DATE_ADMITTED DATETIME NOT NULL,
	DATE_DISCHARGED DATETIME,
	ROOM_NUMBER SMALLINT NOT NULL,
	BED_CHAR CHAR NOT NULL,
	FOREIGN KEY(ROOM_NUMBER, BED_CHAR) REFERENCES LakeRidgeHospital.dbo.BED(ROOM_NUMBER, BED_CHAR),
)

-- Create table of cost centers
CREATE TABLE LakeRidgeHospital.dbo.COST_CENTER 
(
	COST_CENTER_NUMBER TINYINT IDENTITY(1,1) PRIMARY KEY,
	DEPARTMENT_NAME VARCHAR(200) NOT NULL,

)

-- Create table of items
CREATE TABLE LakeRidgeHospital.dbo.ITEM
(
	ITEM_CODE INT IDENTITY (100,1) PRIMARY KEY,
	COST_CENTER_NUMBER TINYINT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.COST_CENTER(COST_CENTER_NUMBER) NOT NULL,
	DESCRIPTION VARCHAR(30) NOT NULL,
--It is important to note all charges are recorded in CAD$ 
	CHARGE smallmoney NOT NULL,
)

-- Create table of charges
CREATE TABLE LakeRidgeHospital.dbo.CHARGE
(
	CHARGE_NUMBER INT IDENTITY(100000,1) PRIMARY KEY,
	ADMISSION_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.ADMISSION(ADMISSION_NUMBER) NOT NULL,
	ITEM_CODE INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.ITEM(ITEM_CODE) NOT NULL,
	QUANTITY TINYINT NOT NULL,
	DATE_CHARGED DATETIME NOT NULL,
)

-- Create table of notes
CREATE TABLE LakeRidgeHospital.dbo.NOTE
(
	NOTE_NUMBER BIGINT IDENTITY(1,1) PRIMARY KEY,
	ADMISSION_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.ADMISSION(ADMISSION_NUMBER) NOT NULL,
	ENTRY VARCHAR(200) NOT NULL,
)

-- Create table of admissions related to patients
CREATE TABLE LakeRidgeHospital.dbo.ADMISSION_LINE_ITEM
(
	ADMISSION_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.ADMISSION(ADMISSION_NUMBER) NOT NULL,
	PATIENT_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.PATIENT(PATIENT_NUMBER) NOT NULL,

	PRIMARY KEY(ADMISSION_NUMBER,PATIENT_NUMBER),
)

--Create table of bills
CREATE TABLE BILL(
	BILL_NUMBER BIGINT IDENTITY(1000,1) PRIMARY KEY,
	DATE_MADE DATETIME NOT NULL,
)

--Create table for bill items
CREATE TABLE BILL_LINE_ITEM (
	CHARGE_NUMBER INT  FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.CHARGE(CHARGE_NUMBER) NOT NULL,
	BILL_NUMBER BIGINT FOREIGN KEY REFERENCES BILL(BILL_NUMBER) NOT NULL,
	
	PRIMARY KEY(CHARGE_NUMBER, BILL_NUMBER),
)

-- Create table of charges assocaited with transactions 
CREATE TABLE LakeRidgeHospital.dbo.TRANSACTION_LINE_ITEM(
	TRANSACTION_NUMBER INT FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.CHARGE_TRANSACTION(TRANSACTION_NUMBER) NOT NULL,
	CHARGE_NUMBER INT  FOREIGN KEY REFERENCES LakeRidgeHospital.dbo.CHARGE(CHARGE_NUMBER) NOT NULL,

	PRIMARY KEY(TRANSACTION_NUMBER, CHARGE_NUMBER),
)



--USE 
USE LakeRidgeHospital
GO

--INSERT FINANCIAL_STATUS
INSERT INTO FINANCIAL_STATUS (Provider)
VALUES 
--	100
	( 'Assure' ),
-- 101
	( 'Self-Pay' ),
--102
	( 'ESI' )
GO


--Insert Transaction
INSERT INTO CHARGE_TRANSACTION (STATUS_ID, DATE, PAID)
VALUES 
--	Charge 1000
(
	--self pay
	101,
	GETDATE(),
	12000
)
GO

-- Insert Patient
INSERT INTO PATIENT (PATIENT_NAME, PATIENT_ADDRESS,CITY,PROVINCE, POSTAL_CODE, TELEPHONE,SEX,STATUS_ID)
VALUES (
--  Patient 100000
	'Baker, Mary A',
	'300 Oak St.',
	'Oshawa',
	'ON',
	'L1Y-1V1',
	'905-555-5555',
	'Female',
	 102
),
 (
--   Patient 101
	'Perkins, John M',
	'4315 James St.',
	'Mount Pleasant',
	'ON',
	'N0E-1K0',
	'519-484-8730',
	'Male',
	102
),
(
--	Patient 100002
	'Smith, John W',
	'100 King St.',
	'Toronto',
	'ON',
	'M1K-7J1',
	'416-645-5655',
	'Male',
	100
),
(
-- Patient 100003
	'Cook, Ashley L',
	'80 Queen St.',
	'Oshawa',
	'ON',
	'L1P-3T1',
	'416-557-8585',
	'Other',
	101
),
(
-- Patient 100004
	'Blaker, Laura K',
	'7 Scugog St.',
	'Oshawa',
	'ON',
	'L1R-4E6',
	'905-867-6442',
	'Female',
	102
),
(
-- Patient 100005
	'Butler, Sandy J',
	'3010 Eglinton Ave.',
	'Toronto',
	'ON',
	'M4P-1A6',
	'416-569-4113',
	'Female',
	100
),
(
-- Patient 100006
	'McKeon, Joseph B',
	'2252  Leduc St.',
	'Vankleek Hill',
	'ON',
	'K0B-1R0',
	'613-676-9927',
	'Male',
	101
),
(
-- Patient 100007
	'Potts, Donna J',
	'3174 Fallon Dr.',
	'Neustadt',
	'ON',
	'N0G-2M0',
	'519-799-4878',
	'Female',
	102
),
(
-- Patient 100008
	'Fabian, Elizabeth R',
	'427 Central Pkwy',
	'Erin Mills',
	'ON',
	'L5L-3A1',
	'905-828-2202',
	'Other',
	100
),
(
-- Patient 100009
	'Moore, Ethel D',
	'2934 40th St.',
	'Calgary',
	'AB',
	'T2A-1C8',
	'403-204-3709',
	'Female',
	102
),
(
-- Patient 100010
	'Backster, Addi A',
	'2626 chemin Hudson',
	'Montreal',
	'QC',
	'H4J-1M9',
	'514-291-8633',
	'Male',
	100
),
(
-- Patient 100011
	'Jordon, Eileen N',
	'987 Summerfield Blvd',
	'Camrose',
	'AB',
	'T4V-1V4',
	'780-678-9373',
	'Female',
	101
),
(
-- Patient 100012
	'Cartier, David H',
	'3985 2nd Street',
	'Lac Du Bonnet',
	'MB',
	'R0E-1A0',
	'204-345-1753',
	'Other',
	102
),
(
-- Patient 100013
	'Hinkson, Aaron L',
	'2691 Ostrea Lake Rd',
	'Camrose',
	'NS',
	'B0J-2L0',
	'902-878-1402',
	'Male',
	102
),
(
-- Patient 100014
	'Pilon, Norma J',
	'2430 Albert Street',
	'Aylmer',
	'ON',
	'N5H-1L2',
	'519-779-4169',
	'Female',
	102
),
(
-- Patient 100015
	'Snyder, James R',
	'332 Reserve St',
	'Coe Hill',
	'ON',
	'K0L-1P0',
	'613-337-4512',
	'Male',
	102
),
(
-- Patient 100016
	'Omara, Greta J',
	'3531 Weston Rd',
	'Toronto',
	'ON',
	'M9N-1G4',
	'416-333-5038',
	'Female',
	100
),
(
-- Patient 100017
	'Stiver, Alex C',
	'2575 Merivale Road',
	'Ottawa',
	'ON',
	'K2G-3K2',
	'613-225-0790',
	'Male',
	102
),
(
-- Patient 100018
	'Jones, James B',
	'18 Garafraxa St',
	'Oshawa',
	'ON',
	'N0H 2R0',
	'519-596-0609',
	'Male',
	102
),
(
-- Patient 100019
	'Weber, Bart D',
	'4769 Landon St.',
	'Verner',
	'ON',
	'P0H-2M0',
	'705-594-3243',
	'Male',
	101
),
(
-- Patient 100020
	'Whitby, Debra R',
	'4545 Pitt St',
	'Cornwall',
	'ON',
	'K6J 3R2',
	'613-933-0139',
	'Female',
	102
),
(
-- Patient 100021
	'Servantes, Helen C',
	'807 Pitt St',
	'Oshawa',
	'ON',
	'K6J-3R2',
	'613-936-2494',
	'Female',
	102
),
(
-- Patient 100022
	'Terry, Cora D',
	'3940 Lynden Road',
	'Wasaga Beach',
	'ON',
	'L0L-2P0',
	'705-422-2502',
	'Female',
	100
),
(
-- Patient 100023
	'Bales, Natacha S',
	'2333 Dufferin St.',
	'Toronto',
	'ON',
	'M6H-4B6',
	'416-539-2319',
	'Female',
	102
),
(
-- Patient 100024
	'Holderman, Anna R',
	'2619 102nd Ave.',
	'Trail',
	'BC',
	'V1R-3W5',
	'250-231-8630',
	'Female',
	102
),
(
-- Patient 100025
	'Hou, Ai',
	'4279 Matheson St',
	'Kenora',
	'ON',
	'P9N-1T8',
	'807-468-9826',
	'Female',
	102
),
(
-- Patient 100026
	'Yin, Manchu',
	'1615 Côte Joyeuse',
	'St Raymond',
	'QC',
	'H0H-0H0',
	'418-340-8860',
	'Male',
	101
),
(
-- Patient 100027
	'Santos, Luiz S',
	'1131 Eglinton Avenue',
	'Toronto',
	'ON',
	'M4P-1A6',
	'416-488-4892',
	'Male',
	102
),
(
-- Patient 100028
	'Barros, Guilherme P',
	'1135 Davis Drive',
	'Welland',
	'ON',
	'L3B-3Z6',
	'905-714-6203',
	'Male',
	100
),
(
-- Patient 100029
	'Kanaan, Husain K',
	'2985 St. John Street',
	'Weldon',
	'SK',
	'S4P-3Y2',
	'905-555-5555',
	'Female',
	101
),
(
-- Patient 100030
	'Laker, Hans A',
	'3531 Weston Rd.',
	'Ajax',
	'ON',
	'M9N-1G4',
	'416-242-2987',
	'Male',
	102
)
GO

-- Insert Appointment
INSERT INTO APPOINTMENT (PATIENT_NUMBER, TIME, DESCRIPTION )
VALUES 
-- Appointment 100000000 Baker, Mary A
(
	100000,
	GETDATE(),
	'Allergic reaction to peanuts'
), 
-- Appointment 100000001 Yin, Manchu'
(
	100026,
	convert(varchar, '2021-02-15 06:30 AM', 0),
	'Cancer treatments'
),
-- Appointment 100000002 Kanaan, Husain K'
(
	100029,
	convert(varchar, '2008-03-26 11:32 AM', 0),
	'Abdominal Pain, Gastroscopy investigation'
),
-- Appointment 100000003 Santos, Luiz S
(
	100027,
	convert(varchar ,'2022-03-26 11:32 AM',0),
	'General weakness, lab tests for cause'
),
-- Appointment 100000004 Servantes, Helen C'
(
	100021,
	GETDATE(),
	'3 months Pregnancy mark ultra-sound'
),
-- Appointment 100000005 Bales, Natacha S
(
	100023,
	convert(varchar, '2021-05-18 06:30 AM', 0),
	'MRI Scan'
),
-- Appointment 100000006 'Laker, Hans A'
(
	100030,
	convert(varchar, '2022-04-10 11:32 AM', 0),
	'Galactosemia (GALT deficiency)'
),
-- Appointment 100000007 'Whitby, Debra R'
(
	100020,
	convert(varchar, '2022-04-10 10:30 AM', 0),
	'Integument Surgery'
),
-- Appointment 100000008 'Weber, Bart D'
(
	100019,
	convert(varchar, '2022-08-26 11:32 AM', 0),
	'Follow up for URI after steroid course'
),
-- Appointment 100000009 'Jones, James B
(
	100018,
	convert(varchar, '2022-08-26 11:30 AM', 0),
	'Consult on new treatment to control condition'
),
-- Appointment 100000010 'Stiver, Alex C
(
	100017,
	convert(varchar, '2022-06-06 06:30 AM', 0),
	'Laser treatment for occular diagnosis to prevent further vision loss'
),
-- Appointment 100000011 Snyder, James R
(
	100015,
	convert(varchar, '2022-07-16 06:30 AM', 0),
	'Self-injection assistance for hormone replacement therapy'
),
-- Appointment 100000012 Omara, Greta J
(
	100016,
	convert(varchar, '2022-06-06 10:30', 0),
	'Therapy sessions assistance for physical condition'
),
-- Appointment 100000013 Hinkson, Aaron L
(
	100013,
	convert(varchar, '2022-05-26 06:30 AM', 0),
	'Investigation for neck growth to confirm thyroid condition'
),
-- Appointment 100000014 Jordon, Eileen N
(
	100011,
	getDate(),
	'Seizure cause investigation and electrical stimulation therapy treatment'
),
-- Appointment 100000015 Potts, Donna J
(
	100007,
	convert(varchar, '2022-05-16 11:30 AM', 0),
	'Medication Prescription Evaluation'
),
-- Appointment 100000016 Butler Sandy J
(
	100005,
	convert(varchar, '2022-03-19 11:30 AM', 0),
	'Blood Test’ and Medication Prescription'
),
--  Appointment 100000017 'Butler Sandy J
(
	100005,
	convert(varchar, '2022-03-13 11:30 AM', 0),
	'Medication Prescription Evaluation'
),
--  Appointment 100000018 Butler Sandy J
(
	100005,
	convert(varchar, '2022-02-12 11:30 AM', 0),
	'Blood Test’ and Medication Prescription'
),
--  Appointment 100000019 Butler Sandy J
(
	100005,
	convert(varchar, '2022-01-16 11:30 AM', 0),
	'Blood Test’ and Medication Prescription'
),
--  Appointment 100000020 Perkins, John M
(
	100001,
	convert(varchar, '2022-01-26 11:30 AM', 0),
	'Blood Test’ and Medication Prescription'
)

GO

-- Insert User Type 
INSERT INTO USER_TYPE (USER_TYPE)
VALUES 
--Admin 1
	( 'Admin' ),
--Physician   2
	( 'Physician' ),
--Nurse  3
	( 'Nurse' ),
--Dentist  4
	( 'Dentist' ),
--Receptionist 5
	( 'Reception' ),
--Accountant   6
	( 'Accountant' ),
--Pharmicist   7
	( 'Pharmicist' )
GO

-- Insert User
INSERT INTO DB_USER (USER_TYPE_NUMBER , PASSWORD) 
VALUES 
-- 1000
	( 2, '5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8'  ),
--1002
	( 2, '62dff3687dd7d7ede1a7b0e23cfb0b096b3f577e'),
-- 1003
	( 2, 'f1d6ba9ecac467a26435a5f858c1ae3e94de2062'),
--1004
	( 2, 'b5747f11109a4cd1256f803de8198480e425c548'),
--1005
	( 2, '0e14e56072994596ecfed16a5fc3e31efe38c083'),
--1006
	( 2, 'd2bd354967d6da5d68c9540c90a6352e927c88c6'),
--1007
	( 2, 'a6fc1eec348436720c2e5fd9f5b81bf08eb98f45'),
--1008
	( 1,'d673d757521334075806f491b6c10293e2e61975')
GO

-- Insert table of different specialties
INSERT INTO PHYSICIAN_SPECIALTY (SPECIALTY_ID, SPECIALTY)
VALUES 
	( 'P', 'Paediatrics'),
	( 'DT', 'Dentistry'),
	( 'ORT', 'Orthopedics'),
	( 'NRY', 'Neurology'),
	( 'GYN', 'Gynecology'),
	( 'END', 'Endocrinology'),
	( 'DER', 'Dermatology'),
	( 'OC', 'Oncology'),
	( 'RD', 'Radiology'),
	( 'VIR', 'Virology'),
	( 'RS', 'Respiratory'),
	( 'MT', 'Meternal-Fetal'),
	( 'SER', 'Serology'),
	( 'T', 'Trauma'),
	( 'M', 'Mental')
GO

--Insert physcians
INSERT INTO PHYSICIAN (USER_ID, PHYSICIAN_NAME, TELEPHONE, SPECIALTY_ID)
VALUES	
-- Physician 100
		( 1000, 'M. D. Thayer', '250-555-4444', 'P' ),
-- Physician 101
		( 1001, 'M. D. Green', '905-721-4964', 'VIR' ),
-- Physician 102
		( 1002, 'M. D. Sooknanan', '905-697-3607', 'T' ),
-- Physician 103
		( 1003, 'M. D. Shrives', '905-623-2570', 'GYN' ),
-- Physician 104
		( 1004, 'M. D. Koziar', '905-732-0121', 'MT' ),
-- Physician 105
		( 1005, 'M. D. Mahmud', '519-657-5434', 'M' ),
--	Physician 106
		( 1006, 'M. D. Grant', '905-623-2783', 'RD' ),
-- Physician 107
		( 1007, 'M. D. Niro', '905-579-1212', 'RS' )
GO

--Insert Diagnosis
INSERT INTO DIAGNOSIS (DIAGNOSIS)
VALUES 
-- 100
	( 'HIV' ),
-- 101
	('Cancer'), 
-- 102
	('Chrones'),
-- 103
	('Anemia'),
-- 104
	('Fibroid Detection'),
-- 105
	('Depression'), 
-- 106
	('Seizure Disorder'),
-- 107
	('Male Menopause'),
-- 108
	('High Blood Pressure'),
-- 109
	('Colorectal Cancer'),
--110
	('Alzheimers'),
--111
	('Breast Cancer'),
--112
	('COPD'),
--113
	('Lukemias'),
--114
	('Hypothydoidism'),
-- 115
	('Silver Root cause'),
--116
	('Viral Infection'),
--117
	('Prostate Cancer'),
--118
	('Osteoarthritis'),
--119
	('Fibromyalgia'),
--120
	('Glaucoma'),
--121
	('Viral Hepatitis'),
--122
	('Upper Respiratory Infection'),
--123
	('Necrotizing Fascitis'),
--124
	('Cystic Fibrosis'),
--125
	('Leukodystrophies'),
--126
	('MCADD'),
--127
	('Huntington Disease'),
--128
	('Pregnancy'),
--129
	('Arginase Deficiency')


GO

--Insert Treatment
INSERT INTO TREATMENT (DIAGNOSIS_NUMBER, PHYSICIAN_NUMBER, PATIENT_NUMBER, DESCRIPTION )
VALUES 
--	100000000 'Baker, Mary A'
(	104, -- Fibroid
	105,
	100000,
	'Fibroid Removal Treatment’'),
--	100000001 Yin, Manchu
	(101, --cancer
	107,
	100026,
	'Chemo Therapy Radiation'),
--	100000002 Moore, Ethel D
(
	109, --colorectal cancer
	107,
	100009,
	'Colonoscopy and blood Test'
),
--	100000003	Jordon, Eileen
(
	106,
	100,
	100011,
	'Responsive Neurostimulation'
),
--	100000004 Hinkson, Aaron
(
	112,
	106,
	100013,
	'Pulmonary rehabilitation program'
),
--	100000005	Pilon, Norma J
(
	114,
	100,
	100014,
	'Levothyroxine'
),
--	100000006 Snyder, James R
(
	107,
	105,
	100015,
	'Testosterone Replacement Therapy'
),
--	100000007  Omara, Greta J
(
	119,
	104,
	100016,
	'Cognitive Behavioral Therapy'
),
--	100000008	Stiver, Alex C
(
	120,
	101,
	100017,
	'Selective laser Trabeculoplasty'
),
--	100000009 Jones, James B
(
	121,
	106,
	100018,
	'Daklinza'
),
--	100000010 Weber, Bart D
(
	122,
	103,
	100019,
	'Prednisone'
),
--	100000011 Whitby, Debra R
(
	123,
	102,
	100020,
	'Sergical Removal'
),
--	100000012 Servantes, Helen C
(
	128,
	103,
	100021,
	'prenatal vitamins'
),
--	100000013 Santos, Luiz S
(
	103,
	102,
	100027,
	'Iron'
),
--	100000014 Kanaan, Husain K
(
	102,
	101,
	100029,
	'Gastroscopy Preparation Kit'
),
--	100000015 Blaker, Lara K
(
	111,
	107,
	100004,
	'Mammography'
),
--	100000016 
(
	116,
	105,
	100005,
	'Antibiotics'
)
GO

--Insert room type
INSERT INTO ROOM_TYPE (ROOM_TYPE_ID, DESCRIPTION)
VALUES 
( 'SP', 'SemiPrivate' ),
( 'PR', 'Private' ),
( 'IC', 'Intensive Care' ),
( 'W3', 'Ward, 3 Beds' ),
( 'W4', 'Ward, 4 Beds' )
GO

--Insert Room
INSERT INTO ROOM (ROOM_NUMBER, ROOM_TYPE_NUMBER)
VALUES 
 ( 100, 'SP' ),
 ( 101, 'SP' ),
 ( 102, 'SP' ),
 ( 103, 'SP' ),
 ( 104, 'SP' ),
 ( 200, 'PR' ),
 ( 210, 'PR' ),
 ( 327, 'W3' ),
 ( 328, 'W3' ),
 ( 329, 'W3' ),
 ( 330, 'W4' ),
 ( 500, 'IC' ),
 ( 300, 'SP' )
 GO

-- Insert Beds
INSERT INTO BED(ROOM_NUMBER, BED_CHAR, EXTENSION) 
VALUES 
(328, 'B', 623 ), -- W3
(328, 'C', 621),  -- W3
(328, 'A', 622 ), -- W3
(100, 'A', 274 ), -- SP
(100, 'B', 275),  -- SP
(102, 'A', 876 ), -- SP
(102, 'B', 877),  -- SP
(103, 'A', 320 ), -- SP
(103, 'B', 321),  -- SP
(330, 'A', 720 ), -- W4
(330, 'B', 721 ), -- W4
(330, 'C', 722 ), -- W4
(330, 'D', 723 ), -- W4
(329, 'A', 345 ), -- W3
(329, 'B', 355),  -- W3
(329, 'C', 196 ), -- W3
(500, 'G', 264 ), -- IC
(210, 'A', 641 )  -- PR
GO

--Insert Admission
INSERT INTO ADMISSION( PATIENT_NUMBER, DATE_ADMITTED, DATE_DISCHARGED, ROOM_NUMBER, BED_CHAR)
VALUES 
--	1000000 Baker, Mary A
(	100000, 
	GETDATE(),
	NULL ,  --Has not yet been discharged
	328,
	'B'
),
--	1000001 Yin, Manchu
(	100026, 
	GETDATE(),
	DATEADD(day, 3, GETDATE()),  --Has not yet been discharged
	103,
	'B'
-- DATEADD(day, 3, GETDATE())  <- can be used to add a discharge date set to # of days after Date_Admitted
)
GO

--Insert Cost Center
INSERT INTO COST_CENTER (DEPARTMENT_NAME) 
VALUES 
--	1
('Entertainment'),
--	2
('Room & Board'),
--	3
('Laboratory'),
--	4
('Pharmacy'),
--	5
('Radiology')
GO

--Insert Item
INSERT INTO ITEM (COST_CENTER_NUMBER, DESCRIPTION, CHARGE)
VALUES 
--	100
( 2, 'Semiprivate Room', 200.00 ),
--	101
( 1, 'Television', 5.00 ),
--	102
( 4, 'Glucose', 25.00 ),
--	103
( 3, 'Culture', 20.00 ),
--	104
( 5, 'Chest X-ray', 30.00 ),
--	105
(5, 'Chemo Therapy', 10.00),
--	106
(2, 'Ward, 4 Beds', 50.00),
--	107
(2, 'Ward, 3 Beds', 75.00),
--	108
(2, 'Private' ,400.00)
GO

--Insert Charges
INSERT INTO CHARGE (ADMISSION_NUMBER, ITEM_CODE, QUANTITY, DATE_CHARGED )
VALUES 
--		'Baker, Mary A'  (SP , tV, culture)
( 1000000, 100, 3, GETDATE()),
( 1000000, 101, 1, GETDATE()),
( 1000000, 103, 1, GETDATE())
--		'Yin, Manchu'
GO

--Insert Note 
INSERT INTO NOTE (ADMISSION_NUMBER, ENTRY)
VALUES 
-- note 1
(1000000, 'This note is to confirm that Baker, Mary A, she is suffering from allergies and I recommend you to allow her to discontinue classes for two months.'),
-- note 2
(1000001, 'Mr.Yin culture tests returned noting cancer cells, further testing points to prostate, Monthly radiation Treatment sessions have been booked for 4 treatments.')
GO

--Insert Admission line item
INSERT INTO ADMISSION_LINE_ITEM (ADMISSION_NUMBER, PATIENT_NUMBER)
VALUES 
-- 'Baker, Mary A'
(
	1000000,
	100000
),
--	'Yin, Manchu'
(
	1000001,
	100026
 )
---- ‘Perkins, John M’
--,(
--	1000011,
--	101
--),
---- ‘Smith, John Wu’
--(
--	1000002,
--	102
--),
---- ‘Cook Ashley L’
--(
--	1000003,
--	103
--),
---- ‘Blaker, Lara K’
--(
--	1000004,
--	104
--),
---- ‘Butler Sandy J’
--(
--	1000005,
--	105
--),
---- 'Fabian, Elizabeth R’
--(
--	1000008,
--	108
--),
---- ‘Moore, Ethel D’
--(
--	1000009,
--	109
--),
---- ‘Baxter, Addi A’
--(
--	1000010,
--	110
--),
---- 'Jordon, Eileen N'
--(
--	1000011,
--	111
--),
---- 'Pilon, Norma J'
--(
--	1000007,
--	114
--),
---- 'Snyder, James R',
--(
--	1000008,
--	115
--),
---- 'Stiver, Alex C'
--(
--	1000012,
--	117
--),
---- 'Whitby, Debra R'
--(
--	1000013,
--	120
--),
---- 'Servantes, Helen C'
--(
--	1000005,
--	121
--),
---- ‘Bales, Natacha S’
--(
--	1000006,
--	123
--),
---- 'Santos, Luiz S'
--(
--	1000014,
--	127
--),
---- 'Kanaan, Husain K'
--(
--	1000015,
--	129
--)


GO

--Create table of bills
INSERT INTO BILL(DATE_MADE)
VALUES 
--1000
( GETDATE() ),
( GETDATE() ),
( GETDATE() ),
( GETDATE() ),
( GETDATE() ),
( GETDATE() ),
( GETDATE() ),
( GETDATE() ),
( GETDATE() ),
( GETDATE() )
------1010
----,( GETDATE() )
GO

--Create table for bill items
INSERT INTO BILL_LINE_ITEM(CHARGE_NUMBER, BILL_NUMBER)
VALUES 
-- 'Baker, Mary A'
( 100000, 1000 )
GO

--Insert Transaction line item
INSERT INTO TRANSACTION_LINE_ITEM (TRANSACTION_NUMBER, CHARGE_NUMBER)
VALUES 
-- 'Baker, Mary A'
( 1000 , 100000 )
GO
