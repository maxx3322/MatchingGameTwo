CREATE TABLE [dbo].[Capital]
(
	[CapitalId] INT NOT NULL,
	[CapitalName] NVARCHAR(60) NOT NULL, 
	CONSTRAINT [PK_dbo.Capital] PRIMARY KEY CLUSTERED(CapitalId ASC)
)
