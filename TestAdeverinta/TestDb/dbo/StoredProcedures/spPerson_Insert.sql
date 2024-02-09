CREATE PROCEDURE [dbo].[spPerson_Insert]
	@CNP int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	insert into dbo.[PersonTable] (CNP, FirstName, LastName)
	values (@CNP, @FirstName, @LastName);
end
