Create Procedure RemoveFromCart
	@studentID INT,
	@sectionID INT,
	@semester VARCHAR(24),
	@year INT,
	@courseID VARCHAR(24)
as
begin
	delete from Cart
	where
			Student_ID = @studentID
		and Section_ID = @sectionID
		and Semester   = @semester
		and Year       = @year
		and Course_ID  = @courseID;
end;