﻿CREATE PROCEDURE [dbo].[spCertificate_Insert]
	@Year nchar,
	@Volume int,
	@AddressID int,
	@PersonCNP BIGINT
AS
begin
	INSERT INTO dbo.[Certificate](Year, Volume, AddressID, PersonCNP)
	Values(@Year, @VOlume, @AddressID, @PersonCNP)
end
