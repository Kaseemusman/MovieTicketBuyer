namespace MovieTicketBuyer
{
    partial class frmPurchase
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
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTheater = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMovieText = new System.Windows.Forms.Label();
            this.lblGenreText = new System.Windows.Forms.Label();
            this.lblTheaterText = new System.Windows.Forms.Label();
            this.lblPriceText = new System.Windows.Forms.Label();
            this.lblShowTimeText = new System.Windows.Forms.Label();
            this.lblSeatText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(134, 22);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(47, 16);
            this.lblMovie.TabIndex = 0;
            this.lblMovie.Text = "Movie:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(134, 52);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 16);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.Click += new System.EventHandler(this.Genre_Click);
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Location = new System.Drawing.Point(134, 79);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(57, 16);
            this.lblTheater.TabIndex = 2;
            this.lblTheater.Text = "Theater:";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(134, 105);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(41, 16);
            this.lblShowTime.TabIndex = 3;
            this.lblShowTime.Text = "Time:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(134, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(134, 158);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(38, 16);
            this.lblSeat.TabIndex = 5;
            this.lblSeat.Text = "Seat:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 194);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(71, 34);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMovieText
            // 
            this.lblMovieText.AutoSize = true;
            this.lblMovieText.Location = new System.Drawing.Point(18, 22);
            this.lblMovieText.Name = "lblMovieText";
            this.lblMovieText.Size = new System.Drawing.Size(47, 16);
            this.lblMovieText.TabIndex = 8;
            this.lblMovieText.Text = "Movie:";
            this.lblMovieText.Click += new System.EventHandler(this.lblMovieTitle_Click);
            // 
            // lblGenreText
            // 
            this.lblGenreText.AutoSize = true;
            this.lblGenreText.Location = new System.Drawing.Point(15, 52);
            this.lblGenreText.Name = "lblGenreText";
            this.lblGenreText.Size = new System.Drawing.Size(47, 16);
            this.lblGenreText.TabIndex = 9;
            this.lblGenreText.Text = "Genre:";
            // 
            // lblTheaterText
            // 
            this.lblTheaterText.AutoSize = true;
            this.lblTheaterText.Location = new System.Drawing.Point(15, 79);
            this.lblTheaterText.Name = "lblTheaterText";
            this.lblTheaterText.Size = new System.Drawing.Size(57, 16);
            this.lblTheaterText.TabIndex = 10;
            this.lblTheaterText.Text = "Theater:";
            this.lblTheaterText.Click += new System.EventHandler(this.lblTheater_Click);
            // 
            // lblPriceText
            // 
            this.lblPriceText.AutoSize = true;
            this.lblPriceText.Location = new System.Drawing.Point(18, 132);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(41, 16);
            this.lblPriceText.TabIndex = 11;
            this.lblPriceText.Text = "Price:";
            // 
            // lblShowTimeText
            // 
            this.lblShowTimeText.AutoSize = true;
            this.lblShowTimeText.Location = new System.Drawing.Point(15, 105);
            this.lblShowTimeText.Name = "lblShowTimeText";
            this.lblShowTimeText.Size = new System.Drawing.Size(41, 16);
            this.lblShowTimeText.TabIndex = 12;
            this.lblShowTimeText.Text = "Time:";
            // 
            // lblSeatText
            // 
            this.lblSeatText.AutoSize = true;
            this.lblSeatText.Location = new System.Drawing.Point(15, 158);
            this.lblSeatText.Name = "lblSeatText";
            this.lblSeatText.Size = new System.Drawing.Size(38, 16);
            this.lblSeatText.TabIndex = 13;
            this.lblSeatText.Text = "Seat:";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeatText);
            this.Controls.Add(this.lblShowTimeText);
            this.Controls.Add(this.lblPriceText);
            this.Controls.Add(this.lblTheaterText);
            this.Controls.Add(this.lblGenreText);
            this.Controls.Add(this.lblMovieText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblTheater);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblMovie);
            this.Name = "frmPurchase";
            this.Text = "frmPurchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTheater;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMovieText;
        private System.Windows.Forms.Label lblGenreText;
        private System.Windows.Forms.Label lblTheaterText;
        private System.Windows.Forms.Label lblPriceText;
        private System.Windows.Forms.Label lblShowTimeText;
        private System.Windows.Forms.Label lblSeatText;
    }
}