-- A transaction that enrolls a student into a class.

-- [EXAMPLE CALL]
-- txEnrollClass @StudentID = 1, @SectionID = 1, @Semester = 'Winter', @Year = 2020, @CourseID = 'CMPT 101';

CREATE PROCEDURE txEnrollClass @StudentID INT,
                               @SectionID INT,
                               @Semester VARCHAR(24),
                               @Year INT,
                               @CourseID VARCHAR(24)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;
        -- Start the transaction

        -- Check if enrollment is less than capacity for the section
        DECLARE @Enrolled INT;
        DECLARE @Capacity INT;
        SELECT @Enrolled = Enrolled, @Capacity = Capacity
        FROM Section
        WHERE Section_ID = @SectionID
          AND Semester = @Semester
          AND Year = @Year
          AND Course_ID = @CourseID;

        IF @Enrolled < @Capacity
            BEGIN
                -- Insert into Taken table
                INSERT INTO Taken (Student_ID, Section_ID, Semester, Year, Course_ID)
                VALUES (@StudentID, @SectionID, @Semester, @Year, @CourseID);

                -- Increment Enrolled count in Section table
                UPDATE Section
                SET Enrolled = Enrolled + 1
                WHERE Section_ID = @SectionID
                  AND Semester = @Semester
                  AND Year = @Year
                  AND Course_ID = @CourseID;

                COMMIT TRANSACTION; -- Commit the transaction
            END
        ELSE
            BEGIN
                -- Enrollment exceeds capacity, rollback transaction
				ROLLBACK TRANSACTION;
                RAISERROR ('Enrollment exceeds capacity for this section.', 16, 1);
                
            END
    END TRY
    BEGIN CATCH
        -- Handle the error or raise it back to the caller
        THROW;
    END CATCH
END;
