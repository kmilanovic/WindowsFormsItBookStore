namespace PresentationLayer
{
    partial class BookStore
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
            this.dataGridViewSavedBooks = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podnaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSavedBooks
            // 
            this.dataGridViewSavedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSavedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naslov,
            this.podnaslov,
            this.isbn,
            this.cijena,
            this.fotografija,
            this.url});
            this.dataGridViewSavedBooks.Location = new System.Drawing.Point(216, 12);
            this.dataGridViewSavedBooks.Name = "dataGridViewSavedBooks";
            this.dataGridViewSavedBooks.RowTemplate.Height = 24;
            this.dataGridViewSavedBooks.Size = new System.Drawing.Size(1007, 373);
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 138);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "NATRAG";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 398);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewSavedBooks);
            this.Name = "BookStore";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.BookStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSavedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn podnaslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografija;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.Button btnBack;
    }
}