using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;
using System.Globalization;

namespace Book_Desktop_Client.UI {
    public partial class ShowEmployees : Form {

        readonly IEmployeeControl _employeeControl;

        public ShowEmployees() {
            InitializeComponent();

            _employeeControl = new EmployeeControl();

            UpdateProcessText();
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

        private async Task UpdateList() {
            string processText = "Ok";
            listViewShowEmployees.Items.Clear();
            List<Employee>? employees = await _employeeControl.GetAllEmployees();

            if (employees != null) {

                if (employees.Count >= 1) {

                    processText = "Medarbejdere blev opdateret";

                } else {
                    processText = "Ingen medarbejdere fundet";

                }
            } else {
                processText = "Noget gik galt";
            }

            foreach (Employee employee in employees) {

                string[] details = { employee.FirstName, employee.LastName, employee.BirthDate.ToString(), employee.Address, employee.Phone, employee.Email, employee.Id.ToString() };
                ListViewItem employeeDetails = new ListViewItem(details);
                listViewShowEmployees.Items.Add(employeeDetails);
            }
            labelProcessText.Text = processText;
        }

        private async Task UpdateProcessText() {
            labelProcessText.Text = "Der er lige nu " + listViewShowEmployees.Items.Count.ToString() + " medarbejdere på listen";
        }

        private async void listViewShowEmployees_SelectedIndexChanged(object sender, EventArgs e) {

            string processText = "Medarbejder id ";

            if (listViewShowEmployees.SelectedItems.Count > 0) {

                ListViewItem item = listViewShowEmployees.SelectedItems[0];

                textBoxFirstName.Text = item.SubItems[0].Text;
                textBoxLastName.Text = item.SubItems[1].Text;
                textBoxAddress.Text = item.SubItems[2].Text;
                textBoxMobil.Text = item.SubItems[3].Text;
                textBoxEmployeeId.Text = item.SubItems[4].Text;
                labelProcessText.Text = processText + listViewShowEmployees.SelectedItems[0].SubItems[5].Text;

                DateTime tempDob = DateTime.ParseExact(item.SubItems[4].Text.Trim(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                //datePickerDob.Value = tempDob;

                textBoxEmployeeId.Text = item.SubItems[5].Text;

            } else if (listViewShowEmployees.SelectedItems.Count <= 0) {

                textBoxFirstName.Text = string.Empty;
                textBoxLastName.Text = string.Empty;
                textBoxAddress.Text = string.Empty;
                textBoxMobil.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                await UpdateProcessText();
            }
        }
    }
}
