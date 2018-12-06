using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace DataAccessLayer
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            StreamReader oSr = new StreamReader("books.json");
            string json = "";
            using (oSr)
            {
                json = oSr.ReadToEnd();
            }            JObject jsonObject = JObject.Parse(json);
            var oBooks = jsonObject["books"].ToList();
            List<Book> books = new List<Book>();
            for (int i = 0; i < books.Count; i++)
            {
                books.Add(new Book
                {
                    Title = (string)oBooks[i]["title"],
                    Subtitle = (string)oBooks[i]["subtitle"],
                    Isbn = (int)oBooks[i]["isbn13"],
                    Price = (string)oBooks[i]["price"],
                    Image = (string)oBooks[i]["image"],
                    Url = (string)oBooks[i]["url"]
                });
            }            return books;
        }
    }
}

//skini Management Studio