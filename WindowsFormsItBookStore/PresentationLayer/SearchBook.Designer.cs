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
            this.inptBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cijena,
            this.fotografija,
            this.url});
            this.dataGridViewBooks.Location = new System.Drawing.Point(239, 25);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(853, 434);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
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
            // cijena
            // 
            this.cijena.DataPropertyName = "Price";
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            // 
            // fotografija
            // 
            this.fotografija.DataPropertyName = "Image";
            this.fotografija.HeaderText = "Fotografija";
            this.fotografija.Name = "fotografija";
            // 
            // url
            // 
            this.url.DataPropertyName = "Url";
            this.url.HeaderText = "Url";
            this.url.Name = "url";
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 471);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografija;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
    }
}