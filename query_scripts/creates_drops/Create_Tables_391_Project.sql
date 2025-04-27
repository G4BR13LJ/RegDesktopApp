-- Script Creates all tables inside University
-- FALL CMPT 391
Use University;


--Create table Student
CREATE TABLE Student
(
    Student_ID INT          NOT NULL PRIMARY KEY,
    FirstName  VARCHAR(40) NOT NULL,
    LastName   VARCHAR(40) NOT NULL,
    Email      VARCHAR(40) NOT NULL,
    Graduated  BIT
);


-- Create table Department
CREATE TABLE Department
(
    Dept_Name VARCHAR(40) NOT NULL PRIMARY KEY
);


-- Create table Course
CREATE TABLE Course
(
    Course_ID VARCHAR(24) NOT NULL PRIMARY KEY,
    Name      VARCHAR(40) NOT NULL,
    Dept_Name VARCHAR(40) NOT NULL,
    FOREIGN KEY (Dept_Name) REFERENCES Department (Dept_Name)
);


-- Create table Instructor
CREATE TABLE Instructor
(
    Instructor_ID INT NOT NULL PRIMARY KEY,
    First_Name   VARCHAR(40),
    Last_Name    VARCHAR(40),
    Dept_Name    VARCHAR(40),
    FOREIGN KEY (Dept_Name) REFERENCES Department (Dept_Name)
);


-- Create table Timeslot
CREATE TABLE Timeslot
(
    Timeslot_ID INT          NOT NULL PRIMARY KEY,
    Time_Start  TIME         NOT NULL,
    Time_End    TIME         NOT NULL
);


-- Create table Section
CREATE TABLE Section
(
    Section_ID    INT          NOT NULL,
    Semester      VARCHAR(24) NOT NULL,
    Year          INT          NOT NULL,
    Course_ID     VARCHAR(24) NOT NULL,
    Enrolled      INT,
    Capacity      INT,
    Instructor_ID INT,
    Timeslot_ID   INT,
    PRIMARY KEY (Section_ID, Semester, Year, Course_ID),
    FOREIGN KEY (Instructor_ID) REFERENCES Instructor (Instructor_ID),
    FOREIGN KEY (Course_ID) REFERENCES Course (Course_ID),
    FOREIGN KEY (Timeslot_ID) REFERENCES Timeslot (Timeslot_ID)
);


-- Create table Taken
CREATE TABLE Taken
(
    Student_ID INT          NOT NULL,
    Section_ID INT          NOT NULL,
    Semester   VARCHAR(24) NOT NULL,
    Year       INT          NOT NULL,
    Course_ID  VARCHAR(24) NOT NULL,
    PRIMARY KEY (Student_ID, Section_ID, Semester, Year, Course_ID),
    FOREIGN KEY (Student_ID) REFERENCES Student (Student_ID),
    FOREIGN KEY (Section_ID, Semester, Year, Course_ID) REFERENCES Section (Section_ID, Semester, Year, Course_ID)
);

-- Create table Cart
CREATE TABLE Cart
(
    Student_ID INT          NOT NULL,
    Section_ID INT          NOT NULL,
    Semester   VARCHAR(24) NOT NULL,
    Year       INT          NOT NULL,
    Course_ID  VARCHAR(24) NOT NULL,
    PRIMARY KEY (Student_ID, Section_ID, Semester, Year, Course_ID),
    FOREIGN KEY (Student_ID) REFERENCES Student (Student_ID),
    FOREIGN KEY (Section_ID, Semester, Year, Course_ID) REFERENCES Section (Section_ID, Semester, Year, Course_ID)
);


-- Create table PreReq
CREATE TABLE PreReq
(
    Course_ID         VARCHAR(24) NOT NULL,
    Pre_Req_Course_ID VARCHAR(24) NOT NULL,
    PRIMARY KEY (Course_ID, Pre_Req_Course_ID),
    FOREIGN KEY (Course_ID) REFERENCES Course (Course_ID),
    FOREIGN KEY (Pre_Req_Course_ID) REFERENCES Course (Course_ID)
);


-- Adds Head_Instructor_ID column as a foreign key to Department table
ALTER TABLE Department
	ADD Head_Instructor_ID INT 
	CONSTRAINT FK_Department_Head FOREIGN KEY (Head_Instructor_ID) 
	REFERENCES Instructor(Instructor_ID);

-- Constraint, prevents two departments from having same Head_Instructor_ID
CREATE UNIQUE NONCLUSTERED INDEX idx_tbl_Department
ON Department(Head_Instructor_ID)
WHERE Head_Instructor_ID IS NOT NULL
GO
