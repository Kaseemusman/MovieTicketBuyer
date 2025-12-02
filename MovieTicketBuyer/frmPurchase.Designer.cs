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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(100, 18);
            this.lblMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(39, 13);
            this.lblMovie.TabIndex = 0;
            this.lblMovie.Text = "Movie:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(100, 42);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.Click += new System.EventHandler(this.Genre_Click);
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Location = new System.Drawing.Point(100, 64);
            this.lblTheater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(47, 13);
            this.lblTheater.TabIndex = 2;
            this.lblTheater.Text = "Theater:";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(100, 85);
            this.lblShowTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(33, 13);
            this.lblShowTime.TabIndex = 3;
            this.lblShowTime.Text = "Time:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(100, 107);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(100, 128);
            this.lblSeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(32, 13);
            this.lblSeat.TabIndex = 5;
            this.lblSeat.Text = "Seat:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(30, 213);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(53, 28);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(103, 213);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMovieText
            // 
            this.lblMovieText.AutoSize = true;
            this.lblMovieText.Location = new System.Drawing.Point(14, 18);
            this.lblMovieText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieText.Name = "lblMovieText";
            this.lblMovieText.Size = new System.Drawing.Size(39, 13);
            this.lblMovieText.TabIndex = 8;
            this.lblMovieText.Text = "Movie:";
            this.lblMovieText.Click += new System.EventHandler(this.lblMovieTitle_Click);
            // 
            // lblGenreText
            // 
            this.lblGenreText.AutoSize = true;
            this.lblGenreText.Location = new System.Drawing.Point(11, 42);
            this.lblGenreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenreText.Name = "lblGenreText";
            this.lblGenreText.Size = new System.Drawing.Size(39, 13);
            this.lblGenreText.TabIndex = 9;
            this.lblGenreText.Text = "Genre:";
            // 
            // lblTheaterText
            // 
            this.lblTheaterText.AutoSize = true;
            this.lblTheaterText.Location = new System.Drawing.Point(11, 64);
            this.lblTheaterText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheaterText.Name = "lblTheaterText";
            this.lblTheaterText.Size = new System.Drawing.Size(47, 13);
            this.lblTheaterText.TabIndex = 10;
            this.lblTheaterText.Text = "Theater:";
            this.lblTheaterText.Click += new System.EventHandler(this.lblTheater_Click);
            // 
            // lblPriceText
            // 
            this.lblPriceText.AutoSize = true;
            this.lblPriceText.Location = new System.Drawing.Point(14, 107);
            this.lblPriceText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(34, 13);
            this.lblPriceText.TabIndex = 11;
            this.lblPriceText.Text = "Price:";
            // 
            // lblShowTimeText
            // 
            this.lblShowTimeText.AutoSize = true;
            this.lblShowTimeText.Location = new System.Drawing.Point(11, 85);
            this.lblShowTimeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowTimeText.Name = "lblShowTimeText";
            this.lblShowTimeText.Size = new System.Drawing.Size(33, 13);
            this.lblShowTimeText.TabIndex = 12;
            this.lblShowTimeText.Text = "Time:";
            // 
            // lblSeatText
            // 
            this.lblSeatText.AutoSize = true;
            this.lblSeatText.Location = new System.Drawing.Point(11, 128);
            this.lblSeatText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeatText.Name = "lblSeatText";
            this.lblSeatText.Size = new System.Drawing.Size(32, 13);
            this.lblSeatText.TabIndex = 13;
            this.lblSeatText.Text = "Seat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rating:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Duration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(103, 150);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(30, 13);
            this.lblRating.TabIndex = 16;
            this.lblRating.Text = "Rate";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(100, 172);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(22, 13);
            this.lblDuration.TabIndex = 17;
            this.lblDuration.Text = "dur";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 307);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDuration;
    }
}