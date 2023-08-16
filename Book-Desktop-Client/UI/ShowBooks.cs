using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.Util;
using Model;
using System.Windows.Forms.VisualStyles;

namespace Book_Desktop_Client.UI {
    public partial class ShowBooks : Form {

        private List<Book> _booksToShowList;
        private List<Genre>? _genreList;
        private List<Type> _typeList;
        private List<Location> _locationList;

        private readonly IBookControl _bookControl;
        private readonly IGenreControl _genreControl;
        private readonly ILocationControl _locationControl;
        public ShowBooks() {
            _booksToShowList = new List<Book>();
            _genreControl = new GenreControl();
            _locationList = new List<Location>();

            InitializeComponent();
            _bookControl = new BookControl();

            // Genre
            comboBoxGenre.DataSource = Enum.GetValues(typeof(GenreEnum));

            // Type
            comboBoxType.DataSource = Enum.GetValues(typeof(BookTypeEnum));
            BookTypeEnum bookType = (BookTypeEnum)comboBoxType.SelectedIndex;

            // Status
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
            StatusEnum bookStatus = (StatusEnum)comboBoxType.SelectedIndex;
            
            // Location
            comboBoxLocation.DataSource = Enum.GetValues(typeof(LocationEnum));
        }


        private void ShowBooks_Load(object sender, EventArgs e) {

        }


        private async void buttonGetAllBooks_Click(object sender, EventArgs e) {
            buttonGetAllBooks.Enabled = false;
            labelProcessText.Text = "Arbejder...";
            listViewShowBooks.Items.Clear();
            _booksToShowList = await _bookControl.GetAllBooks();

            if (_booksToShowList != null) {

                if (_booksToShowList.Count >= 1) {

                    labelProcessText.Text = $"Fandt: {_booksToShowList.Count.ToString()} bøger";

                } else {
                    labelProcessText.Text = "Ingen bøger fundet";
                }
            } else {
                labelProcessText.Text = "Noget gik galt";
            }
            if (_booksToShowList == null) {
                MessageBox.Show("Er rest åben?");
            } else {
                foreach (Book b in _booksToShowList) {
                    string[] details = {

                        b.Title,
                        b.Author,
                        b.Genre.GenreName,
                        b.NoOfPages.ToString(),
                        b.BookType,
                        b.IsbnNo,
                        b.Location.LocationName,
                        b.Status,
                        b.BookId.ToString() ?? "Fejl",


                    };
                    ListViewItem booksDetail = new ListViewItem(details);
                    listViewShowBooks.Items.Add(booksDetail);
                }
                buttonGetAllBooks.Enabled = true;
            }
        }

        private void listViewShowBooks_SelectedIndexChanged(object sender, EventArgs e) {
            string processText = "Bog id ";

            if (listViewShowBooks.SelectedItems.Count > 0) {
                ListViewItem item = listViewShowBooks.SelectedItems[0];

                textBoxTitle.Text = item.SubItems[0].Text;
                textBoxAuthor.Text = item.SubItems[1].Text;
                comboBoxGenre.Text = item.SubItems[2].Text;
                textBoxNoOfPages.Text = item.SubItems[3].Text;
                comboBoxType.Text = item.SubItems[4].Text;
                textBoxIsbnNo.Text = item.SubItems[5].Text;
                comboBoxLocation.Text = item.SubItems[6].Text;
                comboBoxStatus.Text = item.SubItems[7].Text;
                textBoxId.Text = item.SubItems[8].Text;
                labelProcessText.Text = processText + listViewShowBooks.SelectedItems[0].SubItems[8].Text;


            }
        }

        private void buttonPicture_Click(object sender, EventArgs e) {

        }

        private async void buttonCreateBook_Click(object sender, EventArgs e) {

            Book? createdBook = null;
            labelProcessText.Text = "Arbejder på sagen...";

            createdBook.Title = textBoxTitle.Text;
            createdBook.Author = textBoxAuthor.Text;
            createdBook.Genre = (Genre)comboBoxGenre.SelectedItem;
            createdBook.NoOfPages = int.Parse(textBoxNoOfPages.Text);
            createdBook.BookType = comboBoxType.SelectedValue.ToString();
            createdBook.IsbnNo = textBoxIsbnNo.Text;
            createdBook.Location = (Location)comboBoxLocation.SelectedItem;
            createdBook.Status = comboBoxStatus.SelectedValue.ToString();
            createdBook.BookId = int.Parse(textBoxId.Text);

            createdBook = await _bookControl.CreateNewBook(createdBook);
            if (createdBook != null) {
                labelProcessText.Text = "Bogen er oprettet";
                MessageBox.Show($"Du har nu oprettet bogen som fik id: {createdBook.BookId}");
                this.Close();
            }

        }

        private void buttonUpdateBook_Click(object sender, EventArgs e) {

        }

        private void buttonDeleteBook_Click(object sender, EventArgs e) {

        }

        private void buttonCloseWindow_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil lukke vinduet?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Close();
            } else if (dialogResult == DialogResult.No) {

            }
        }


    }
}



