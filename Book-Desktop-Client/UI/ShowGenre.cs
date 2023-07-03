using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private Task UpdateList() {
            throw new NotImplementedException();
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

