Create Procedure FillClassTablesF
as
Begin
	select * from vW_All_Course_Info_F2024 with(noexpand) order by Course_ID;
END;