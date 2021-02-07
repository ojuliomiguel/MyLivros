using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBookManager.Models
{
    public class BookAuthorViewModel
    {
        public List<Book> Books { get; set; }
        public SelectList Authors { get; set; }
        public string BookAuthor { get; set; }

        public string SearchString { get; set; }
    }
}
