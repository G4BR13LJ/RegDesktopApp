--Will Delete Existing Database if already exists and create a new one
IF ((SELECT count(*)
	FROM sys.databases
	WHERE name = 'University') = 1)
BEGIN
	USE master;
	ALTER DATABASE [University] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE [University];
	CREATE DATABASE University;
END
ELSE
BEGIN
	CREATE DATABASE University;
END