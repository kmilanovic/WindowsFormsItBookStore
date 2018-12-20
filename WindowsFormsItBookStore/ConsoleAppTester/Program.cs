﻿using System;
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
            //var books = bookRepo.SearchBook("html");
            Book _book = new Book();
            _book.Title = "Practical MongoDB";
            _book.Subtitle = "Architecting, Developing, and Administering MongoDB";
            _book.Isbn = "9781484206485";
            _book.Price = "$39.05";
            _book.Image = "https://itbook.store/img/books/9781484206485.png";
            _book.Url = "https://itbook.store/books/9781484206485";
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
