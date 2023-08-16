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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
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
            buttonPicture = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelProcessText = new Label();
            SuspendLayout();
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.BackColor = Color.Salmon;
            buttonCloseWindow.Location = new Point(1259, 665);
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
            listViewShowBooks.Size = new Size(824, 487);
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
            Forfatter.Width = 150;
            // 
            // Genre
            // 
            Genre.Text = "Genre";
            // 
            // SideAntal
            // 
            SideAntal.Text = "Antal sider";
            SideAntal.Width = 80;
            // 
            // BogType
            // 
            BogType.Text = "Type";
            BogType.Width = 80;
            // 
            // IsbnNr
            // 
            IsbnNr.Text = "Isbn";
            IsbnNr.Width = 70;
            // 
            // Lokation
            // 
            Lokation.Text = "Lokation";
            // 
            // Status
            // 
            Status.Text = "Status";
            // 
            // bogId
            // 
            bogId.Text = "Bog id";
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
            // textBox1
            // 
            textBox1.Location = new Point(984, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(984, 321);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(984, 206);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 27;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(984, 439);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 28;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(984, 497);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(984, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(984, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(984, 378);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(984, 557);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(121, 23);
            textBox5.TabIndex = 33;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(984, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(36, 17);
            lblTitle.TabIndex = 34;
            lblTitle.Text = "Titel";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.Location = new Point(984, 129);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(62, 17);
            lblAuthor.TabIndex = 35;
            lblAuthor.Text = "Forfatter";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenre.Location = new Point(984, 186);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(44, 17);
            lblGenre.TabIndex = 36;
            lblGenre.Text = "Genre";
            // 
            // lblNoOfPages
            // 
            lblNoOfPages.AutoSize = true;
            lblNoOfPages.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoOfPages.Location = new Point(984, 242);
            lblNoOfPages.Name = "lblNoOfPages";
            lblNoOfPages.Size = new Size(75, 17);
            lblNoOfPages.TabIndex = 37;
            lblNoOfPages.Text = "Antal sider";
            // 
            // LblAddBook
            // 
            LblAddBook.AutoSize = true;
            LblAddBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblAddBook.Location = new Point(984, 30);
            LblAddBook.Name = "LblAddBook";
            LblAddBook.Size = new Size(69, 17);
            LblAddBook.TabIndex = 38;
            LblAddBook.Text = "Tilføj bog";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(984, 301);
            lblType.Name = "lblType";
            lblType.Size = new Size(37, 17);
            lblType.TabIndex = 39;
            lblType.Text = "Type";
            // 
            // LblIsbn
            // 
            LblIsbn.AutoSize = true;
            LblIsbn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblIsbn.Location = new Point(984, 358);
            LblIsbn.Name = "LblIsbn";
            LblIsbn.Size = new Size(51, 17);
            LblIsbn.TabIndex = 40;
            LblIsbn.Text = "Isbn nr";
            // 
            // lblLokation
            // 
            lblLokation.AutoSize = true;
            lblLokation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLokation.Location = new Point(984, 419);
            lblLokation.Name = "lblLokation";
            lblLokation.Size = new Size(62, 17);
            lblLokation.TabIndex = 41;
            lblLokation.Text = "Lokation";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(984, 477);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 17);
            lblStatus.TabIndex = 42;
            lblStatus.Text = "Status";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookId.Location = new Point(984, 537);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(20, 17);
            lblBookId.TabIndex = 43;
            lblBookId.Text = "Id";
            // 
            // buttonCreateBook
            // 
            buttonCreateBook.Location = new Point(984, 610);
            buttonCreateBook.Name = "buttonCreateBook";
            buttonCreateBook.Size = new Size(121, 34);
            buttonCreateBook.TabIndex = 44;
            buttonCreateBook.Text = "Tilføj bog";
            buttonCreateBook.UseVisualStyleBackColor = true;
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
            buttonUpdateBook.Location = new Point(1126, 610);
            buttonUpdateBook.Name = "buttonUpdateBook";
            buttonUpdateBook.Size = new Size(121, 34);
            buttonUpdateBook.TabIndex = 46;
            buttonUpdateBook.Text = "Opdater bog";
            buttonUpdateBook.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Location = new Point(1259, 610);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(121, 34);
            buttonDeleteBook.TabIndex = 47;
            buttonDeleteBook.Text = "Slet bog";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // buttonPicture
            // 
            buttonPicture.Location = new Point(1159, 367);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(121, 34);
            buttonPicture.TabIndex = 48;
            buttonPicture.Text = "Vælg billedfil";
            buttonPicture.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1159, 93);
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
            ClientSize = new Size(1453, 718);
            Controls.Add(labelProcessText);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonPicture);
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
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(BookList);
            Controls.Add(listViewShowBooks);
            Controls.Add(buttonCloseWindow);
            ForeColor = SystemColors.ControlText;
            Name = "ShowBooks";
            Text = "ShowBooks";
            Load += ShowBooks_Load;
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
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
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
        private Button buttonPicture;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelProcessText;
    }
}