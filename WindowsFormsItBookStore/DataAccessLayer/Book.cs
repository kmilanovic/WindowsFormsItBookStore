using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Isbn { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
    }
}
