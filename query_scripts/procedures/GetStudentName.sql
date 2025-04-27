Create Procedure StudentLogin
    @SID NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Student
    WHERE Student_ID = @SID
END;