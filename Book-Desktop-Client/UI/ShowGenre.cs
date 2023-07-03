using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Desktop_Client.UI {
    public partial class ShowGenre : Form {
        private readonly IGenreControl _genreControl;
        public ShowGenre() {
            InitializeComponent();

            _genreControl = new GenreControl();

            UpdateProcessText();
        }

        private async Task UpdateProcessText() {
            labelProcessText.Text = "Der er lige nu " + listViewShowGenres.Items.Count.ToString() + " genrer på listen";
        }

        private async void buttoGetGenres_Click(object sender, EventArgs e) {
            await UpdateList();
            await UpdateProcessText();
        }

        private async Task UpdateList() {
            string processText = "Ok";
            listViewShowGenres.Items.Clear();
            List<Genre> genres = await _genreControl.GetAllGenres();

            if (genres != null) {

                if (genres.Count >= 1) {

                    processText = "Genrer blev opdateret";

                } else {
                    processText = "Ingen genrere fundet";
                }

                foreach (Genre genre in genres) {
                    string[] details = { genre.GenreName, genre.GenreId.ToString() };
                    ListViewItem genreDetails = new ListViewItem(details);
                    listViewShowGenres.Items.Add(genreDetails);
                }
            } else {
                processText = "Noget gik galt";
            }
            labelProcessText.Text = processText;
        }




        private void buttonCreateGenre_Click(object sender, EventArgs e) {

        }

        private void buttonUpdateGenre_Click(object sender, EventArgs e) {

        }

        private void buttonDeleteGenre_Click(object sender, EventArgs e) {

        }

        private void buttonCloseWindow_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil lukke vinduet?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Close();
            } else if (dialogResult == DialogResult.No) {
                // Handle "No" case here
            }
        }

        private void listViewShowGenres_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}

