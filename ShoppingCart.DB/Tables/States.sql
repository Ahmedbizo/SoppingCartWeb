CREATE TABLE [dbo].[States]
(
 [Id] INT NOT NULL PRIMARY KEY IDENTITY,
 [name] char(50)  NOT NULL DEFAULT '',
 [providerinfo] char(25)  DEFAULT '',
 [taxid] int NOT NULL DEFAULT '0',
 [taxableShipping] INT DEFAULT '0', 
 [Code] NVARCHAR(50) NULL
)
