namespace RentalVideo
{
    partial class MainForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturnVideo = new System.Windows.Forms.Button();
            this.btnRentalVideo = new System.Windows.Forms.Button();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRentedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVideo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.gridRentedMovie = new System.Windows.Forms.DataGridView();
            this.RMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVideoRefresh = new System.Windows.Forms.Button();
            this.btn_CustomerRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(239, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(675, 76);
            this.label10.TabIndex = 59;
            this.label10.Text = "Video Rental System";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(46, 648);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 47);
            this.button3.TabIndex = 58;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(46, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 51);
            this.button2.TabIndex = 57;
            this.button2.Text = "Popular Video\'s";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(46, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 49);
            this.button1.TabIndex = 56;
            this.button1.Text = "Most Rental Customer List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReturnVideo
            // 
            this.btnReturnVideo.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.btnReturnVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnVideo.ForeColor = System.Drawing.Color.White;
            this.btnReturnVideo.Location = new System.Drawing.Point(46, 437);
            this.btnReturnVideo.Name = "btnReturnVideo";
            this.btnReturnVideo.Size = new System.Drawing.Size(184, 47);
            this.btnReturnVideo.TabIndex = 55;
            this.btnReturnVideo.Text = "Return Video";
            this.btnReturnVideo.UseVisualStyleBackColor = true;
            this.btnReturnVideo.Click += new System.EventHandler(this.btnReturnVideo_Click);
            // 
            // btnRentalVideo
            // 
            this.btnRentalVideo.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.btnRentalVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalVideo.ForeColor = System.Drawing.Color.White;
            this.btnRentalVideo.Location = new System.Drawing.Point(46, 368);
            this.btnRentalVideo.Name = "btnRentalVideo";
            this.btnRentalVideo.Size = new System.Drawing.Size(184, 48);
            this.btnRentalVideo.TabIndex = 54;
            this.btnRentalVideo.Text = "Rented Video List ";
            this.btnRentalVideo.UseVisualStyleBackColor = true;
            this.btnRentalVideo.Click += new System.EventHandler(this.btnRentalVideo_Click);
            // 
            // buttonVideo
            // 
            this.buttonVideo.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.buttonVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVideo.Location = new System.Drawing.Point(46, 303);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(184, 47);
            this.buttonVideo.TabIndex = 53;
            this.buttonVideo.Text = "Add New Video";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(46, 231);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(184, 50);
            this.btnCustomer.TabIndex = 52;
            this.btnCustomer.Text = "Add New Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::RentalVideo.Properties.Resources.button_back;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(835, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 46);
            this.button4.TabIndex = 66;
            this.button4.Text = "Rental";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(357, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Rental Date";
            // 
            // dtpRentedDate
            // 
            this.dtpRentedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpRentedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentedDate.Location = new System.Drawing.Point(505, 182);
            this.dtpRentedDate.Name = "dtpRentedDate";
            this.dtpRentedDate.Size = new System.Drawing.Size(187, 20);
            this.dtpRentedDate.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(831, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Select Video";
            // 
            // cmbVideo
            // 
            this.cmbVideo.FormattingEnabled = true;
            this.cmbVideo.Items.AddRange(new object[] {
            "-- Select Video --"});
            this.cmbVideo.Location = new System.Drawing.Point(948, 127);
            this.cmbVideo.Name = "cmbVideo";
            this.cmbVideo.Size = new System.Drawing.Size(190, 21);
            this.cmbVideo.TabIndex = 62;
            this.cmbVideo.SelectedIndexChanged += new System.EventHandler(this.cmbVideo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Select Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(505, 130);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(187, 21);
            this.cmbCustomer.TabIndex = 60;
            // 
            // gridRentedMovie
            // 
            this.gridRentedMovie.AllowUserToAddRows = false;
            this.gridRentedMovie.AllowUserToDeleteRows = false;
            this.gridRentedMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRentedMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMID,
            this.CustId,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone,
            this.MovieId,
            this.Title,
            this.ReleaseDate,
            this.RentalCost,
            this.Genre,
            this.Plot,
            this.DateRented,
            this.DateReturned});
            this.gridRentedMovie.Location = new System.Drawing.Point(252, 231);
            this.gridRentedMovie.Name = "gridRentedMovie";
            this.gridRentedMovie.ReadOnly = true;
            this.gridRentedMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRentedMovie.Size = new System.Drawing.Size(975, 464);
            this.gridRentedMovie.TabIndex = 67;
            // 
            // RMID
            // 
            this.RMID.DataPropertyName = "RentedMovieId";
            this.RMID.HeaderText = "RMID";
            this.RMID.Name = "RMID";
            this.RMID.ReadOnly = true;
            this.RMID.Width = 50;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "CustId";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Movie Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Visible = false;
            // 
            // RentalCost
            // 
            this.RentalCost.DataPropertyName = "RentalCost";
            this.RentalCost.HeaderText = "Rental Cost";
            this.RentalCost.Name = "RentalCost";
            this.RentalCost.ReadOnly = true;
            this.RentalCost.Width = 50;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Visible = false;
            // 
            // Plot
            // 
            this.Plot.DataPropertyName = "Plot";
            this.Plot.HeaderText = "Plot";
            this.Plot.Name = "Plot";
            this.Plot.ReadOnly = true;
            this.Plot.Visible = false;
            // 
            // DateRented
            // 
            this.DateRented.DataPropertyName = "DateRented";
            this.DateRented.HeaderText = "Date Rented";
            this.DateRented.Name = "DateRented";
            this.DateRented.ReadOnly = true;
            this.DateRented.Width = 150;
            // 
            // DateReturned
            // 
            this.DateReturned.DataPropertyName = "DateReturned";
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 150;
            // 
            // btnVideoRefresh
            // 
            this.btnVideoRefresh.BackgroundImage = global::RentalVideo.Properties.Resources.update;
            this.btnVideoRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVideoRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoRefresh.ForeColor = System.Drawing.Color.White;
            this.btnVideoRefresh.Location = new System.Drawing.Point(1144, 122);
            this.btnVideoRefresh.Name = "btnVideoRefresh";
            this.btnVideoRefresh.Size = new System.Drawing.Size(51, 29);
            this.btnVideoRefresh.TabIndex = 68;
            this.btnVideoRefresh.UseVisualStyleBackColor = true;
            this.btnVideoRefresh.Click += new System.EventHandler(this.btnVideoRefresh_Click);
            // 
            // btn_CustomerRefresh
            // 
            this.btn_CustomerRefresh.BackgroundImage = global::RentalVideo.Properties.Resources.update;
            this.btn_CustomerRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CustomerRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerRefresh.ForeColor = System.Drawing.Color.White;
            this.btn_CustomerRefresh.Location = new System.Drawing.Point(698, 127);
            this.btn_CustomerRefresh.Name = "btn_CustomerRefresh";
            this.btn_CustomerRefresh.Size = new System.Drawing.Size(51, 29);
            this.btn_CustomerRefresh.TabIndex = 69;
            this.btn_CustomerRefresh.UseVisualStyleBackColor = true;
            this.btn_CustomerRefresh.Click += new System.EventHandler(this.btn_CustomerRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentalVideo.Properties.Resources.blue_gradient_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.btn_CustomerRefresh);
            this.Controls.Add(this.btnVideoRefresh);
            this.Controls.Add(this.gridRentedMovie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpRentedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturnVideo);
            this.Controls.Add(this.btnRentalVideo);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.btnCustomer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoRentalSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRentedMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReturnVideo;
        private System.Windows.Forms.Button btnRentalVideo;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRentedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVideo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.DataGridView gridRentedMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
        private System.Windows.Forms.Button btnVideoRefresh;
        private System.Windows.Forms.Button btn_CustomerRefresh;
    }
}

