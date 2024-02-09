CREATE PROCEDURE [dbo].[spCertificate_Get]
	@Number int
AS
begin
	Select *
	From dbo.[Certificate]
	where Number = @Number
end
