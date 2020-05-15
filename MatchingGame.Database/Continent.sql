CREATE TABLE [dbo].[Continent]
(
	[ContinentId] INT NOT NULL,
	[ContinentName] NVARCHAR(60) NOT NULL, 
	CONSTRAINT [PK_dbo.Continent] PRIMARY KEY CLUSTERED(ContinentId ASC)

)
