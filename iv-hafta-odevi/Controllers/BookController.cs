using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iv_hafta_odevi.Models;
using Microsoft.AspNetCore.Mvc;

namespace iv_hafta_odevi.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View(listOfBooks);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            Book book = new Book();
            return View(book);
        }
        [HttpPost]
        public IActionResult Create(Book parbook)
        {
            if (ModelState.IsValid)
            {
                listOfBooks.Add(parbook);
                return View("Index", listOfBooks);
            }
            return View(parbook);
        }

        public List<Book> listOfBooks = new List<Book>();
        
        public BookController()
        {
            listOfBooks.Add(new Book { BookId = 1, Name=  "Book1", Author = "Author1"});
            listOfBooks.Add(new Book { BookId = 2, Name = "Book2", Author = "Author2" });
            listOfBooks.Add(new Book { BookId = 3, Name = "Book3", Author = "Author3" });
        }
    }
}
