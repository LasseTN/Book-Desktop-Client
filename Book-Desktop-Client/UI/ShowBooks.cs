using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.Util;
using Model;
using System.Reflection.Metadata.Ecma335;

namespace Book_Desktop_Client.UI {
    public partial class ShowBooks : Form {

        private List<Book> _booksToShowList;
        private List<Genre>? _genreList;
        private List<Location> _locationList;
        private List<Type> _typeList;
        

        private readonly IBookControl _bookControl;
        private readonly IGenreControl _genreControl;
        private readonly ILocationControl _locationControl;

        public ShowBooks() {
            _booksToShowList = new List<Book>();
            _genreControl = new GenreControl();
            _locationControl = new LocationControl();
            _bookControl = new BookControl();

            LoadDataAsync();
            InitializeComponent();



            // Type
            comboBoxType.DataSource = Enum.GetValues(typeof(BookTypeEnum));
            BookTypeEnum bookType = (BookTypeEnum)comboBoxType.SelectedItem;

            // Status
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
            StatusEnum bookStatus = (StatusEnum)comboBoxStatus.SelectedItem;

        }

        private bool validateInputs() {
            string errorMessage = "Tjek inputfelterne:\n";
            bool isValid = false;

            errorMessage += ((Genre)comboBoxGenre.SelectedItem != null) ? "" : "Genre - kan ikke være tom\n";

            errorMessage += Util.inputValidator.TextInputValidator(comboBoxGenre.SelectedValue.ToString()!);

            if (
                ((Genre)comboBoxGenre.SelectedItem != null) &&
                Util.inputValidator.TextInputValidator(comboBoxGenre.SelectedValue.ToString()!)) {
                isValid = true;
            } else {
                isValid = false;
                Util.inputValidator.ShowErrorMessage(errorMessage);
            }

            return isValid;
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
                comboBoxGenre.Text = item.SubItems[2].Text ?? string.Empty;
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

            string processText = labelProcessText.Text;
            await CreateNewBookModel();
            ShowGenre showBookModels = new ShowGenre();
            showBookModels.UpdateList();


        }

        private async Task CreateNewBookModel() {

            Book? createdBook = null;

            labelProcessText.Text = "Arbejder på sagen...";

            Book? book = comboBoxGenre.SelectedItem as Book;

            createdBook.Title = textBoxTitle.Text;
            createdBook.Author = textBoxAuthor.Text;

            Genre selectedGenre = (Genre)comboBoxGenre.SelectedItem;
            //Genre selectedGenre = new Genre { GenreName = selectedGenre.ToString() };
            createdBook.Genre = selectedGenre;

            createdBook.NoOfPages = int.Parse(textBoxNoOfPages.Text);

            createdBook.BookType = ((BookTypeEnum)comboBoxType.SelectedItem).ToString();
            createdBook.IsbnNo = textBoxIsbnNo.Text;

            Location selectedLoactionEnum = (Location)comboBoxLocation.SelectedItem;
            Location selectedLocation = new Location { LocationName = selectedLoactionEnum.ToString() };
            createdBook.Location = selectedLocation;

            createdBook.Status = ((StatusEnum)comboBoxStatus.SelectedItem).ToString();

            Book createBook = new Book(-1, createdBook.Title, createdBook.Author, createdBook.Genre, createdBook.NoOfPages, createdBook.BookType, createdBook.IsbnNo, createdBook.Location, createdBook.Status);
            createdBook = await _bookControl.CreateNewBook(createBook);
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

        private async void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e) {

            Genre selectedGenre = (Genre)comboBoxGenre.SelectedItem;

            if (selectedGenre != null) {
                _genreList = await _genreControl.GetAllGenres();

                if (_genreList!.Count <= 0) {
                    comboBoxGenre.Enabled = false;
                    comboBoxGenre.Hide();

                } else {
                    comboBoxGenre.Enabled = true;
                    comboBoxGenre.Show();
                }

                //    comboBoxGenre.DataSource = _genreList;
                //    comboBoxGenre.DisplayMember = "GenreName";
                //    comboBoxGenre.ValueMember = "GenreId";
            }



            //comboBoxGenre.SelectedIndex = (int) GenreEnum.Roman;
        }

        private async void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e) {
            Location selectedLocation = (Location)comboBoxLocation.SelectedItem;

            if (selectedLocation != null) {
                _locationList = await _locationControl.GetAllLocations();

                if (_locationList!.Count <= 0) {
                    comboBoxLocation.Enabled = false;
                    comboBoxLocation.Hide();

                } else {
                    comboBoxLocation.Enabled = true;
                    comboBoxLocation.Show();
                }
            }
        }
        private async void LoadDataAsync() {
            _genreList = await _genreControl.GetAllGenres();
            _locationList = await _locationControl.GetAllLocations();

            //Genre
            comboBoxGenre.DisplayMember = "GenreName";
            comboBoxGenre.ValueMember = "GenreId";
            comboBoxGenre.DataSource = _genreList;

            //Location
            comboBoxLocation.DisplayMember = "locationName";
            comboBoxLocation.ValueMember = "locationId";
            comboBoxLocation.DataSource = _locationList;
        }


    }
}



