﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;

namespace DataAccessLayer
{
    public class BookRepository
    {
        public List<Book> SearchBook(string url)
        {
            List<Book> books = new List<Book>();

            CreateUrl(url);           
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