CREATE TABLE [dbo].[ShoppingCartHeader]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
  [GiftRegID] char(16) DEFAULT NULL,
  [OrderNotes] text,
  [timestamp] datetime DEFAULT NULL, 
    [SessionId] NVARCHAR(50) NULL,
)
