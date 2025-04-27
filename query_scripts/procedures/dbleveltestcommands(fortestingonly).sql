select * from cart where Student_ID = 10;
select * from taken where Student_ID = 10 order by Course_ID;

select * from taken where Student_ID = 10 AND Course_ID = 'ACCT 301';
select * from taken where Student_ID = 10 AND Course_ID = 'ENGL 301';

select * from section where enrolled = 10;

INSERT INTO cart (Student_ID, Section_ID, Semester, Year, Course_ID) VALUES (10, 1, 'Fall', 2020, 'BUSN 101');

select * from section where Enrolled = 10;


DELETE from taken where student_id = 10 AND Course_ID = 'ACCT 301';
DELETE from taken where student_id = 10;
DELETE from Cart where student_id = 10;

select * from PreReq where Course_ID = 'POLS 401';

exec CheckTimeslot @Semester = 'Fall', @Year = 2024, @Course_ID = 'BUSN 101', @Section_ID = 2;
select * from Timeslot;

SELECT t.Course_ID, t.Section_ID, 
		   ts.Time_Start, ts.Time_End
	FROM taken t
	JOIN Section s ON t.Course_ID = s.Course_ID 
				   AND t.Section_ID = s.Section_ID 
				   AND t.Semester = s.Semester 
				   AND t.Year = s.Year
	JOIN Timeslot ts ON ts.Timeslot_ID = s.Timeslot_ID
	WHERE t.Student_ID = 10
	  AND t.Year = 2024
	  AND t.Semester = 'Fall';
