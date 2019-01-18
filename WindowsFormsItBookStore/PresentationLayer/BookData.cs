using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.Net;

namespace PresentationLayer
{
    public partial class BookData : Form
    {
        Book _book = new Book();
        SearchBook _searchBook = new SearchBook();
        private BookRepository _bookRepository = new BookRepository();

        public BookData(Book book, SearchBook searchBook) //int BookID
        {
            _book = book;
            _searchBook = searchBook;
            InitializeComponent();
        }

        private void BookData_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _book.Title;
            lblSubtitle.Text = _book.Subtitle;
            lblIsbn.Text = _book.Isbn;
            lblPrice.Text = Convert.ToString(_book.Price);
            pictureBox.ImageLocation =_book.Image;
            webBrowser.Url = new Uri(_book.Url);


            webBrowser.ScriptErrorsSuppressed = true;

        }
    }
}
