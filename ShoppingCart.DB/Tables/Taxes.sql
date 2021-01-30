CREATE TABLE [dbo].[Taxes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	
  [taxtype] char(1)  NOT NULL DEFAULT '',
  [name] char(30) DEFAULT ''
)
