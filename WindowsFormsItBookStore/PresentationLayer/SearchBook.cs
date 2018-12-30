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
    public partial class SearchBook : Form
    {

        Book _book = new Book();
        public BookRepository _bookRepository = new BookRepository();
        public BindingSource _tableBindingSource = new BindingSource();

        public SearchBook()
        {
            _tableBindingSource.DataSource = _bookRepository.GetBooks();

            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            dataGridViewSavedBooks.DataSource = _tableBindingSource;

            DataGridViewImageColumn oSaveButton = new DataGridViewImageColumn();
            oSaveButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Source\\Repos\\WindowsFormsItBookStore\\WindowsFormsItBookStore\\Images\\save.png");
            oSaveButton.Width = 20;
            oSaveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBooks.Columns.Add(oSaveButton);

            dataGridViewBooks.AutoGenerateColumns = false;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string url = inptBookName.Text;
            dataGridViewBooks.DataSource = _bookRepository.SearchBook(url);
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBooks.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                var title = dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                var subtitle = dataGridViewBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                var isbn = dataGridViewBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                var price = dataGridViewBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                var convertedPrice = price.Remove(0, 1);
                var image = dataGridViewBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
                var url = dataGridViewBooks.Rows[e.RowIndex].Cells[5].Value.ToString();

                var book = new Book
                {
                    Title = title,
                    Subtitle = subtitle,
                    Isbn = isbn,
                    Price = convertedPrice,
                    Image = image,
                    Url = url
                };
                _bookRepository.AddBook(book);
                MessageBox.Show("Knjiga je dodana");
                _tableBindingSource.DataSource = _bookRepository.GetBooks();
                dataGridViewSavedBooks.DataSource = _tableBindingSource;
            }
        }
    }
}


