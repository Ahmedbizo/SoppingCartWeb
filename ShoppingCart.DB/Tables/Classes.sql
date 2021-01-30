CREATE TABLE [dbo].[Classes]
(
 [Id] INT NOT NULL PRIMARY KEY IDENTITY,
 [departmentId] INT   NOT NULL DEFAULT '',
 [name] nvarchar(40)   DEFAULT NULL,
 [web] INT DEFAULT NULL,
 [description] text  ,
 [pictureext] char(3)   DEFAULT NULL,
 CONSTRAINT [FK_Departments_ToTable] FOREIGN KEY ([departmentId]) REFERENCES [Departments]([Id])
)
