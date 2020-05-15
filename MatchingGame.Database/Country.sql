CREATE TABLE [dbo].[Country]
(
	[CountryId] INT NOT NULL,
	[CountryName] NVARCHAR(60) NOT NULL,
	[CountryCodeTwo] NVARCHAR(2) NOT NULL, 
	[CountryCodeThree] NVARCHAR(3) NOT NULL, 
	CONSTRAINT [PK_dbo.Country] PRIMARY KEY CLUSTERED(CountryId ASC)
)
