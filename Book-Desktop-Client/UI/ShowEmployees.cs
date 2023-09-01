using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;
using System.Globalization;

namespace Book_Desktop_Client.UI {
    public partial class ShowEmployees : Form {
        private readonly IEmployeeControl _employeeControl;

        public ShowEmployees() {
            InitializeComponent();

            _employeeControl = new EmployeeControl();

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

        private async void btnGetEmployees_Click(object sender, EventArgs e) {
            await UpdateList();
            await UpdateProcessText();
        }

        private async Task UpdateList() {
            string processText = "Ok";
            listViewShowEmployees.Items.Clear();
            List<Employee> employees = await _employeeControl.GetAllEmployees();

            if (employees != null) {

                if (employees.Count >= 1) {

                    processText = "Medarbejdere blev opdateret";

                } else {
                    processText = "Ingen medarbejdere fundet";
                }

                foreach (Employee employee in employees) {
                    string[] details = { employee.FirstName, employee.LastName, employee.Address, employee.Email, employee.Phone, employee.BirthDate.ToString(), employee.EmployeeId.ToString() };
                    ListViewItem employeeDetails = new ListViewItem(details);
                    listViewShowEmployees.Items.Add(employeeDetails);
                }

            } else {
                processText = "Noget gik galt";
            }

            labelProcessText.Text = processText;
        }


        private void listViewShowEmployees_SelectedIndexChanged(object sender, EventArgs e) {
            string processText = "Medarbejder id ";

            if (listViewShowEmployees.SelectedItems.Count > 0) {
                ListViewItem item = listViewShowEmployees.SelectedItems[0];

                textBoxFirstName.Text = item.SubItems[0].Text;
                textBoxLastName.Text = item.SubItems[1].Text;
                textBoxAddress.Text = item.SubItems[2].Text;
                textBoxMobil.Text = item.SubItems[4].Text;
                textBoxEmail.Text = item.SubItems[3].Text;
                textBoxEmployeeId.Text = item.SubItems[6].Text;
                labelProcessText.Text = processText + listViewShowEmployees.SelectedItems[0].SubItems[6].Text;

                DateTime tempDob;
                if (DateTime.TryParseExact(item.SubItems[5].Text.Trim(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out tempDob)) {
                    dateTimePickerEmployee.Value = tempDob;
                } else {
                }

            } else if (listViewShowEmployees.SelectedItems.Count <= 0) {

                textBoxFirstName.Text = string.Empty;
                textBoxLastName.Text = string.Empty;
                textBoxAddress.Text = string.Empty;
                textBoxMobil.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxEmployeeId.Text = string.Empty;
                UpdateProcessText();
            }
        }


        private async void buttonUpdateEmployee_Click(object sender, EventArgs e) {
            if (listViewShowEmployees.SelectedItems.Count != 0) {

                await UpdateEmployee();
                await UpdateList();
            } else {
                MessageBox.Show("Du skal vælge en medarbejder fra listen");
            }
            await ClearTextBoxes();
        }

        private async Task UpdateEmployee() {

            bool wasUpdatedOk;
            string processText = "Medarbejderen blev opdateret";
            int idRaw = GetAsInt(textBoxEmployeeId.Text);
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string address = textBoxAddress.Text;
            string mobil = textBoxMobil.Text;
            string email = textBoxEmail.Text;
            DateTime birthDate = dateTimePickerEmployee.Value;


            if (idRaw != 0 && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(mobil) && !string.IsNullOrEmpty(email)) {
                // Call service to POST
                Employee emp = new Employee(idRaw, firstName, lastName, birthDate, address, mobil, email);

                wasUpdatedOk = await _employeeControl.UpdateEmployeeById(idRaw, emp);
            } else {
                wasUpdatedOk = false;
            }
            if (!wasUpdatedOk) {
                processText = "Medarbejderen blev ikke opdateret";
            }

            labelProcessText.Text = processText;
        }

        private async Task ClearTextBoxes() {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxAddress.Clear();
            dateTimePickerEmployee.Value = DateTime.Now; // Or any default value you prefer
            textBoxMobil.Clear();
            textBoxEmail.Clear();
            textBoxEmployeeId.Clear();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil lukke vinduet?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Close();
            } else if (dialogResult == DialogResult.No) {
                // Handle "No" case here
            }
        }

        private async Task UpdateProcessText() {
            labelProcessText.Text = "Der er lige nu " + listViewShowEmployees.Items.Count.ToString() + " medarbejdere på listen";
        }

        private async void buttonCreateEmployee_Click(object sender, EventArgs e) {

            Employee? createdEmployee = null;
            labelProcessText.Text = "Arbejder på sagen...";

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string address = textBoxAddress.Text;
            string mobil = textBoxMobil.Text;
            string email = textBoxEmail.Text;
            DateTime birthDate = dateTimePickerEmployee.Value.Date;

            if (InputIsOk(firstName, lastName, address, mobil, email, birthDate)) {
                Employee employeeToCreate = new Employee(-1, firstName, lastName, birthDate, address, email, mobil);
                createdEmployee = await _employeeControl.CreateNewEmployee(employeeToCreate);

                if (createdEmployee == null) {
                    labelProcessText.Text = "Der skete en fejl";
                    MessageBox.Show("Medarbejderen blev ikke oprettet, prøv igen");



                } else {

                    labelProcessText.Text = "Ok!";
                    MessageBox.Show($"{createdEmployee.LastName} med id {createdEmployee.EmployeeId.ToString()} er oprettet");

                }
            } else {
                labelProcessText.Text = "Udfyld venligst alle felterne";
                MessageBox.Show("Udfyld venligst alle felterne");
            }
            UpdateList();
            ClearTextBoxes();

        }

        private bool InputIsOk(string firstName, string lastName, string address, string mobil, string email, DateTime birthDate) {
            bool isValidInput = false;
            if (!String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName) && !String.IsNullOrWhiteSpace(mobil) && !String.IsNullOrWhiteSpace(email)) {
                if (firstName.Length > 1 && lastName.Length > 1 && address.Length > 1 && mobil.Length == 8 && email.Contains('@')) {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }

        private async void buttonDeleteEmployee_Click(object sender, EventArgs e) {

            if (listViewShowEmployees.SelectedItems.Count != 0) {
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette den valgte medarbejderen?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes) {

                    await DeleteEmployee();
                    await UpdateList();
                    await ClearTextBoxes();

                } else if (dialogResult == DialogResult.No) {

                }
            } else {
                MessageBox.Show("Du skal vælge en medarbejder fra listen");
            }
            await UpdateProcessText();
        }

        private async Task DeleteEmployee() {
            string processText = "Ok";

            int id;
            id = GetAsInt(textBoxEmployeeId.Text);

            if (id > 0) {
                await _employeeControl.DeleteEmployees(id);
                processText = "Ok";
                await UpdateList();
            } else {
                processText = "Something went wrong";
            }
        }
    }
}