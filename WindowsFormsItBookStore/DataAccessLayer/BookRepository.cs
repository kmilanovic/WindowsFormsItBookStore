using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BookRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Book> _books = new List<Book>();

        public BookRepository()
        {
            _books = GetBooks();
        }


        public List<Book> SearchBook(string url)    
        {           
            List<Book> books = new List<Book>();
                                 
            string json = CallRestMethod(CreateUrl(url));

            JObject jsonObject = JObject.Parse(json);
            var oBooks = jsonObject["books"].ToList();
            for (int i = 0; i < oBooks.Count; i++)
            {
                books.Add(new Book
                {
                    Title = (string)oBooks[i]["title"],
                    Subtitle = (string)oBooks[i]["subtitle"],
                    Isbn = (string)oBooks[i]["isbn13"],
                    Price = (string)oBooks[i]["price"],
                    Image = (string)oBooks[i]["image"],
                    Url = (string)oBooks[i]["url"]
                });
            }
            return books;
        }

        public List<Book> GetBooks()
        {
            int nRbr = 0;
            var books = new List<Book>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Book";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nRbr++ ;
                        books.Add(new Book()
                        {
                            nRbr = nRbr,
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            Subtitle = (string)reader["Subtitle"],
                            Isbn = (string)reader["Isbn"],
                            Price = Convert.ToString(reader["Price"]),
                            Image = (string)reader["Image"],
                            Url = (string)reader["Url"]
                        });
                    }
                }
            }
            return books;
        }


        public Book GetBookById(int bookId)
        {
            var customers = GetBooks();
            var book = _books.Where(b => b.Id == bookId).Select(b => new Book
            {
                Id = b.Id,
                Title = b.Title,
                Subtitle = b.Subtitle,
                Isbn = b.Isbn,
                Price = b.Price,
                Image = b.Image,
                Url = b.Url
            }).FirstOrDefault();
            return book;
        }

        public void AddBook(Book book)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString)) using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Book (Title, Subtitle, Isbn, Price, Image, Url) VALUES('" + book.Title + "', '" + book.Subtitle + "', '" + book.Isbn + "', '" + book.Price + "', '" + book.Image + "', '" + book.Url + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteBook(Book book)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString)) using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Book WHERE Id = '" + book.Id + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public static string CreateUrl(string title)
        {
           return "https://api.itbook.store/1.0/search/" + title;
        }

        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
    }
}


//Napraviti da se klikom na pojedinu knjigu otovori forma s podacima o knjizi(Slika, naslov, podnaslov, cijena)