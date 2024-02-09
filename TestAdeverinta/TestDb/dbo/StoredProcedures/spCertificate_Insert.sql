CREATE PROCEDURE [dbo].[spCertificate_Insert]
	@Year nchar,
	@Volume int,
	@AddressID int,
	@PersonCNP int
AS
	INSERT INTO dbo.[Certificate](Year, Volume, AddressID, PersonCNP)
RETURN 0
