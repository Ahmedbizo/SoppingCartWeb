CREATE TABLE [dbo].[ShipMethods]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,

 [name] char(75) NOT NULL DEFAULT '',
 [providerinfo] char(25) NOT NULL DEFAULT '',
 [sortorder] INT DEFAULT NULL
)
