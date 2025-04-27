Create Procedure QueryCart
	@SID NVARCHAR(50)
AS
BEGIN
	select * from Cart where Student_ID =@SID
END;
