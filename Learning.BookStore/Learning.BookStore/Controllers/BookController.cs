using Learning.BookStore.Models;
using Learning.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.BookStore.Controllers
{
    public class BookController : Controller
    {
        [ViewData]
        public string Title { get; set; }
        
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            Title = "All Books from controller";
            var data = _bookRepository.GetAllBooks();

            return View(data);
        }
        
        [Route("book-details/{id}", Name ="bookDetailsRoute")]
        public ViewResult GetBookById(int id)
        {
            var data = _bookRepository.GetBookById(id);

            Title = "Book of " +data.Title+" from controller";

            return View(data);
        }
        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
