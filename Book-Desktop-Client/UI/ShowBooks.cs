using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.Util;
using Model;
using System.Net;

namespace Book_Desktop_Client.UI {
    public partial class ShowBooks : Form {

        private Book _selectedSortBy;
        private Book _bookToUpdate;

        private List<Book> _booksToShowList;
        private List<Genre>? _genreList;
        private List<Location> _locationList;

        private readonly IBookControl _bookControl;
        private readonly IGenreControl _genreControl;
        private readonly ILocationControl _locationControl;

        public ShowBooks() {
            _bookControl = new BookControl();
            _selectedSortBy = new Book();
            _bookToUpdate = new Book();
            _booksToShowList = new List<Book>();
            _genreControl = new GenreControl();
            _locationControl = new LocationControl();

            LoadDataAsync();
            InitializeComponent();

            // Type
            comboBoxType.DataSource = Enum.GetValues(typeof(BookTypeEnum));
            BookTypeEnum bookType = (BookTypeEnum)comboBoxType.SelectedItem;

            // Status
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
            StatusEnum bookStatus = (StatusEnum)comboBoxStatus.SelectedItem;
        }

        private int GetAsInt(string rawString) {
            int foundId = -1;

            if (!string.IsNullOrEmpty(rawString)) {
                bool wasParseOk = int.TryParse(rawString.Trim(), out foundId);
                if (!wasParseOk) {
                    foundId = -1;
                }
            }
            return foundId;
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


        private async void buttonGetAllBooks_Click(object sender, EventArgs e) {

            string processText = labelProcessText.Text;
            await GetAllBooks();
            ShowBooks showBookModels = new ShowBooks();
        }

        // This method is responsible for retrieving all books and displaying them.
        private async Task GetAllBooks() {

            // Disable the button to prevent multiple clicks.
            buttonGetAllBooks.Enabled = false;

            // Set the label to indicate the process is running.
            labelProcessText.Text = "Arbejder...";

            // Clear the previous list of books.
            listViewShowBooks.Items.Clear();

            // Await the completion of the GetAllBooks method from _bookControl.
            _booksToShowList = await _bookControl.GetAllBooks();

            // Check if the list is not null.
            if (_booksToShowList != null) {

                // If there 1 or more books then...
                if (_booksToShowList.Count >= 1) {

                    // Display the number of books found.
                    labelProcessText.Text = $"Fandt: {_booksToShowList.Count.ToString()} bøger";

                } else {

                    labelProcessText.Text = "Ingen bøger fundet";
                }
            } else {

                // If the list is null, indicate that something went wrong.
                labelProcessText.Text = "Noget gik galt";
            }

            // Show a message box if the REST API is not accessible (or if _booksToShowList is null for some other reason).
            if (_booksToShowList == null) {
                MessageBox.Show("Er rest åben?");
            } else {

                // Loop through each book object in the list.
                foreach (Book b in _booksToShowList) {

                    // Prepare an array of book details.
                    string imageUrl = b.ImageURL != null ? b.ImageURL.ToString() : "No Image"; // Handle null or non-convertible value
                    string[] details = {
                    b.Title,
                    b.Author,
                    b.Genre.GenreName,
                    b.NoOfPages.ToString(),
                    b.BookType,
                    b.IsbnNo,
                    b.Location.LocationName,
                    imageUrl, // Use the modified imageUrl variable
                    b.Status,
                    b.BookId.ToString() ?? "Fejl"
                };


                    // Create a ListViewItem and add it to the ListView.
                    ListViewItem booksDetail = new ListViewItem(details);
                    listViewShowBooks.Items.Add(booksDetail);
                }

                // Re-enable the button after the process is complete.
                buttonGetAllBooks.Enabled = true;
            }
        }


        private void listViewShowBooks_SelectedIndexChanged(object sender, EventArgs e) {
            string processText = "Bog id ";

            if (listViewShowBooks.SelectedItems.Count > 0) {
                ListViewItem item = listViewShowBooks.SelectedItems[0];

                textBoxTitle.Text = item.SubItems[0].Text.Trim() ?? string.Empty;
                textBoxAuthor.Text = item.SubItems[1].Text.Trim();
                comboBoxGenre.Text = item.SubItems[2].Text.Trim() ?? string.Empty;
                textBoxNoOfPages.Text = item.SubItems[3].Text.Trim();
                comboBoxType.Text = item.SubItems[4].Text.Trim();
                textBoxIsbnNo.Text = item.SubItems[5].Text.Trim();
                comboBoxLocation.Text = item.SubItems[6].Text.Trim();
                comboBoxStatus.Text = item.SubItems[8].Text.Trim();
                txtBoxImageURL.Text = item.SubItems[7].Text.Trim();

                // Checks if the URL is valid
                if (Uri.TryCreate(item.SubItems[7].Text.Trim(), UriKind.Absolute, out Uri imageUrl)) {
                    try {
                        using (WebClient webClient = new WebClient()) {
                            byte[] data = webClient.DownloadData(imageUrl);
                            using (MemoryStream ms = new MemoryStream(data)) {
                                pictureBox1.Image = Image.FromStream(ms);
                                pictureBox1.Load(imageUrl.OriginalString);
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Error loading the image:" + ex.Message);
                    }
                } else {
                    pictureBox1.Image = null;
                }

                textBoxId.Text = item.SubItems[9].Text.Trim();
                labelProcessText.Text = processText + listViewShowBooks.SelectedItems[0].SubItems[9].Text;

            }
        }

        private async void buttonCreateBook_Click(object sender, EventArgs e) {

            string processText = labelProcessText.Text;
            await CreateNewBookModel();
            ShowGenre showBookModels = new ShowGenre();
        }

        private async Task CreateNewBookModel() {

            Book toCreate = new Book();
            Book? createdBook = null;

            labelProcessText.Text = "Arbejder på sagen...";

            Book? book = comboBoxGenre.SelectedItem as Book;

            toCreate.Title = textBoxTitle.Text;
            toCreate.Author = textBoxAuthor.Text;
            Genre selectedGenre = (Genre)comboBoxGenre.SelectedItem;
            toCreate.Genre = selectedGenre;
            toCreate.NoOfPages = int.Parse(textBoxNoOfPages.Text);
            toCreate.BookType = ((BookTypeEnum)comboBoxType.SelectedItem).ToString();
            toCreate.IsbnNo = textBoxIsbnNo.Text;
            Location selectedLocation = (Location)comboBoxLocation.SelectedItem;
            toCreate.Location = selectedLocation;
            toCreate.Status = ((StatusEnum)comboBoxStatus.SelectedItem).ToString();
            toCreate.ImageURL = txtBoxImageURL.Text;

            labelProcessText.Text = "Stadigvæk igang";

            createdBook = await _bookControl.CreateNewBook(toCreate);
            if (createdBook != null) {
                labelProcessText.Text = "Bogen er oprettet";
                MessageBox.Show($"Du har nu oprettet bogen som fik id: {createdBook.BookId}");
                GetAllBooks();
                ClearTextBoxes();
            }
        }

        private async Task ClearTextBoxes() {
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxNoOfPages.Clear();
            textBoxIsbnNo.Clear();
            textBoxId.Text = string.Empty;
            comboBoxGenre.Items.Clear();
            comboBoxType.Items.Clear();
            comboBoxLocation.Items.Clear();
            txtBoxImageURL.Clear();
            comboBoxStatus.Items.Clear();
            comboBoxSortBy.Items.Clear();
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
            }
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

            // Genre
            comboBoxGenre.DisplayMember = "GenreName";
            comboBoxGenre.ValueMember = "GenreId";
            comboBoxGenre.DataSource = _genreList;

            // Location
            comboBoxLocation.DisplayMember = "locationName";
            comboBoxLocation.ValueMember = "locationId";
            comboBoxLocation.DataSource = _locationList;

            // Sort By
            comboBoxSortBy.Items.Add("Forfatter");
            comboBoxSortBy.Items.Add("Genre");
            comboBoxSortBy.Items.Add("Status");
            comboBoxSortBy.Items.Add("Titel");
            comboBoxSortBy.Items.Add("Bogtype");
        }

        private async void buttonUpdateBook_Click(object sender, EventArgs e) {
            bool isUpdated = false;

            // Checks if an item is selected in the listview
            if (listViewShowBooks.SelectedItems.Count > 0) {

                // Gets the selected item (represents a Book object)
                ListViewItem selectedItem = listViewShowBooks.SelectedItems[0];

                // Gets the bookId from the ListViewItems subitems (assuming its the last subitem)
                int idRaw = GetAsInt(selectedItem.SubItems[selectedItem.SubItems.Count - 1].Text);

                if (validateInputs()) {
                    _bookToUpdate.BookId = idRaw;
                    _bookToUpdate.Title = textBoxTitle.Text;
                    _bookToUpdate.Author = textBoxAuthor.Text;
                    Genre selectedGenre = (Genre)comboBoxGenre.SelectedItem;
                    _bookToUpdate.Genre = selectedGenre;
                    _bookToUpdate.NoOfPages = int.Parse(textBoxNoOfPages.Text);
                    _bookToUpdate.BookType = ((BookTypeEnum)comboBoxType.SelectedItem).ToString();
                    _bookToUpdate.IsbnNo = textBoxIsbnNo.Text;
                    Location selectedLocation = (Location)comboBoxLocation.SelectedItem;
                    _bookToUpdate.Location = selectedLocation;
                    _bookToUpdate.ImageURL = txtBoxImageURL.Text;
                    _bookToUpdate.Status = ((StatusEnum)comboBoxStatus.SelectedItem).ToString();

                    // Passes the found bookId to the update method
                    isUpdated = await _bookControl.UpdateBook(_bookToUpdate);

                    if (isUpdated) {
                        MessageBox.Show("Du har opdateret bogens oplysninger");
                        GetAllBooks();
                    }
                }
            }
        }

        private async void ComboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox)sender;
            int selectedIndex = comboBox.SelectedIndex;

            if (selectedIndex >= 0) {
                string selectedSortBy = comboBox.SelectedItem.ToString();

                if (selectedSortBy == "Forfatter") {
                    _selectedSortBy.Author = comboBox.SelectedItem.ToString();
                    _selectedSortBy.Genre = null;
                    _selectedSortBy.Status = null;
                    _selectedSortBy.Title = null;
                    _selectedSortBy.BookType = null;


                } else if (selectedSortBy == "Genre") {
                    _selectedSortBy.Genre = Model.Genre.Parse(comboBoxSortBy.SelectedItem.ToString());
                    _selectedSortBy.Author = null;
                    _selectedSortBy.Status = null;
                    _selectedSortBy.Title = null;
                    _selectedSortBy.BookType = null;

                } else if (selectedSortBy == "Status") {
                    _selectedSortBy.Status = StatusEnum.Læst.ToString();
                    _selectedSortBy.Genre = null;
                    _selectedSortBy.Author = null;
                    _selectedSortBy.Title = null;
                    _selectedSortBy.BookType = null;

                } else if (selectedSortBy == "Titel") {
                    _selectedSortBy.Title = comboBox.SelectedItem.ToString();
                    _selectedSortBy.Author = null;
                    _selectedSortBy.Genre = null;
                    _selectedSortBy.Status = null;
                    _selectedSortBy.BookType = null;

                } else if (selectedSortBy == "Bogtype") {
                    _selectedSortBy.BookType = comboBox.SelectedItem.ToString();
                    _selectedSortBy.Author = null;
                    _selectedSortBy.Genre = null;
                    _selectedSortBy.Status = null;
                    _selectedSortBy.Title = null;
                }
            }
        }

        // Method for comparing genres in order to sort them
        public class BookComparerByGenre : IComparer<Book> {
            public int Compare(Book x, Book y) {
                if (x == null || y == null)
                    return 0;

                // Comparing genres
                return string.Compare(x.Genre.GenreName, y.Genre.GenreName, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void SortBy_Click(object sender, EventArgs e) {

            if (_selectedSortBy.Author != null) {
                _booksToShowList = _booksToShowList.OrderBy(book => book.Author).ToList();
            }

            if (_selectedSortBy.Genre != null) {
                _booksToShowList = _booksToShowList.OrderBy(book => book, new BookComparerByGenre()).ToList();
            }

            if (_selectedSortBy.Status != null) {
                _booksToShowList = _booksToShowList.OrderBy(book => book.Status).ToList();
            }

            if (_selectedSortBy.Title != null) {
                _booksToShowList = _booksToShowList.OrderBy(book => book.Title).ToList();
            }

            if (_selectedSortBy.BookType != null) {
                _booksToShowList = _booksToShowList.OrderBy(book => book.BookType).ToList();
            }

            listViewShowBooks.Items.Clear();
            foreach (Book book in _booksToShowList) {
                ListViewItem item = CreateListViewItem(book);
                listViewShowBooks.Items.Add(item);
            }
        }

        // The sorted list displayed
        private ListViewItem CreateListViewItem(Book book) {
            string[] details = {
                book.Title,
                book.Author,
                book.Genre.GenreName,
                book.NoOfPages.ToString(),
                book.BookType.ToString(),
                book.IsbnNo,
                book.Location.LocationName,
                book.ImageURL.ToString(),
                book.Status,
                book.BookId.ToString() ?? "Fejl",
            };
            return new ListViewItem(details);
        }
    }
}









