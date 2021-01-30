CREATE TABLE [dbo].[shiprates]
(
	[Id] INT NOT NULL, 
    [ShipMethodId] INT NOT NULL, 
    [Amount] DECIMAL NOT NULL, 
    [StartAmount] DECIMAL NOT NULL, 
    [EndAmount] DECIMAL NOT NULL,
	CONSTRAINT [FK_ShipMethod_ToShipRates] FOREIGN KEY ([ShipMethodId]) REFERENCES [ShipMethods]([Id])
)
 
