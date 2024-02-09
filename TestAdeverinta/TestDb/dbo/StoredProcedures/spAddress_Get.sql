CREATE PROCEDURE [dbo].[spAddress_Get]
	@Id int
AS
begin
	Select *
	From dbo.AddressTable
	where Id = @Id
end
