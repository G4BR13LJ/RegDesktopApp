--Returns The PreReq_Course_ID IF They have not taken it
create procedure Check_Pre_Req_Fall
    @Student_ID integer,
    @Course_ID_to_take NVARCHAR(24),
    @Year integer
AS
Begin
    Select Pre_Req_Course_ID
    from PreReq pr
    where @Course_ID_to_take=pr.Course_ID
    except
    select t.Course_ID
    from taken t
    where @Year > t.year and @Student_ID= t.Student_ID;
END;