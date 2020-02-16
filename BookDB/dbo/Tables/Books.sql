CREATE TABLE [dbo].[Books]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookName] NVARCHAR(50) NOT NULL, 
    [WriterName] NVARCHAR(50) NOT NULL, 
    [Genre] NVARCHAR(50) NOT NULL,
    [ReleaseYear] INT NOT NULL    
)


