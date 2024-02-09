CREATE PROCEDURE [dbo].[spAddress_Insert]
	@City nvarchar(50),
	@Village nvarchar(50),
	@Street nvarchar(50),
	@Number int
AS
BEGIN
	INSERT INTO dbo.[AddressTable](City, Village, Street, Number)
	values (@City, @Village, @Street, @Number);
END
