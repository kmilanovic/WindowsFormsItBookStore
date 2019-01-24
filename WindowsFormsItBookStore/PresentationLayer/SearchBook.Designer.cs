namespace PresentationLayer
{
    partial class SearchBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inptBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSavedBooks = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podnaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isbn_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // inptBookName
            // 
            this.inptBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inptBookName.Location = new System.Drawing.Point(244, 23);
            this.inptBookName.Name = "inptBookName";
            this.inptBookName.Size = new System.Drawing.Size(495, 30);
            this.inptBookName.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(30, 26);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(185, 25);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Unesite naziv knjige";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchBook.Location = new System.Drawing.Point(881, 23);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(146, 30);
            this.btnSearchBook.TabIndex = 3;
            this.btnSearchBook.Text = "TRAŽI";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.subtitle,
            this.isbn,
            this.price,
            this.image,
            this.url});
            this.dataGridViewBooks.Location = new System.Drawing.Point(35, 75);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(992, 337);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Naslov";
            this.title.Name = "title";
            // 
            // subtitle
            // 
            this.subtitle.DataPropertyName = "Subtitle";
            this.subtitle.HeaderText = "Podnaslov";
            this.subtitle.Name = "subtitle";
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "Isbn";
            this.isbn.HeaderText = "Isbn";
            this.isbn.Name = "isbn";
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Cijena";
            this.price.Name = "price";
            // 
            // image
            // 
            this.image.DataPropertyName = "Image";
            this.image.HeaderText = "Fotografija";
            this.image.Name = "image";
            // 
            // url
            // 
            this.url.DataPropertyName = "Url";
            this.url.HeaderText = "Url";
            this.url.Name = "url";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 466);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.dataGridViewBooks);
            this.tabPage1.Controls.Add(this.btnSearchBook);
            this.tabPage1.Controls.Add(this.lblBookName);
            this.tabPage1.Controls.Add(this.inptBookName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pretraga";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.dataGridViewSavedBooks);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Knjižnica";
            // 
            // dataGridViewSavedBooks
            // 
            this.dataGridViewSavedBooks.AllowUserToAddRows = false;
            this.dataGridViewSavedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSavedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSavedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSavedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naslov,
            this.podnaslov,
            this.Isbn_kod,
            this.Cijena,
            this.fotografija,
            this.url_link});
            this.dataGridViewSavedBooks.Location = new System.Drawing.Point(27, 24);
            this.dataGridViewSavedBooks.Name = "dataGridViewSavedBooks";
            this.dataGridViewSavedBooks.RowTemplate.Height = 24;
            this.dataGridViewSavedBooks.Size = new System.Drawing.Size(992, 337);
            this.dataGridViewSavedBooks.TabIndex = 0;
            this.dataGridViewSavedBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSavedBooks_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // naslov
            // 
            this.naslov.DataPropertyName = "Title";
            this.naslov.HeaderText = "Naslov";
            this.naslov.Name = "naslov";
            // 
            // podnaslov
            // 
            this.podnaslov.DataPropertyName = "Subtitle";
            this.podnaslov.HeaderText = "Podnaslov";
            this.podnaslov.Name = "podnaslov";
            // 
            // Isbn_kod
            // 
            this.Isbn_kod.DataPropertyName = "Isbn";
            this.Isbn_kod.HeaderText = "Isbn";
            this.Isbn_kod.Name = "Isbn_kod";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Price";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // fotografija
            // 
            this.fotografija.DataPropertyName = "Image";
            this.fotografija.HeaderText = "Fotografija";
            this.fotografija.Name = "fotografija";
            // 
            // url_link
            // 
            this.url_link.DataPropertyName = "Url";
            this.url_link.HeaderText = "Url";
            this.url_link.Name = "url_link";
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBook";
            this.Load += new System.EventHandler(this.SearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox inptBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSavedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn podnaslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografija;
        private System.Windows.Forms.DataGridViewTextBoxColumn url_link;
    }
}