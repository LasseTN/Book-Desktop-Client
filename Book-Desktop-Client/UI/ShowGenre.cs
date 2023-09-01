using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;


namespace Book_Desktop_Client.UI {
    public partial class ShowGenre : Form {
        private readonly IGenreControl _genreControl;
        private List<Genre> _genreList;

        public ShowGenre() {
            InitializeComponent();

            _genreControl = new GenreControl();

            UpdateProcessText();
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

        private async Task UpdateProcessText() {
            labelProcessText.Text = "Der er lige nu " + listViewShowGenres.Items.Count.ToString() + " genrer på listen";
        }

        private async void buttoGetGenres_Click(object sender, EventArgs e) {
            await UpdateList();
            await UpdateProcessText();
        }

        public async Task UpdateList() {
            string processText = "";
            labelProcessText.Text = processText;
            listViewShowGenres.Items.Clear();
            _genreList = await _genreControl.GetAllGenres();

            if (_genreList != null) {
                if (_genreList.Count >= 1) {
                    processText = "Genrer blev opdateret";
                } else if (_genreList.Count < 1) {
                    processText = "Ingen genrer fundet";
                }

                foreach (Genre genre in _genreList) {
                    string[] details = { genre.GenreName, genre.GenreId.ToString() };
                    ListViewItem genreDetails = new ListViewItem(details);
                    listViewShowGenres.Items.Add(genreDetails);
                }
            } else {
                processText = "Noget gik galt";
            }
            labelProcessText.Text = processText;
        }


        private async void buttonCreateGenre_Click(object sender, EventArgs e) {

            Genre? createdGenre = null;
            labelProcessText.Text = "Arbejder på sagen...";

            string genreName = textBoxGenre.Text;

            if (InputIsOk(genreName)) {
                Genre genreToCreate = new Genre(-1, genreName);
                createdGenre = await _genreControl.CreateNewGenre(genreToCreate);

                if (createdGenre == null) {
                    labelProcessText.Text = "Der skete en fejl";
                    MessageBox.Show("Genren blev ikke oprettet, prøv igen");


                } else {
                    labelProcessText.Text = "Ok!";
                    MessageBox.Show($"{createdGenre.GenreName} med id {createdGenre.GenreId.ToString()} er oprettet");

                }
            } else {
                labelProcessText.Text = "Udfyld venligst alle felterne";
                MessageBox.Show("Udfyld venligst alle felterne");
            }
            UpdateList();
            ClearTextBoxes();
        }

        private async Task ClearTextBoxes() {
            textBoxGenre.Clear();
            textBoxGenreId.Clear();
        }

        private bool InputIsOk(string genreName) {
            bool isValidInput = false;
            if (!string.IsNullOrWhiteSpace(genreName)) {
                if (genreName.Length > 1) {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }

        private async void buttonUpdateGenre_Click(object sender, EventArgs e) {
            if (listViewShowGenres.SelectedItems.Count != 0) {

                await UpdateGenre();
                await UpdateList();
            } else {
                MessageBox.Show("Du skal vælge en genre fra listen");
            }
            await ClearTextBoxes();
        }

        private async Task UpdateGenre() {

            bool wasUpdatedOk;
            string processText = "Genren blev opdateret";
            int idRaw = GetAsInt(textBoxGenreId.Text);
            string genreName = textBoxGenre.Text;

            if (idRaw != 0 && !string.IsNullOrEmpty(genreName)) {

                Genre gen = new Genre(idRaw, genreName);

                wasUpdatedOk = await _genreControl.UpdateGenreById(idRaw, gen);
            } else {
                wasUpdatedOk = false;
            }
            if (!wasUpdatedOk) {
                processText = "Genren blev ikke opdateret";
            }
            labelProcessText.Text = processText;
        }



        private async void buttonDeleteGenre_Click(object sender, EventArgs e) {

            if (listViewShowGenres.SelectedItems.Count != 0) {
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette den valgte genrer?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes) {

                    await DeleteGenre();
                    await UpdateList();
                    await ClearTextBoxes();

                } else if (dialogResult == DialogResult.No) {
                    MessageBox.Show("Du skal vælge en genre fra listen");
                }
                await UpdateProcessText();
            }
        }

        private async Task DeleteGenre() {
            string processText = "Ok";

            int id;
            id = GetAsInt(textBoxGenreId.Text);

            if (id > 0) {
                await _genreControl.DeleteGenre(id);
                processText = "Ok";
                await UpdateList();
            } else {
                processText = "Something went wrong";
            }
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil lukke vinduet?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Close();
            } else if (dialogResult == DialogResult.No) {

            }
        }

        private async void listViewShowGenres_SelectedIndexChanged(object sender, EventArgs e) {
            string procesText = "Genre id";

            if (listViewShowGenres.SelectedItems.Count > 0) {
                ListViewItem item = listViewShowGenres.SelectedItems[0];

                textBoxGenre.Text = item.SubItems[1].Text;
                textBoxGenreId.Text = item.SubItems[0].Text;
                labelProcessText.Text = procesText + listViewShowGenres.SelectedItems[0].SubItems[1].Text;

            } else if (listViewShowGenres.SelectedItems.Count <= 0) {

                textBoxGenre.Text = string.Empty;
                textBoxGenreId.Text += string.Empty;
                UpdateProcessText();
            }
        }
    }
}

