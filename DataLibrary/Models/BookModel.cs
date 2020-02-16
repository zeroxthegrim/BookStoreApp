using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
    }
}
