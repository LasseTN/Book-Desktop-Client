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
        public ShowGenre() {
            InitializeComponent();
        }

        private void buttoShowGenres_Click(object sender, EventArgs e) {

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
    }
}
