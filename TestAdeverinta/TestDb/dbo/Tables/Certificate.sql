CREATE TABLE [dbo].[Certificate]
(
    [Number] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Year] NCHAR(10) NOT NULL, 
    [Volume] INT NOT NULL, 
    [AddressID] INT NOT NULL,
    [PersonCNP] BIGINT NOT NULL, 
    FOREIGN KEY (PersonCNP) REFERENCES PersonTable(CNP),
    FOREIGN KEY (AddressID) REFERENCES AddressTable(Id),
);
