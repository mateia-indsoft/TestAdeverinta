CREATE PROCEDURE [dbo].[spPerson_Get]
	@CNP BIGINT
AS
begin
	select *
	from dbo.[PersonTable]
	where CNP = @CNP;
end
