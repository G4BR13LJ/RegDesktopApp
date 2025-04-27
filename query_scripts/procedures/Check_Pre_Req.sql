Create Procedure CheckPreReq
	@Student_ID integer ,
	@Course_ID_to_take NVARCHAR(24)
AS
BEGIN
	Select P.Pre_Req_Course_ID
	from PreReq P
	where P.Course_ID = @Course_ID_to_take
	except
	Select t.Course_ID 
	from taken t
	where t.Student_ID = @Student_ID;
END;


