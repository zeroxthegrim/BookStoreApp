/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('The Grand Design', 'Stephen Hawking', 'Science', 2010);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('The Alchemist', 'Paulo Coelho', 'Fiction', 1984);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('To Kill a Mockingbird', 'Harper Lee', 'Classic', 1960);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('1984', 'George Orwell', 'Classic', 1949);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('And There Were None', 'Agatha Christie', 'Crime', 1939);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('The Hobbit', 'J.R.R. Tolkien', 'Adventure', 1937);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('Life of Pi', 'Yann Martel', 'Adventure', 2001);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('Beauty And The Beast', 'Gabrielle-Suzanne de Villeneuve', 'Fairy Tale', 1740);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('Harry Potter And The Sorcerer’s Stone', 'J.K. Rowling', 'Fantasy', 1997);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('A Game of Thrones', 'George R.R. Martin', 'Fantasy', 1996);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('The Shining', 'Stephen King', 'Horror', 1977);

insert into dbo.Books (BookName,WriterName, Genre, ReleaseYear)
values ('It', 'Stephen King', 'Horror', 1986);
