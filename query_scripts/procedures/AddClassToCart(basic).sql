Create Procedure AddClassToCart
	@SID INT,
	@SecID INT,
	@Sem NVARCHAR(24),
	@Year INT,
	@CourseID NVARCHAR(24)
AS
BEGIN
	INSERT INTO Cart (Student_ID, Section_ID, Semester, [Year], Course_ID)
    VALUES (@SID, @SecID, @Sem, @Year, @CourseID)
END;