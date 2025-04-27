--all classes in 2024, where enrolled < capacity & term = winter
CREATE VIEW vWFree_Classes_Winter_2024
   WITH SCHEMABINDING
AS  
SELECT Section_ID, Semester, Year, Course_ID, Enrolled, Capacity, Instructor_ID, Timeslot_ID
FROM dbo.Section
WHERE Semester = 'Winter' AND Enrolled < Capacity

GO
CREATE UNIQUE CLUSTERED INDEX IDX_WFCW2024
	ON vWFree_Classes_Winter_2024(Section_ID, Semester, Year, Course_ID);