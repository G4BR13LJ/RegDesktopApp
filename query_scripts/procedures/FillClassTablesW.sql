Create Procedure FillClassTablesW
as
Begin
	select * from vW_All_Course_Info_W2024 with(noexpand) order by Course_ID;
END;