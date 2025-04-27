Create Procedure AddToCart
	@studentID INT,
	@sectionID INT,
	@semester VARCHAR(24),
	@year INT,
	@courseID VARCHAR(24)
as
begin
	insert into Cart (Student_ID, Section_ID, Semester, Year, Course_ID)
	values (@studentID, @sectionID, @semester, @year, @courseID)
end;