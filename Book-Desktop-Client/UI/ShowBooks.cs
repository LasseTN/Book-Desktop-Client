using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Model;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Book_Desktop_Client.UI {
    public partial class ShowBooks : Form {

        private Book _selectedSortBy;
        private Book _bookToUpdate;
        private List<IFormFile> _imageList;

        private List<Book> _booksToShowList;
        private List<Genre>? _genreList;
        private List<Location> _locationList;

        private readonly IBookControl _bookControl;
        private readonly IGenreControl _genreControl;
        private readonly ILocationControl _locationControl;

        public ShowBooks() {
            _selectedSortBy = new Book();
            _bookToUpdate = new Book();
            _booksToShowList = new List<Book>();
            _genreControl = new GenreControl();
            _locationControl = new LocationControl();
            _bookControl = new BookControl();
            _imageList = new List<IFormFile>();

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

        private async Task GetAllBooks() {
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

                textBoxTitle.Text = item.SubItems[0].Text.Trim() ?? string.Empty;
                textBoxAuthor.Text = item.SubItems[1].Text.Trim();
                comboBoxGenre.Text = item.SubItems[2].Text.Trim() ?? string.Empty;
                textBoxNoOfPages.Text = item.SubItems[3].Text.Trim();
                comboBoxType.Text = item.SubItems[4].Text.Trim();
                textBoxIsbnNo.Text = item.SubItems[5].Text.Trim();
                comboBoxLocation.Text = item.SubItems[6].Text.Trim();
                comboBoxStatus.Text = item.SubItems[7].Text.Trim();
                textBoxId.Text = item.SubItems[8].Text.Trim();
                labelProcessText.Text = processText + listViewShowBooks.SelectedItems[0].SubItems[8].Text;

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
            toCreate.BookImagesPath = new List<string>();

            labelProcessText.Text = "Stadigvæk igang";

            if (_imageList.Count() > 0) {

                foreach (var file in _imageList) {
                    if (file.Length > 0) {
                        using (var ms = new MemoryStream()) {
                            file.CopyTo(ms);
                            var fileBytes = ms.ToArray();
                            string s = Convert.ToBase64String(fileBytes);
                            toCreate.BookImagesPath.Add(s);
                            labelProcessText.Text = "Billeder tilføjet";
                        }
                    }
                }
            }

            createdBook = new Book(-1, toCreate.Title, toCreate.Author, toCreate.Genre, toCreate.NoOfPages, toCreate.BookType, toCreate.IsbnNo, toCreate.Location, toCreate.Status, toCreate.BookImagesPath);
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
            comboBoxStatus.Items.Clear();
            comboBoxSortBy.Items.Clear();
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
            comboBoxSortBy.Items.Add("Author");
            comboBoxSortBy.Items.Add("Genre");

        }


        //Button for choosing images
        private void chooseFiles_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                foreach (string fileName in openFileDialog.FileNames) {
                    byte[] fileData = File.ReadAllBytes(fileName);
                    MemoryStream stream = new MemoryStream(fileData);
                    FormFile file = new FormFile(stream, 0, fileData.Length, null, Path.GetFileName(fileName));
                    _imageList.Add(file);
                }
                ShowImages();
            }
        }

        // Displays the image in the app and adds a delete button, so you can delete the picture
        private void ShowImages() {
            flowLayoutPanel1.Controls.Clear();
            foreach (FormFile file in _imageList) {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(file.OpenReadStream());
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Click += new EventHandler(PictureBox_Click!);

                Button btnDelete = new Button();
                btnDelete.Text = "Slet";
                btnDelete.Height = 30;
                btnDelete.Tag = file;
                btnDelete.Click += new EventHandler(BtnDelete_Click!);

                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        // Click the uploaded photo to maximize it
        private void PictureBox_Click(object sender, EventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            Image image = pictureBox.Image;

            Form popUpForm = new Form();
            popUpForm.StartPosition = FormStartPosition.CenterParent;
            popUpForm.Size = new Size(800, 600);
            popUpForm.MaximizeBox = false;
            popUpForm.MinimizeBox = false;
            popUpForm.Text = "Billede visning";

            PictureBox popupPictureBox = new PictureBox();
            popupPictureBox.Dock = DockStyle.Fill;
            popupPictureBox.Image = image;
            popupPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            popUpForm.Controls.Add(popupPictureBox);
            popUpForm.ShowDialog();
        }

        // Delete the uploaded photo
        private void BtnDelete_Click(object sender, EventArgs e) {
            Button btnDelete = (Button)sender;
            FormFile file = (FormFile)btnDelete.Tag;
            _imageList.Remove(file);
            FlowLayoutPanel panel = (FlowLayoutPanel)btnDelete.Parent;
            PictureBox pictureBox = (PictureBox)panel.Controls[0];
            pictureBox.Dispose();
            file.OpenReadStream().Dispose();
            panel.Dispose();
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
                    _bookToUpdate.Status = ((StatusEnum)comboBoxStatus.SelectedItem).ToString();
                    _bookToUpdate.BookImagesPath = new List<string>();

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

                if (selectedSortBy == "Author") {
                    _selectedSortBy.Author = comboBox.SelectedItem.ToString();
                    _selectedSortBy.Genre = null; // Reset the genre sorting
                } else if (selectedSortBy == "Genre") {
                    _genreControl.GetAllGenres();
                    _selectedSortBy.Genre = Model.Genre.Parse(comboBoxSortBy.SelectedItem.ToString());
                    _selectedSortBy.Author = null; // Reset the author sorting
                }

            }
        }


        // Method for comparing genres in order to sort them
        public class BookComparerByGenre : IComparer<Book> {
            public int Compare(Book x, Book y) {
                if (x == null || y == null)
                    return 0; // Handle null cases if needed

                // Compare based on Genre property
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

                listViewShowBooks.Items.Clear();
                foreach (Book book in _booksToShowList) {
                    ListViewItem item = CreateListViewItem(book);
                    listViewShowBooks.Items.Add(item);
                }
            }

            private ListViewItem CreateListViewItem(Book book) {
            string[] details = {
                book.Title,
                book.Author,
                book.Genre.GenreName,
                book.NoOfPages.ToString(),
                book.BookType.ToString(),
                book.IsbnNo,
                book.Location.LocationName,
                book.Status,
                book.BookId.ToString() ?? "Fejl",
            };
            return new ListViewItem(details);
        }


    }
}









