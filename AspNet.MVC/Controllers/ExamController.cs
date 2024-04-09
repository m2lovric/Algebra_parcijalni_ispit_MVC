using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            Author author1 = new Author
            {
                Id = 1,
                Name = "Stephen",
                LastName = "King",
                Age = 76
            };

            Author author2 = new Author
            {
                Id = 2,
                Name = "J.R.R.",
                LastName = "Tolkien",
                Age = 81
            };

            Author author3 = new Author
            {
                Id = 3,
                Name = "Margaret",
                LastName = "Atwood",
                Age = 84
            };

            Author author4 = new Author
            {
                Id = 4,
                Name = "Andy",
                LastName = "Weir",
                Age = 50
            };

            Book book1 = new Book
            {
                Id = 1,
                Title = "The Shining",
                ISBN = "978-0-451-03027-8",
                Author = author1
            };

            Book book2 = new Book
            {
                Id = 2,
                Title = "The Lord of the Rings",
                ISBN = "978-0615212200",
                Author = author2
            };

            Book book3 = new Book
            {
                Id = 3,
                Title = "The Handmaid's Tale",
                ISBN = "978-0345359943",
                Author = author3
            };

            Book book4 = new Book
            {
                Id = 4,
                Title = "It",
                ISBN = "978-0-451-02817-4",
                Author = author1
            };

            Book book5 = new Book
            {
                Id = 5,
                Title = "The Hobbit",
                ISBN = "978-0547928174",
                Author = author2
            };

            Book book6 = new Book
            {
                Id = 6,
                Title = "The Martian",
                ISBN = "978-0-446-67631-4",
                Author = author4
            };

            List<Book> books = new List<Book>() { 
                book1,
                book2,
                book3,
                book4,
                book5,
                book6
            };

            ViewBag.Books = books;
            return View();
        }
    }
}
