CREATE VIEW vW_All_Course_Info_F2024
WITH SCHEMABINDING
AS

SELECT S.Section_ID, S.Semester, S.Year, S.Course_ID, S.Enrolled, S.Capacity, S.Instructor_ID, S.Timeslot_ID, T.Time_Start, T.Time_End, C.Name, C.Dept_Name, I.First_Name, I.Last_Name
FROM dbo.Section as S, dbo.Timeslot as T, dbo.Course as C, dbo.Instructor as I
WHERE S.Timeslot_ID = T.Timeslot_ID and C.Course_ID = S.Course_ID and I.Instructor_ID = S.Instructor_ID and S.Year = '2024' and S.Semester = 'Fall'

GO
CREATE UNIQUE CLUSTERED INDEX IDX_F2024
	ON vW_All_Course_Info_F2024(Section_ID, Semester, Year, Course_ID);

