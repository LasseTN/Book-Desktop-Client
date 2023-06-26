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
    public partial class ShowEmployees : Form {
        public ShowEmployees() {
            InitializeComponent();
        }


        private void lblLastName_Click(object sender, EventArgs e) {

        }

        private void buttonCloseWindow_Click(object sender, EventArgs e) {

            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil lukke vinduet?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Close();
            } else if (dialogResult == DialogResult.No) {

            }
        }

        private async void btnGetEmployees_Click(object sender, EventArgs e) {
            await UpdateList();
            await UpdateProcessText();
        }

        private Task UpdateList() {
            throw new NotImplementedException();
        }

        private Task UpdateProcessText() {
            throw new NotImplementedException();
        }


    }
}
