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

namespace PresentationLayer
{
    public partial class BookStore : Form
    {
        public BookRepository _bookRepository = new BookRepository();
        public BindingSource _tableBindingSource = new BindingSource();

        public BookStore()
        {
            _tableBindingSource.DataSource = _bookRepository.GetBooks();

            InitializeComponent();
        }

        private void BookStore_Load(object sender, EventArgs e)
        {
            dataGridViewSavedBooks.DataSource = _tableBindingSource;
        }
    }
}
