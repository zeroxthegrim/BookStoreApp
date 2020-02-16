using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.BookProcessor;


namespace BookstoreApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewBooks(string searchBy, string search)
        {
            ViewBag.Message = "Book List.";

            var data = LoadBooks();

            List<BookModel> books = new List<BookModel>();

            foreach(var row in data)
            {
                books.Add(new BookModel
                {
                    BookName = row.BookName,
                    WriterName = row.WriterName,
                    Genre = row.Genre,
                    ReleaseYear = row.ReleaseYear

                });
            }

            if (searchBy == "BookName" && search.Length > 0)
            {
                return View(books.Where(x => x.BookName.ToLower().Contains(search.ToLower())).ToList());
            }

            else if (searchBy == "WriterName" && search.Length > 0)
            {
                return View(books.Where(x => x.WriterName.ToLower().Contains(search.ToLower())).ToList());
            }
            
            return View(books);
        }

        public ActionResult AddNew()
        {
            ViewBag.Message = "Add a new title.";

            return View();
        }

        [HttpPost]
        public ActionResult AddNew(BookModel model)
        {
            if (ModelState.IsValid)
            {

                int recordsCreated = CreateBook(model.BookName, model.WriterName, model.Genre, model.ReleaseYear);
                return RedirectToAction("ViewBooks");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Delete(string bookName)
        {
            DeleteBook(bookName);
            return RedirectToAction("ViewBooks");
        }

    }
}