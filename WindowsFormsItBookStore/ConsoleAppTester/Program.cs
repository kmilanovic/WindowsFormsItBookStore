using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Text.RegularExpressions;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {

            // Convertao sam property "Price" u decimal u metodi GetBooks(), U bazi mi je tip kolone "Price" takoder decimal


            var bookRepo = new BookRepository();
            //var books = bookRepo.SearchBook("html");
            Book _book = new Book();
            _book.Title = "bezze";
            _book.Subtitle = "Programming Secure Oracle Database Applications With Java";
            _book.Isbn = "9781430238317";
            _book.Price = "$22.33";
            _book.Price =_book.Price.Remove(0, 1);
            _book.Image = "https://itbook.store/img/books/9781430238317.png";
            _book.Url = "https://itbook.store/books/9781430238317";
             bookRepo.AddBook(_book);
            var books = bookRepo.GetBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Subtitle);
                Console.WriteLine(book.Isbn);
                Console.WriteLine(book.Price);
                Console.WriteLine(book.Image);
                Console.WriteLine(book.Url);
            }
            Console.ReadKey();
        }
    }
}
