CREATE DATABASE ProgrammeManagementSystem;

USE ProgrammeManagementSystem;

--Table creation 
CREATE TABLE Students(
StudentID INT PRIMARY KEY,
FirstName VARCHAR(100),
LastName VARCHAR(100),
Email VARCHAR(100),
PhoneNumber INT,
YearOfStudy INT,

);

CREATE TABLE Lecturers(
LecturerID INT PRIMARY KEY,
FirstName VARCHAR(100),
LastName VARCHAR(100),
Email VARCHAR(100),
Department VARCHAR(100),

);

CREATE TABLE Modules(
ModuleID INT PRIMARY KEY,
ModuleName VARCHAR(100),
ModuleCode VARCHAR(100) UNIQUE,
Credits INT,
AcademicYear INT,
);

CREATE TABLE ModuleAssignments(
AssignmentID INT PRIMARY KEY,
ModuleID INT,
LecturerID INT,
FOREIGN KEY (ModuleID) REFERENCES Modules(ModuleID),
FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),

);

CREATE TABLE Registrations (
RegistrationID INT PRIMARY KEY,
StudentID INT,
ModuleID INT,
FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
FOREIGN KEY (ModuleID) REFERENCES Modules(ModuleID),
);

SELECT * FROM Registrations;


