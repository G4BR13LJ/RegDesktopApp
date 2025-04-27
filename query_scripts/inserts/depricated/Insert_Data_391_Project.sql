USE University;

-- Insert data into Student table
INSERT INTO Student (FirstName, LastName, Email, Graduated)
VALUES
    ('John', 'Doe', 'john.doe@example.com', 0),
    ('Jane', 'Smith', 'jane.smith@example.com', 1),
    ('Bob', 'Johnson', 'bob.johnson@example.com', 0),
	('Jack', 'Smith', 'jsmith@example.com', 0);

-- Insert data into Department table
INSERT INTO Department (Dept_Name, Head_Instructor_ID)
VALUES
    ('Computer Science', NULL),
    ('Mathematics', NULL),
    ('Physics', NULL),
	('Economics', NULL),
	('Psychology', NULL),
	('Accounting', NULL),
	('Business', NULL),
	('English', NULL),
	('Political Science', NULL);

-- Insert data into Instructor table
INSERT INTO Instructor (Instructor_ID, First_Name, Last_Name, Dept_Name)
VALUES
    (101, 'Michael', 'Smith', 'Computer Science'),
    (102, 'Emily', 'Jones', 'Mathematics'),
    (103, 'Robert', 'Davis', 'Physics'),
	(104, 'David', 'Axel', 'Economics'),
	(105, 'Sadie', 'Swoon', 'Psychology'),
	(106, 'Jack', 'Austin', 'Accounting'),
	(107, 'Rick', 'Gulde', 'Business'),
	(108, 'Allison', 'Hines', 'English'),
	(109, 'Mark', 'Laine', 'Political Science');

--Make Michael Head of Computer Science Department
UPDATE Department
SET Head_Instructor_ID = 101
WHERE Dept_Name = 'Computer Science';

--Make Emily Head of Mathematics Department
UPDATE Department
SET Head_Instructor_ID = 102
WHERE Dept_Name = 'Mathematics';

--Make Robert Head of Physics Department
UPDATE Department
SET Head_Instructor_ID = 103
WHERE Dept_Name = 'Physics';

--Make David Head of Economics Department
UPDATE Department
SET Head_Instructor_ID = 104
WHERE Dept_Name = 'Economics';

--Make Sadie Swoon head of Psychology Department
UPDATE Department
SET Head_Instructor_ID = 105
WHERE Dept_Name = 'Psychology';

--Make Jack Austin head of Accounting Department
UPDATE Department
SET Head_Instructor_ID = 106
WHERE Dept_Name = 'Accounting';

--Make Rick Gulde head of Business Department
UPDATE Department
SET Head_Instructor_ID = 107
WHERE Dept_Name = 'Business';

--Make Allison Hines head of English Department
UPDATE Department
SET Head_Instructor_ID = 108
WHERE Dept_Name = 'English';

--Make Mark Laine head of political science Department
UPDATE Department
SET Head_Instructor_ID = 109
WHERE Dept_Name = 'Political Science';

-- Insert data into Course table
INSERT INTO Course (Course_ID, Name, Dept_Name)
VALUES
    (1, 'CMPT 101', 'Computer Science'),
    (2, 'MATH 115', 'Mathematics'),
    (3, 'PHYS 101', 'Physics'),
    (4, 'ECON 101', 'Economics'),
    (5, 'PSYCH 101', 'Psychology'),
    (6, 'ACCT 101', 'Accounting'),
    (7, 'BUSN 101', 'Business'),
    (8, 'ENGL 101', 'English'),
    (9, 'POLS 101', 'Political Science');

-- Insert data into Timeslot table
INSERT INTO Timeslot (Timeslot_ID, Time_Start, Time_End)
VALUES
-- Monday
(1, '08:00:00', '09:00:00'),
(2, '09:00:00', '10:00:00'),
(3, '10:00:00', '11:00:00'),
(4, '11:00:00', '12:00:00'),
(5, '12:00:00', '13:00:00'),
(6, '13:00:00', '14:00:00'),
(7, '14:00:00', '15:00:00'),
(8, '15:00:00', '16:00:00'),
(9, '16:00:00', '17:00:00');

-- Insert data into Section table
INSERT INTO Section (Section_ID, Semester, Year, Course_ID, Enrolled, Capacity, Instructor_ID, Timeslot_ID)
VALUES
    (1, 'Fall', 2024, 1, 0, 40, 101, 1),
    (2, 'Fall', 2024, 2, 0, 40, 102, 2),
    (3, 'Fall', 2024, 3, 0, 30, 103, 3),
    (4, 'Fall', 2024, 4, 0, 40, 104, 4),
    (5, 'Fall', 2024, 5, 0, 40, 105, 5),
    (6, 'Fall', 2024, 6, 0, 40, 106, 6),
    (7, 'Winter', 2024, 1, 0, 40, 101, 2),
    (8, 'Winter', 2024, 2, 0, 40, 102, 2);

-- Insert data into Enrolled table
--INSERT INTO Enrolled (Student_ID, Section_ID, Semester, Year, Course_ID)
--VALUES
--    (1, 1, 'Fall', 2024, 1),

-- Insert data into Cart table
INSERT INTO Cart (Student_ID, Section_ID, Semester, Year, Course_ID, isEnrolled)
VALUES
    (1, 1, 'Fall', 2024, 1, 0),
    (2, 2, 'Fall', 2024, 2, 0),
    (3, 3, 'Fall', 2024, 3, 0);

-- Insert data into PreReq table
--INSERT INTO PreReq (Course_ID, Pre_Req_Course_ID)
--VALUES
--    (2, 1), -- Prerequisite for Calculus I is Introduction to Programming
--    (3, 2); -- Prerequisite for Physics 101 is Calculus I