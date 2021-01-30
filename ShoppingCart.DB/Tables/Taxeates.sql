CREATE TABLE [dbo].[Taxrates]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
  [taxid] int NOT NULL DEFAULT '0',
  [rate] decimal(8,4) NOT NULL DEFAULT '0.0000',
  [start_amount] decimal(12,2) NOT NULL DEFAULT '0.00',
  [end_amount] decimal(12,2) NOT NULL DEFAULT '0.00',
  [ratetype] char(1)  NOT NULL DEFAULT '',
  CONSTRAINT [FK_Tax_ToTaxrate] FOREIGN KEY ([taxid]) REFERENCES [taxes]([Id])
)
