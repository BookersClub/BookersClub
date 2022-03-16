CREATE TABLE [dbo].[User]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,	         
    [FirstName] VARCHAR(30) NOT NULL,       
    [LastName]  VARCHAR(30) NOT NULL,
    [DateOfBirth] Date NOT NULL,
    [Address1]  VARCHAR(60) NOT NULL,
    [Address2]  VARCHAR(60) NOT NULL,      
    [City] VARCHAR(30) NOT NULL,
    [Country] VARCHAR(30) NOT NULL,
    [State] VARCHAR(30) NOT NULL,
    [zipcode] VARCHAR(6) NOT NULL,
    [EmailAddress] VARCHAR(30) NOT NULL,
    [Password] VARCHAR(30) NOT NULL,
)
