CREATE PROCEDURE [dbo].[spPerson_GetAll]
AS
begin 
	select *
	from dbo.[PersonTable]
end
