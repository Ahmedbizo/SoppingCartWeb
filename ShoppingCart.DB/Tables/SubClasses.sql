CREATE TABLE [dbo].[SubClasses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	
 [departmentId] INT  NOT NULL DEFAULT '',
 [classId] int   NOT NULL DEFAULT '',
 [name] nvarchar(40)   DEFAULT NULL,
 [web] INT DEFAULT NULL,
 [description] text  ,
 [pictureext] char(3)   DEFAULT NULL,
  CONSTRAINT [FK_Departments_ToSubClass] FOREIGN KEY ([departmentId]) REFERENCES [Departments]([Id]),
   CONSTRAINT [FK_Class_ToSubClass] FOREIGN KEY ([ClassId]) REFERENCES [Classes]([Id])
)
