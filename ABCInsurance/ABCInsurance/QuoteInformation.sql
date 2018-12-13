CREATE TABLE [dbo].[QuoteInformation]
(
	[DriverId] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [EmailAddress] VARCHAR(50) NOT NULL, 
    [DateofBirth] DATE NOT NULL 
)
