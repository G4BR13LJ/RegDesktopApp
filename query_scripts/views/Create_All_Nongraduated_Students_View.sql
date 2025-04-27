CREATE VIEW vW_Non_Graduated_Students
WITH SCHEMABINDING
AS

SELECT Student_ID, FirstName, LastName, Email
FROM dbo.Student
WHERE Graduated = 0

GO
CREATE UNIQUE CLUSTERED INDEX IDX_ByStudentID
	ON vW_Non_Graduated_Students(Student_ID);
