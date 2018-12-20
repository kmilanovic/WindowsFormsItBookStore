using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookRepo = new BookRepository();
            var books = bookRepo.SearchBook("html"); 

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
            Console.ReadKey();
        }
    }
}
