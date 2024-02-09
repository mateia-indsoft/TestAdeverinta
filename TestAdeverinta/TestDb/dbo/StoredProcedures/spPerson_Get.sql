CREATE PROCEDURE [dbo].[spPerson_Get]
	@CNP int
AS
begin
	select *
	from dbo.[PersonTable]
	where CNP = @CNP;
end
