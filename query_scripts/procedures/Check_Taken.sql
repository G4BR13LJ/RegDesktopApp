create Procedure Check_Taken
    @Student_ID integer,
    @Course_ID_to_take NVARCHAR(50),
    @Semester NVARCHAR(50),
    @Year integer,
    @Section_ID integer
AS
Begin
    select *
    from taken t
    where @Student_ID=t.Student_ID and 
          @Course_ID_to_take=t.Course_ID and
          @Semester=t.Semester and
          @Year=t.Year;-- and
          --@Section_ID=t.Section_ID;
END;