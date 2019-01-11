namespace PresentationLayer
{
    partial class BookData
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPodnaslov = new System.Windows.Forms.Label();
            this.lblIsbn2 = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(545, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(545, 172);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(115, 36);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Subtitle";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(545, 263);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(72, 36);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "Isbn";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(545, 364);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 36);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(548, 58);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(51, 17);
            this.lblNaslov.TabIndex = 4;
            this.lblNaslov.Text = "Naslov";
            // 
            // lblPodnaslov
            // 
            this.lblPodnaslov.AutoSize = true;
            this.lblPodnaslov.Location = new System.Drawing.Point(548, 155);
            this.lblPodnaslov.Name = "lblPodnaslov";
            this.lblPodnaslov.Size = new System.Drawing.Size(74, 17);
            this.lblPodnaslov.TabIndex = 5;
            this.lblPodnaslov.Text = "Podnaslov";
            // 
            // lblIsbn2
            // 
            this.lblIsbn2.AutoSize = true;
            this.lblIsbn2.Location = new System.Drawing.Point(548, 246);
            this.lblIsbn2.Name = "lblIsbn2";
            this.lblIsbn2.Size = new System.Drawing.Size(34, 17);
            this.lblIsbn2.TabIndex = 6;
            this.lblIsbn2.Text = "Isbn";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(551, 344);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(47, 17);
            this.lblCijena.TabIndex = 7;
            this.lblCijena.Text = "Cijena";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(380, 376);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(22, 493);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1403, 250);
            this.webBrowser.TabIndex = 9;
            // 
            // BookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 813);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblIsbn2);
            this.Controls.Add(this.lblPodnaslov);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "BookData";
            this.Text = "BookData";
            this.Load += new System.EventHandler(this.BookData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPodnaslov;
        private System.Windows.Forms.Label lblIsbn2;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}