create Procedure generateFallSchedule
	@SID int
as 
begin
	SELECT t.Course_ID, t.Section_ID, 
		   ts.Time_Start, ts.Time_End
	FROM taken t
	JOIN Section s ON t.Course_ID = s.Course_ID 
				   AND t.Section_ID = s.Section_ID 
				   AND t.Semester = s.Semester 
				   AND t.Year = s.Year
	JOIN Timeslot ts ON ts.Timeslot_ID = s.Timeslot_ID
	WHERE t.Student_ID = @SID
	  AND t.Year = 2024
	  AND t.Semester = 'Fall'
	  order by Time_Start;
end;

