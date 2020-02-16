using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Models
{
    public class BookModel
    {
        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "You need to enter the name of the book.")]
        public string BookName { get; set; }

        [Display(Name = "Writer's Name")]
        [Required(ErrorMessage = "You need to enter the writer's name.")]
        public string WriterName { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "You need to enter the genre of the book.")]
        public string Genre { get; set; }

        [Display(Name = "Year of Release")]
        [Range(-10000, 2021, ErrorMessage = "You need to enter a valid release year.")]
        [Required(ErrorMessage = "You need to enter the year of release.")]
        public int ReleaseYear { get; set; }
    }
}