using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;

namespace Book_Desktop_Client.UI {
    public partial class ShowBooks : Form {

        readonly IBookControl _bookControl;
        private List<Book> _booksToShowList;
        public ShowBooks() {
            InitializeComponent();
            _bookControl = new BookControl();
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
                        b.BookType.ToString(),
                        b.IsbnNo,
                        b.Location.LocationName,
                        b.Status,
                        b.BookId.ToString() ?? "Fejl",
                        //b.BookImagesPath != null ? $"{b.BookImagesPath.Count().ToString()} stk." : "ingen",


                    };
                    ListViewItem booksDetail = new ListViewItem(details);
                    listViewShowBooks.Items.Add(booksDetail);
                }
                buttonGetAllBooks.Enabled = true;
            }
        }

        private void listViewShowBooks_SelectedIndexChanged(object sender, EventArgs e) {
            if (listViewShowBooks.SelectedItems.Count > 0) {

                if (listViewShowBooks.SelectedItems.Count > 0) {
                    string text = listViewShowBooks.SelectedItems[0].Text;

                    int value = int.Parse(text);

                    Book selectedBook = _booksToShowList.Find(book => book.BookId == value);

                    // UpdateBook(selectedBook);
                }
            }
        }

        private void buttonPicture_Click(object sender, EventArgs e) {

        }

        private void buttonCreateBook_Click(object sender, EventArgs e) {

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


        //private void UpdateBook(Book? bookToUpdate) {
        //    var bookToUpdatePage = new UpdateBook(bookToUpdate);
        //    this.Hide();
        //    bookToUpdate.Show();
        //    this.Show();
        //}
    }
}



