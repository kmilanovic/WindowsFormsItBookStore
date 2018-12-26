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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inptBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnBookStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.subtitle,
            this.isbn,
            this.price,
            this.image,
            this.url});
            this.dataGridViewBooks.Location = new System.Drawing.Point(239, 25);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(995, 434);
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
            // inptBookName
            // 
            this.inptBookName.Location = new System.Drawing.Point(34, 65);
            this.inptBookName.Name = "inptBookName";
            this.inptBookName.Size = new System.Drawing.Size(160, 22);
            this.inptBookName.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(31, 34);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(134, 17);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Unesite naziv knjige";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(34, 109);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(160, 45);
            this.btnSearchBook.TabIndex = 3;
            this.btnSearchBook.Text = "TRAŽI";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnBookStore
            // 
            this.btnBookStore.Location = new System.Drawing.Point(34, 200);
            this.btnBookStore.Name = "btnBookStore";
            this.btnBookStore.Size = new System.Drawing.Size(160, 114);
            this.btnBookStore.TabIndex = 4;
            this.btnBookStore.Text = "KNJIŽNICA";
            this.btnBookStore.UseVisualStyleBackColor = true;
            this.btnBookStore.Click += new System.EventHandler(this.btnBookStore_Click);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 471);
            this.Controls.Add(this.btnBookStore);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.inptBookName);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "SearchBook";
            this.Text = "SearchBook";
            this.Load += new System.EventHandler(this.SearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TextBox inptBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.Button btnBookStore;
    }
}