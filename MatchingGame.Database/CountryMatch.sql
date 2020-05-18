CREATE TABLE [dbo].[CountryMatch]
(
	[CountryCapitalMatchId] INT NOT NULL,
	[CountryId] INT NOT NULL,
	[CapitalId] INT NOT NULL,
	[CountryName] NCHAR(60) NOT NULL, 
    [CapitalName] NCHAR(60) NOT NULL, 
    FOREIGN KEY (CountryId) REFERENCES Country(CountryId),
	FOREIGN KEY (CapitalId) REFERENCES Capital (CapitalId),
	PRIMARY KEY (CountryCapitalMatchId)
	


)
