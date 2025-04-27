Create Procedure SectionSearchW
    @SecID NVARCHAR(24),
	@CouID NVARCHAR(24)
AS
BEGIN
	select * 
	from vW_All_Course_Info_W2024 with(noexpand)
	where Section_ID = @SecID and Course_ID = @CouID
	order by Course_ID;
END;