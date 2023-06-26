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
    }
}