-- Create Procedure CheckTimeslot
-- 	@Semester NVARCHAR(50),
-- 	@Year INT,
-- 	@Course_ID NVARCHAR(50),
-- 	@Section_ID INT
--     @
-- AS
-- BEGIN
-- 	Select S1.TimeSlot_ID
-- 	from Section S1
-- 	where S1.Semester=@Semester and S1.Year=@Year
-- 	and S1.Course_ID=@Course_ID
-- 	and S1.Section_ID=1
-- 	except
-- 	select S2.Timeslot_ID from section S2, cart C
-- 	where S2.Semester = C.Semester
-- 	and S2.Year=C.Year
-- 	and S2.Course_ID  = C.Course_ID
-- 	and S2.Section_ID = C.Section_ID;
-- END;

CREATE PROCEDURE CheckTimeSlot @Student_ID INT,
                               @Course_ID NVARCHAR(50),
                               @Section_ID NVARCHAR(50),
                               @Semester NVARCHAR(50),
                               @Year INT
AS
BEGIN
    select *
    from Section S,
         (select Timeslot_ID
          from Section
                   JOIN Cart ON Section.Section_ID = Cart.Section_ID
              and Section.Semester = Cart.Semester
              and Section.Year = Cart.Year
              and Section.Course_ID = Cart.Course_ID
          where Student_ID = @Student_ID) as C
    where S.Course_ID = @Course_ID
      and S.Section_ID = @Section_ID
      and S.Semester = @Semester
      and S.Year = @Year
      and S.Timeslot_ID = C.Timeslot_ID
END
