using Book_Desktop_Client.UI;

namespace Book_Desktop_Client {
    public partial class HomePage : Form {
        public HomePage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var showEmployee = new ShowEmployees();
            this.Hide();
            showEmployee.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            var showGenre = new ShowGenre();
            this.Hide();
            showGenre.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            var ShowLocation = new ShowLocations();
            this.Hide();
            ShowLocation.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            var ShowBook = new ShowBooks();
            this.Hide();
            ShowBook.ShowDialog();
            this.Show();
        }
    }
}