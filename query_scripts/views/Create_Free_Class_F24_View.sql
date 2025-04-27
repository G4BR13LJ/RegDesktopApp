--all classes in 2024, where enrolled < capacity & term = fall
CREATE VIEW vWFree_Classes_Fall_2024
   WITH SCHEMABINDING
AS  
SELECT Section_ID, Semester, Year, Course_ID, Enrolled, Capacity, Instructor_ID, Timeslot_ID
FROM dbo.Section
WHERE Semester = 'Fall' AND Enrolled < Capacity

GO
CREATE UNIQUE CLUSTERED INDEX vWFree_Classes_Fall_2024
	ON vWFree_Classes_Fall_2024(Section_ID, Semester, Year, Course_ID);
