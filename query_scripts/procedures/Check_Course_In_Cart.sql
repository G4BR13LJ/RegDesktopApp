Create Procedure Check_Course_In_Cart
	@Student_ID integer,
	@Course_ID_to_take NVARCHAR(24)
AS
BEGIN
	Select Course_ID
	from Cart C
	where @Student_ID=C.Student_ID and @Course_ID_to_take=C.Course_ID;
END;

