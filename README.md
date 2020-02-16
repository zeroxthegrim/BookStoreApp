# BookstoreApp
ASP.NET MVC Demo App that connects to Microsoft SQL Server DB to save, load or delete data. 

1. Open in Visual Studio

2. One of the projects is called 'BooksDB'. That it the SQL Server Project that includes tables and publish script that will run 
when database is published. Right-click on 'BooksDB' project, then select 'publish'. Publish it on local MSSQLLocalDB; 
it has to be named 'BooksDB' to work.

3. It uses 'Dapper' for data access. If compiler throws errors about not recognizing Dapper just click on 'build Solution'.
