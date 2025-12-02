namespace MovieTicketBuyer
{
    partial class FormMain
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
            this.dgvMovieList = new System.Windows.Forms.DataGridView();
            this.cboTheater = new System.Windows.Forms.ComboBox();
            this.lblTheater = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAddWatchlist = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnOpenWatchlist = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovieList
            // 
            this.dgvMovieList.AllowUserToAddRows = false;
            this.dgvMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieList.Location = new System.Drawing.Point(362, 10);
            this.dgvMovieList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMovieList.Name = "dgvMovieList";
            this.dgvMovieList.ReadOnly = true;
            this.dgvMovieList.RowHeadersWidth = 51;
            this.dgvMovieList.RowTemplate.Height = 24;
            this.dgvMovieList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieList.Size = new System.Drawing.Size(460, 122);
            this.dgvMovieList.TabIndex = 0;
            this.dgvMovieList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieList_CellDoubleClick);

            // 
            // cboTheater
            // 
            this.cboTheater.FormattingEnabled = true;
            this.cboTheater.Items.AddRange(new object[] {
            "All",
            "AMC",
            "Regal",
            "Cinemark"});
            this.cboTheater.Location = new System.Drawing.Point(113, 16);
            this.cboTheater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTheater.Name = "cboTheater";
            this.cboTheater.Size = new System.Drawing.Size(92, 21);
            this.cboTheater.TabIndex = 1;
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Location = new System.Drawing.Point(18, 19);
            this.lblTheater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(83, 13);
            this.lblTheater.TabIndex = 2;
            this.lblTheater.Text = "Filter by Theater";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(18, 47);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(75, 13);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Filter by Genre";
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "All",
            "Sci-Fi",
            "Drama",
            "Animation",
            "Adventure",
            "Thriller",
            "Horror"});
            this.cboGenre.Location = new System.Drawing.Point(113, 47);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(92, 21);
            this.cboGenre.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 78);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Filter by Price";
            // 
            // cboPrice
            // 
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Items.AddRange(new object[] {
            "All",
            "",
            "",
            "Under $10",
            "",
            "",
            "$10-$15",
            "",
            "",
            "Over $15"});
            this.cboPrice.Location = new System.Drawing.Point(113, 76);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(92, 21);
            this.cboPrice.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(18, 106);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Filter by Time";
            // 
            // cboTime
            // 
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "All",
            "",
            "",
            "Morning",
            "",
            "",
            "Afternoon",
            "",
            "",
            "Evening",
            "",
            "",
            "Night"});
            this.cboTime.Location = new System.Drawing.Point(113, 103);
            this.cboTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(92, 21);
            this.cboTime.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(20, 137);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 26);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(18, 228);
            this.lblSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(78, 13);
            this.lblSort.TabIndex = 10;
            this.lblSort.Text = "Sort Movies By";
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Location = new System.Drawing.Point(113, 226);
            this.cboSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(92, 21);
            this.cboSort.TabIndex = 11;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(18, 258);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(78, 26);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Apply Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAddWatchlist
            // 
            this.btnAddWatchlist.Location = new System.Drawing.Point(620, 154);
            this.btnAddWatchlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddWatchlist.Name = "btnAddWatchlist";
            this.btnAddWatchlist.Size = new System.Drawing.Size(98, 26);
            this.btnAddWatchlist.TabIndex = 13;
            this.btnAddWatchlist.Text = "Add to Watchlist";
            this.btnAddWatchlist.UseVisualStyleBackColor = true;
            this.btnAddWatchlist.Click += new System.EventHandler(this.btnAddWatchlist_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(362, 154);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(94, 26);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "Buy Ticket";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnOpenWatchlist
            // 
            this.btnOpenWatchlist.Location = new System.Drawing.Point(494, 154);
            this.btnOpenWatchlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenWatchlist.Name = "btnOpenWatchlist";
            this.btnOpenWatchlist.Size = new System.Drawing.Size(98, 26);
            this.btnOpenWatchlist.TabIndex = 15;
            this.btnOpenWatchlist.Text = "Open Watchlist";
            this.btnOpenWatchlist.UseVisualStyleBackColor = true;
            this.btnOpenWatchlist.Click += new System.EventHandler(this.btnOpenWatchlist_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 315);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(73, 13);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search Movie";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(113, 310);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(92, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 347);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 26);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search Movie";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 555);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnOpenWatchlist);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnAddWatchlist);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cboPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTheater);
            this.Controls.Add(this.cboTheater);
            this.Controls.Add(this.dgvMovieList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovieList;
        private System.Windows.Forms.ComboBox cboTheater;
        private System.Windows.Forms.Label lblTheater;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnAddWatchlist;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnOpenWatchlist;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

