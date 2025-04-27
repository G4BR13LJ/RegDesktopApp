create Procedure Check_Taken_TimeSlot
	@Student_ID integer,
	@Semester NVARCHAR(24),
	@Year integer,
	@Course_ID_to_take NVARCHAR(24),
	@Section_ID_to_take integer

AS
Begin
	select Timeslot_ID
	from section s1
	where @Course_ID_to_take=s1.Course_ID and
		  @Semester=s1.semester and 
		  @Year=s1.year and
		  @Section_ID_to_take=s1.section_ID
	except
	select Timeslot_ID
	from taken t, section s
	where t.Course_ID=s.Course_ID and 
		  t.Semester=s.Semester and 
		  t.Year=s.year and
		  t.Section_ID=s.Section_ID and
		  @Student_ID=t.Student_ID and
		  @Semester=t.Semester and
		  @Year=t.Year
END;