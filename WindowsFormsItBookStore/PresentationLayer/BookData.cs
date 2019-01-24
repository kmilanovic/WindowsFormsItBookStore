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
        public BookData(Book book)
        {
            _book = book;
            InitializeComponent();
        }

        private void BookData_Load(object sender, EventArgs e)
        {
            tabControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            webBrowser.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);

            lblTitle.Text = _book.Title;
            lblSubtitle.Text = _book.Subtitle;
            lblIsbn.Text = _book.Isbn;
            lblPrice.Text = Convert.ToString("$ " + _book.Price);
            pictureBox.ImageLocation =_book.Image;
            webBrowser.Url = new Uri(_book.Url);

            if(string.IsNullOrEmpty(_book.Subtitle))
            {
                lblSubtitle.Text = "/";
            }
            if(_book.Price == "0")
            {
                lblPrice.Text = "Free";
            }

            webBrowser.ScriptErrorsSuppressed = true;

        }
    }
}
