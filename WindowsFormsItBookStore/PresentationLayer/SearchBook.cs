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
    public partial class SearchBook : Form
    {
        public BookRepository _bookRepository = new BookRepository();
        public BindingSource _tableBindingSource = new BindingSource();

        public SearchBook()
        {
            _tableBindingSource.DataSource = _bookRepository.GetBooks();

            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            tabControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);


            //DATAGRID KNJIGE
            dataGridViewBooks.AutoGenerateColumns = false;

            dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;

            dataGridViewBooks.Columns[1].Visible = false;
            dataGridViewBooks.Columns[3].Visible = false;
            dataGridViewBooks.Columns[4].Visible = false;
            dataGridViewBooks.Columns[5].Visible = false;

            DataGridViewImageColumn oSaveButton = new DataGridViewImageColumn();
            oSaveButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Source\\Repos\\WindowsFormsItBookStore\\WindowsFormsItBookStore\\Images\\save.png");
            oSaveButton.Width = 20;
            oSaveButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBooks.Columns.Add(oSaveButton);
            dataGridViewBooks.Columns[6].HeaderText = "Spremi";

            //DATAGRID SPREMLJENE KNJIGE
            dataGridViewSavedBooks.DataSource = _tableBindingSource;

            dataGridViewSavedBooks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;

            dataGridViewSavedBooks.AutoGenerateColumns = false;

            dataGridViewSavedBooks.Columns[2].Visible = false;
            dataGridViewSavedBooks.Columns[3].Visible = false;
            dataGridViewSavedBooks.Columns[4].Visible = false;
            dataGridViewSavedBooks.Columns[5].Visible = false;
            dataGridViewSavedBooks.Columns[6].Visible = false;

            DataGridViewImageColumn oViewButton = new DataGridViewImageColumn();
            oViewButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Source\\Repos\\WindowsFormsItBookStore\\WindowsFormsItBookStore\\Images\\view.png");
            oViewButton.Width = 20;
            oViewButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSavedBooks.Columns.Add(oViewButton);
            dataGridViewSavedBooks.Columns[7].HeaderText = "Pogledaj knjigu";

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Source\\Repos\\WindowsFormsItBookStore\\WindowsFormsItBookStore\\Images\\delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSavedBooks.Columns.Add(oDeleteButton);
            dataGridViewSavedBooks.Columns[8].HeaderText = "Obriši knjigu";
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

                Boolean found = false;

                for (int i = 0; i < dataGridViewSavedBooks.RowCount - 1; i++)
                {
                    if (dataGridViewSavedBooks[1, i].Value.ToString() == title)
                    {
                        MessageBox.Show("Knjiga: " + dataGridViewSavedBooks[1, i].Value.ToString() + " je već dodana u bazu");
                        found = true;
                    }
                }

                if (found == false)
                {
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
                }
                _bookRepository._books = _bookRepository.GetBooks();
                _tableBindingSource.DataSource = _bookRepository.GetBooks();
                dataGridViewSavedBooks.DataSource = _tableBindingSource;
            }
        }

        private void dataGridViewSavedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSavedBooks.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                var bookId = Convert.ToInt32(dataGridViewSavedBooks.Rows[e.RowIndex].Cells[0].Value);

                var book = _bookRepository.GetBookById(bookId);

                BookData bookData = new BookData(book);
                bookData.Show();
            }

            if (dataGridViewSavedBooks.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewSavedBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                dataGridViewSavedBooks.DataSource = _tableBindingSource;
            }
        }
    }
}


