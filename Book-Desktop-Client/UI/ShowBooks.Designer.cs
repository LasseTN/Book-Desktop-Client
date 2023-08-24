namespace Book_Desktop_Client.UI {
    partial class ShowBooks {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            buttonCloseWindow = new Button();
            listViewShowBooks = new ListView();
            Titel = new ColumnHeader();
            Forfatter = new ColumnHeader();
            Genre = new ColumnHeader();
            SideAntal = new ColumnHeader();
            BogType = new ColumnHeader();
            IsbnNr = new ColumnHeader();
            Lokation = new ColumnHeader();
            Status = new ColumnHeader();
            bogId = new ColumnHeader();
            BookList = new Label();
            textBoxTitle = new TextBox();
            comboBoxType = new ComboBox();
            comboBoxGenre = new ComboBox();
            comboBoxLocation = new ComboBox();
            comboBoxStatus = new ComboBox();
            textBoxAuthor = new TextBox();
            textBoxNoOfPages = new TextBox();
            textBoxIsbnNo = new TextBox();
            textBoxId = new TextBox();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblNoOfPages = new Label();
            LblAddBook = new Label();
            lblType = new Label();
            LblIsbn = new Label();
            lblLokation = new Label();
            lblStatus = new Label();
            lblBookId = new Label();
            buttonCreateBook = new Button();
            buttonGetAllBooks = new Button();
            buttonUpdateBook = new Button();
            buttonDeleteBook = new Button();
            chooseFiles = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelProcessText = new Label();
            SuspendLayout();
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Salmon;
            buttonCloseWindow.Location = new Point(1390, 670);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(121, 26);
            buttonCloseWindow.TabIndex = 22;
            buttonCloseWindow.Text = "Luk vinduet";
            buttonCloseWindow.UseVisualStyleBackColor = false;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // listViewShowBooks
            // 
            listViewShowBooks.BackColor = SystemColors.ScrollBar;
            listViewShowBooks.Columns.AddRange(new ColumnHeader[] { Titel, Forfatter, Genre, SideAntal, BogType, IsbnNr, Lokation, Status, bogId });
            listViewShowBooks.Cursor = Cursors.Hand;
            listViewShowBooks.Location = new Point(60, 93);
            listViewShowBooks.Name = "listViewShowBooks";
            listViewShowBooks.Size = new Size(994, 487);
            listViewShowBooks.TabIndex = 23;
            listViewShowBooks.UseCompatibleStateImageBehavior = false;
            listViewShowBooks.View = View.Details;
            listViewShowBooks.SelectedIndexChanged += listViewShowBooks_SelectedIndexChanged;
            // 
            // Titel
            // 
            Titel.Text = "Titel";
            Titel.Width = 200;
            // 
            // Forfatter
            // 
            Forfatter.Text = "Forfatter";
            Forfatter.Width = 200;
            // 
            // Genre
            // 
            Genre.Text = "Genre";
            Genre.Width = 85;
            // 
            // SideAntal
            // 
            SideAntal.Text = "Antal sider";
            SideAntal.Width = 70;
            // 
            // BogType
            // 
            BogType.Text = "Type";
            BogType.Width = 80;
            // 
            // IsbnNr
            // 
            IsbnNr.Text = "Isbn";
            IsbnNr.Width = 120;
            // 
            // Lokation
            // 
            Lokation.Text = "Lokation";
            Lokation.Width = 70;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 97;
            // 
            // bogId
            // 
            bogId.Text = "Bog id";
            bogId.Width = 50;
            // 
            // BookList
            // 
            BookList.AutoSize = true;
            BookList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BookList.Location = new Point(60, 30);
            BookList.Name = "BookList";
            BookList.Size = new Size(108, 17);
            BookList.TabIndex = 24;
            BookList.Text = "Liste over bøger";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(1111, 93);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(262, 23);
            textBoxTitle.TabIndex = 25;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(1111, 321);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(179, 23);
            comboBoxType.TabIndex = 26;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(1111, 206);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(179, 23);
            comboBoxGenre.TabIndex = 27;
            comboBoxGenre.SelectedIndexChanged += comboBoxGenre_SelectedIndexChanged;
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Location = new Point(1111, 439);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(179, 23);
            comboBoxLocation.TabIndex = 28;
            comboBoxLocation.SelectedIndexChanged += comboBoxLocation_SelectedIndexChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(1111, 497);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(179, 23);
            comboBoxStatus.TabIndex = 29;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(1111, 149);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(262, 23);
            textBoxAuthor.TabIndex = 30;
            // 
            // textBoxNoOfPages
            // 
            textBoxNoOfPages.Location = new Point(1111, 262);
            textBoxNoOfPages.Name = "textBoxNoOfPages";
            textBoxNoOfPages.Size = new Size(179, 23);
            textBoxNoOfPages.TabIndex = 31;
            // 
            // textBoxIsbnNo
            // 
            textBoxIsbnNo.Location = new Point(1111, 378);
            textBoxIsbnNo.Name = "textBoxIsbnNo";
            textBoxIsbnNo.Size = new Size(179, 23);
            textBoxIsbnNo.TabIndex = 32;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(1111, 557);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(179, 23);
            textBoxId.TabIndex = 33;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(1111, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(36, 17);
            lblTitle.TabIndex = 34;
            lblTitle.Text = "Titel";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.Location = new Point(1111, 129);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(62, 17);
            lblAuthor.TabIndex = 35;
            lblAuthor.Text = "Forfatter";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenre.Location = new Point(1111, 186);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(44, 17);
            lblGenre.TabIndex = 36;
            lblGenre.Text = "Genre";
            // 
            // lblNoOfPages
            // 
            lblNoOfPages.AutoSize = true;
            lblNoOfPages.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoOfPages.Location = new Point(1111, 242);
            lblNoOfPages.Name = "lblNoOfPages";
            lblNoOfPages.Size = new Size(75, 17);
            lblNoOfPages.TabIndex = 37;
            lblNoOfPages.Text = "Antal sider";
            // 
            // LblAddBook
            // 
            LblAddBook.AutoSize = true;
            LblAddBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblAddBook.Location = new Point(1111, 30);
            LblAddBook.Name = "LblAddBook";
            LblAddBook.Size = new Size(69, 17);
            LblAddBook.TabIndex = 38;
            LblAddBook.Text = "Tilføj bog";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(1111, 301);
            lblType.Name = "lblType";
            lblType.Size = new Size(37, 17);
            lblType.TabIndex = 39;
            lblType.Text = "Type";
            // 
            // LblIsbn
            // 
            LblIsbn.AutoSize = true;
            LblIsbn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblIsbn.Location = new Point(1111, 358);
            LblIsbn.Name = "LblIsbn";
            LblIsbn.Size = new Size(51, 17);
            LblIsbn.TabIndex = 40;
            LblIsbn.Text = "Isbn nr";
            // 
            // lblLokation
            // 
            lblLokation.AutoSize = true;
            lblLokation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLokation.Location = new Point(1111, 419);
            lblLokation.Name = "lblLokation";
            lblLokation.Size = new Size(62, 17);
            lblLokation.TabIndex = 41;
            lblLokation.Text = "Lokation";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(1111, 477);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 17);
            lblStatus.TabIndex = 42;
            lblStatus.Text = "Status";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookId.Location = new Point(1111, 537);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(20, 17);
            lblBookId.TabIndex = 43;
            lblBookId.Text = "Id";
            // 
            // buttonCreateBook
            // 
            buttonCreateBook.Location = new Point(1111, 604);
            buttonCreateBook.Name = "buttonCreateBook";
            buttonCreateBook.Size = new Size(121, 34);
            buttonCreateBook.TabIndex = 44;
            buttonCreateBook.Text = "Tilføj bog";
            buttonCreateBook.UseVisualStyleBackColor = true;
            buttonCreateBook.Click += buttonCreateBook_Click;
            // 
            // buttonGetAllBooks
            // 
            buttonGetAllBooks.Location = new Point(60, 610);
            buttonGetAllBooks.Name = "buttonGetAllBooks";
            buttonGetAllBooks.Size = new Size(121, 34);
            buttonGetAllBooks.TabIndex = 45;
            buttonGetAllBooks.Text = "Vis bøger";
            buttonGetAllBooks.UseVisualStyleBackColor = true;
            buttonGetAllBooks.Click += buttonGetAllBooks_Click;
            // 
            // buttonUpdateBook
            // 
            buttonUpdateBook.Location = new Point(1252, 604);
            buttonUpdateBook.Name = "buttonUpdateBook";
            buttonUpdateBook.Size = new Size(121, 34);
            buttonUpdateBook.TabIndex = 46;
            buttonUpdateBook.Text = "Opdater bog";
            buttonUpdateBook.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Location = new Point(1390, 604);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(121, 34);
            buttonDeleteBook.TabIndex = 47;
            buttonDeleteBook.Text = "Slet bog";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // chooseFiles
            // 
            chooseFiles.Location = new Point(1443, 367);
            chooseFiles.Name = "chooseFiles";
            chooseFiles.Size = new Size(121, 34);
            chooseFiles.TabIndex = 48;
            chooseFiles.Text = "Vælg billedfil";
            chooseFiles.UseVisualStyleBackColor = true;
            chooseFiles.Click += chooseFiles_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1443, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(221, 251);
            flowLayoutPanel1.TabIndex = 49;
            // 
            // labelProcessText
            // 
            labelProcessText.AutoSize = true;
            labelProcessText.Location = new Point(59, 670);
            labelProcessText.Name = "labelProcessText";
            labelProcessText.Size = new Size(16, 15);
            labelProcessText.TabIndex = 50;
            labelProcessText.Text = "...";
            // 
            // ShowBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1747, 787);
            Controls.Add(labelProcessText);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(chooseFiles);
            Controls.Add(buttonDeleteBook);
            Controls.Add(buttonUpdateBook);
            Controls.Add(buttonGetAllBooks);
            Controls.Add(buttonCreateBook);
            Controls.Add(lblBookId);
            Controls.Add(lblStatus);
            Controls.Add(lblLokation);
            Controls.Add(LblIsbn);
            Controls.Add(lblType);
            Controls.Add(LblAddBook);
            Controls.Add(lblNoOfPages);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(textBoxId);
            Controls.Add(textBoxIsbnNo);
            Controls.Add(textBoxNoOfPages);
            Controls.Add(textBoxAuthor);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxLocation);
            Controls.Add(comboBoxGenre);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxTitle);
            Controls.Add(BookList);
            Controls.Add(listViewShowBooks);
            Controls.Add(buttonCloseWindow);
            ForeColor = SystemColors.ControlText;
            Name = "ShowBooks";
            Text = "ShowBooks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCloseWindow;
        private ListView listViewShowBooks;
        private ColumnHeader Titel;
        private ColumnHeader Forfatter;
        private ColumnHeader SideAntal;
        private ColumnHeader BogType;
        private ColumnHeader IsbnNr;
        private ColumnHeader Status;
        private Label BookList;
        private ColumnHeader bogId;
        private ColumnHeader Genre;
        private ColumnHeader Lokation;
        private TextBox textBoxTitle;
        private ComboBox comboBoxType;
        private ComboBox comboBoxGenre;
        private ComboBox comboBoxLocation;
        private ComboBox comboBoxStatus;
        private TextBox textBoxAuthor;
        private TextBox textBoxNoOfPages;
        private TextBox textBoxIsbnNo;
        private TextBox textBoxId;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblNoOfPages;
        private Label LblAddBook;
        private Label lblType;
        private Label LblIsbn;
        private Label lblLokation;
        private Label lblStatus;
        private Label lblBookId;
        private Button buttonCreateBook;
        private Button buttonGetAllBooks;
        private Button buttonUpdateBook;
        private Button buttonDeleteBook;
        private Button chooseFiles;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelProcessText;
    }
}