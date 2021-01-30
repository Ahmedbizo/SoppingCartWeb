CREATE TABLE [dbo].[ShoppingCartLine]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY,
  [CartID] INT NOT NULL,
  [SkuId] INT NOT NULL,
  [Quantity] INT DEFAULT NULL,
  [Line_No] char(40) NOT NULL,
  [Parent_line_no] INT DEFAULT NULL,
  [Personalization] char(254) DEFAULT NULL,
  [flags] char(10) DEFAULT NULL,
  CONSTRAINT [FK_ShoppingCartHeader_ToPShoppingCartLine] FOREIGN KEY ([CartId]) REFERENCES [ShoppingCartHeader]([Id]),
  CONSTRAINT [FK_Sku_cartHeader] FOREIGN KEY ([skuid]) REFERENCES [skus]([Id])
)
