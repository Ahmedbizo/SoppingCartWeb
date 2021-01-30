CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
 [pricelevel] nvarchar(15)   DEFAULT NULL,
 [firstname] nvarchar(35)   DEFAULT NULL,
 [lastname] nvarchar(35)   DEFAULT NULL,
 [companyname] nvarchar(50)   DEFAULT NULL,
 [address_1] nvarchar(55)   DEFAULT NULL,
 [address_2] nvarchar(55)   DEFAULT NULL,
 [city] nvarchar(35)   DEFAULT NULL,
 [state] INT   DEFAULT NULL,
 [zipcode] nvarchar(10)   DEFAULT NULL,
 [phone] nvarchar(20)   DEFAULT NULL,
 [email] nvarchar(55)   DEFAULT NULL,
 [maillist] INT DEFAULT NULL,
 [providerinfo] nvarchar(50)   DEFAULT NULL,
 [dts] datetime DEFAULT NULL,
 [password] nvarchar(30)   DEFAULT NULL,
 [taxable] INT DEFAULT '1',
 CONSTRAINT [FK_State_ToCustomer] FOREIGN KEY ([state]) REFERENCES [States]([Id])
)
