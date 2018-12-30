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

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Source\\Repos\\WindowsFormsItBookStore\\WindowsFormsItBookStore\\Images\\delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSavedBooks.Columns.Add(oDeleteButton);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridViewSavedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSavedBooks.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewSavedBooks.Rows[e.RowIndex].Cells[0].Value);
                var title = dataGridViewSavedBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                var subtitle = dataGridViewSavedBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                var isbn = dataGridViewSavedBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                var price = dataGridViewSavedBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
                var image = dataGridViewSavedBooks.Rows[e.RowIndex].Cells[5].Value.ToString();
                var url = dataGridViewSavedBooks.Rows[e.RowIndex].Cells[6].Value.ToString();

                var book = new Book
                {
                    Id = id,
                    Title = title,
                    Subtitle = subtitle,
                    Isbn = isbn,
                    Price = price,
                    Image = image,
                    Url = url
                };
                _bookRepository.DeleteBook(book);
                _tableBindingSource.DataSource = _bookRepository.GetBooks();
            }
        }
    }
}
