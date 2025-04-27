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
    (1, 'Michael', 'Smith', 'Computer Science'),
    (2, 'Emily', 'Jones', 'Mathematics'),
    (3, 'Robert', 'Davis', 'Physics'),
	(4, 'David', 'Axel', 'Economics'),
	(5, 'Sadie', 'Swoon', 'Psychology'),
	(6, 'Jack', 'Austin', 'Accounting'),
	(7, 'Rick', 'Gulde', 'Business'),
	(8, 'Allison', 'Hines', 'English'),
	(9, 'Mark', 'Laine', 'Political Science'),
	(10, 'Rachel', 'Miller', 'Computer Science'),
    (11, 'Brandon', 'Clark', 'Mathematics'),
    (12, 'Samantha', 'Turner', 'Physics'),
    (13, 'Peter', 'Baker', 'Economics'),
    (14, 'Lily', 'Reed', 'Psychology'),
    (15, 'Charlie', 'Woods', 'Accounting'),
    (16, 'Catherine', 'Fisher', 'Business'),
    (17, 'Jason', 'Hudson', 'English'),
    (18, 'Lauren', 'Martin', 'Political Science');


--Make Michael Head of Computer Science Department
UPDATE Department
SET Head_Instructor_ID = 1
WHERE Dept_Name = 'Computer Science';

--Make Emily Head of Mathematics Department
UPDATE Department
SET Head_Instructor_ID = 2
WHERE Dept_Name = 'Mathematics';

--Make Robert Head of Physics Department
UPDATE Department
SET Head_Instructor_ID = 3
WHERE Dept_Name = 'Physics';

--Make David Head of Economics Department
UPDATE Department
SET Head_Instructor_ID = 4
WHERE Dept_Name = 'Economics';

--Make Sadie Swoon head of Psychology Department
UPDATE Department
SET Head_Instructor_ID = 5
WHERE Dept_Name = 'Psychology';

--Make Jack Austin head of Accounting Department
UPDATE Department
SET Head_Instructor_ID = 6
WHERE Dept_Name = 'Accounting';

--Make Rick Gulde head of Business Department
UPDATE Department
SET Head_Instructor_ID = 7
WHERE Dept_Name = 'Business';

--Make Allison Hines head of English Department
UPDATE Department
SET Head_Instructor_ID = 8
WHERE Dept_Name = 'English';

--Make Mark Laine head of political science Department
UPDATE Department
SET Head_Instructor_ID = 9
WHERE Dept_Name = 'Political Science';


-- Insert data into Course table
INSERT INTO Course (Course_ID, Name, Dept_Name)
VALUES
    ('CMPT 101' , 'Intro ', 'Computer Science'),
    ('MATH 101' , 'Intro' , 'Mathematics'),
    ('PHYS 101' , 'Intro' , 'Physics'),
    ('ECON 101' , 'Intro' , 'Economics'),
    ('PSYCH 101', 'Intro' , 'Psychology'),
    ('ACCT 101' , 'Intro' , 'Accounting'),
    ('BUSN 101' , 'Intro' , 'Business'),
    ('ENGL 101' , 'Intro' , 'English'),
    ('POLS 101' , 'Intro' , 'Political Science'),
	('CMPT 201' , 'Intermediate ', 'Computer Science'),
    ('MATH 201' , 'Intermediate' , 'Mathematics'),
    ('PHYS 201' , 'Intermediate' , 'Physics'),
    ('ECON 201' , 'Intermediate' , 'Economics'),
    ('PSYCH 201', 'Intermediate' , 'Psychology'),
    ('ACCT 201' , 'Intermediate' , 'Accounting'),
    ('BUSN 201' , 'Intermediate' , 'Business'),
    ('ENGL 201' , 'Intermediate' , 'English'),
    ('POLS 201' , 'Intermediate' , 'Political Science'),
	('CMPT 301' , 'Advanced' , 'Computer Science'),
    ('MATH 301' , 'Advanced' , 'Mathematics'),
    ('PHYS 301' , 'Advanced' , 'Physics'),
    ('ECON 301' , 'Advanced' , 'Economics'),
    ('PSYCH 301', 'Advanced' , 'Psychology'),
    ('ACCT 301' , 'Advanced' , 'Accounting'),
    ('BUSN 301' , 'Advanced' , 'Business'),
    ('ENGL 301' , 'Advanced' , 'English'),
    ('POLS 301' , 'Advanced' , 'Political Science'),
	('CMPT 401' , 'Graduate' , 'Computer Science'),
    ('MATH 401' , 'Graduate' , 'Mathematics'),
    ('PHYS 401' , 'Graduate' , 'Physics'),
    ('ECON 401' , 'Graduate' , 'Economics'),
    ('PSYCH 401', 'Graduate' , 'Psychology'),
    ('ACCT 401' , 'Graduate' , 'Accounting'),
    ('BUSN 401' , 'Graduate' , 'Business'),
    ('ENGL 401' , 'Graduate' , 'English'),
    ('POLS 401' , 'Graduate' , 'Political Science')
	;

-- Insert data into Student table
INSERT INTO Student (Student_ID, FirstName, LastName, Email, Graduated)
VALUES
    (1, 'John', 'Doe', 'john.doe@example.com', 1),
    (2, 'Jane', 'Smith', 'jane.smith@example.com', 1),
    (3, 'Bob', 'Johnson', 'bob.johnson@example.com', 0),
    (4, 'Jack', 'Smith', 'jsmith@example.com', 0),
    (5, 'Alice', 'Williams', 'alice.williams@example.com', 0),
    (6, 'Michael', 'Brown', 'michael.brown@example.com', 0),
    (7, 'Emily', 'Davis', 'emily.davis@example.com', 0),
    (8, 'David', 'Miller', 'david.miller@example.com', 0),
    (9, 'Sophia', 'Jones', 'sophia.jones@example.com', 0),
    (10, 'Christopher', 'Wilson', 'chris.wilson@example.com', 0),
    (11, 'Olivia', 'Anderson', 'olivia.anderson@example.com', 0),
    (12, 'Daniel', 'Taylor', 'daniel.taylor@example.com', 0),
    (13, 'Grace', 'Martinez', 'grace.martinez@example.com', 0),
    (14, 'Matthew', 'Lee', 'matthew.lee@example.com', 0);

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

--Insert data into Prereq table
INSERT INTO Prereq (Course_ID, Pre_Req_Course_ID)
Values
 ('CMPT 201' , 'CMPT 101' ),
 ('MATH 201' , 'MATH 101' ),
 ('PHYS 201' , 'PHYS 101' ),
 ('ECON 201' , 'ECON 101' ),
 ('PSYCH 201', 'PSYCH 101'),
 ('ACCT 201' , 'ACCT 101' ),
 ('BUSN 201' , 'BUSN 101' ),
 ('ENGL 201' , 'ENGL 101' ),
 ('POLS 201' , 'POLS 101' ),
 ('CMPT 301' , 'CMPT 201' ),
 ('MATH 301' , 'MATH 201' ),
 ('PHYS 301' , 'PHYS 201' ),
 ('ECON 301' , 'ECON 201' ),
 ('PSYCH 301', 'PSYCH 201'),
 ('ACCT 301' , 'ACCT 201' ),
 ('BUSN 301' , 'BUSN 201' ),
 ('ENGL 301' , 'ENGL 201' ),
 ('POLS 301' , 'POLS 201' ),
 ('CMPT 401' , 'CMPT 301'),
 ('MATH 401' , 'MATH 301'),
 ('PHYS 401' , 'PHYS 301'),
 ('ECON 401' , 'ECON 301'),
 ('PSYCH 401', 'PSYCH 301'),
 ('ACCT 401' , 'ACCT 301'),
 ('BUSN 401' , 'BUSN 301'),
 ('ENGL 401' , 'ENGL 301'),
 ('POLS 401' , 'POLS 301');

