using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVCBookManager.Data;
using MVCBookManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBookManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcBookContext _context;

        public HomeController(ILogger<HomeController> logger, MvcBookContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            IQueryable<string> authorQuery = from author in _context.Book
                                             orderby author.Author
                                             select author.Author;
            var books = from book in _context.Book
                        where book.IsAvailable == true
                        select book;
            var bookAuthorVM = new BookAuthorViewModel
            {
                Authors = new SelectList(await authorQuery.Distinct().ToListAsync()),
                Books = await books.ToListAsync()
            };

            return View(bookAuthorVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}