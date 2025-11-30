namespace MovieTicketBuyer
{
    partial class frmWatchlist
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
            this.lblWatchlist = new System.Windows.Forms.Label();
            this.dgvWatchlist = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWatchlist
            // 
            this.lblWatchlist.AutoSize = true;
            this.lblWatchlist.Location = new System.Drawing.Point(12, 33);
            this.lblWatchlist.Name = "lblWatchlist";
            this.lblWatchlist.Size = new System.Drawing.Size(92, 16);
            this.lblWatchlist.TabIndex = 0;
            this.lblWatchlist.Text = "Your Watchlist";
            // 
            // dgvWatchlist
            // 
            this.dgvWatchlist.AllowUserToAddRows = false;
            this.dgvWatchlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWatchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWatchlist.Location = new System.Drawing.Point(119, 33);
            this.dgvWatchlist.Name = "dgvWatchlist";
            this.dgvWatchlist.ReadOnly = true;
            this.dgvWatchlist.RowHeadersWidth = 51;
            this.dgvWatchlist.RowTemplate.Height = 24;
            this.dgvWatchlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWatchlist.Size = new System.Drawing.Size(550, 150);
            this.dgvWatchlist.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(128, 208);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 27);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(248, 208);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(89, 27);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy Ticket";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(363, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 27);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(515, 219);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 16);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Count ";
            // 
            // frmWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvWatchlist);
            this.Controls.Add(this.lblWatchlist);
            this.Name = "frmWatchlist";
            this.Text = "frmWatchlist";
            this.Load += new System.EventHandler(this.frmWatchlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWatchlist;
        private System.Windows.Forms.DataGridView dgvWatchlist;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
    }
}