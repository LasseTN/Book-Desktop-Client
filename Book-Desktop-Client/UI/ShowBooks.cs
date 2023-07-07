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
    public partial class ShowBooks : Form {
        public ShowBooks() {
            InitializeComponent();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil lukke vinduet?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Close();
            } else if (dialogResult == DialogResult.No) {

            }
        }

        private void BookList_Click(object sender, EventArgs e) {

        }

        private void buttonGetAllBooks_Click(object sender, EventArgs e) {

        }

        private void buttonPicture_Click(object sender, EventArgs e) {

        }

        private void buttonCreateBook_Click(object sender, EventArgs e) {

        }

        private void buttonUpdateBook_Click(object sender, EventArgs e) {

        }

        private void buttonDeleteBook_Click(object sender, EventArgs e) {

        }
    }
}
