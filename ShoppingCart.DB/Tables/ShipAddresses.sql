CREATE TABLE [dbo].[ShipAddresses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,	
  [customerid] INT   NOT NULL DEFAULT '',
  [firstname] char(35)   DEFAULT '',
  [lastname] char(35)   DEFAULT '',
  [companyname] char(50)   DEFAULT NULL,
  [address_1] char(50)   DEFAULT '',
  [address_2] char(50)   DEFAULT NULL,
  [city] char(35)   DEFAULT '',
  [state] INT   DEFAULT '',
  [zipcode] char(10)   DEFAULT '',
  [dts] datetime DEFAULT '0000-00-00 00:00:00',
  [phone] char(20)   DEFAULT '',
  CONSTRAINT [FK_State_ToShipAddress] FOREIGN KEY ([State]) REFERENCES [states]([Id]),
  CONSTRAINT [FK_Customer_ToShipAddress] FOREIGN KEY ([customerId]) REFERENCES [Customers]([Id])  
)
