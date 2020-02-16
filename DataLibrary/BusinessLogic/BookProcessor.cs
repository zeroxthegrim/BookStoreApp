using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class BookProcessor
    {
        public static int CreateBook(string bookName, string writerName, string genre, int releaseYear)
        {
            BookModel data = new BookModel
            {
                BookName = bookName,
                WriterName = writerName,
                Genre = genre,
                ReleaseYear = releaseYear
            };

            string sql = @"insert into dbo.Books (BookName, WriterName, Genre, ReleaseYear) values (@BookName, @WriterName, @Genre, @ReleaseYear);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<BookModel> LoadBooks()
        {
            string sql = @"select Id, BookName, WriterName, Genre, ReleaseYear from dbo.Books;";

            return SqlDataAccess.LoadData<BookModel>(sql);
        }

        public static void DeleteBook(string bookName)
        {
            
            string sql = @"delete from dbo.Books where BookName = @bookName;";
            SqlDataAccess.DeleteRow(sql, bookName);
        }

    }
}
