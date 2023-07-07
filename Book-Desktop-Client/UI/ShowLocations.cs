using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;
using System.Diagnostics.Eventing.Reader;

namespace Book_Desktop_Client.UI {
    public partial class ShowLocations : Form {
        private readonly ILocationControl _locationControl;
        public ShowLocations() {
            InitializeComponent();

            _locationControl = new LocationControl();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil lukke vinduet?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Close();
            } else if (dialogResult == DialogResult.No) {

            }
        }

        private async void buttoGetLocations_Click(object sender, EventArgs e) {
            await UpdateList();
            await UpdateProcessText();
        }

        private async Task UpdateProcessText() {
            labelProcessText.Text = "Der er lige nu " + listViewShowLocations.Items.Count.ToString() + " lokationer på listen";
        }

        private async Task UpdateList() {
            string processText = "Ok";
            listViewShowLocations.Items.Clear();
            List<Location> locations = await _locationControl.GetAllLocations();

            if (locations.Count >= 1) {

                if (locations.Count >= 1) {



                    processText = "Lokationer blev opdateret";

                } else {
                    processText = "Ingen lokationer fundet";
                }

                foreach (Location location in locations) {
                    string[] details = { location.LocationName, location.LocationId.ToString() };
                    ListViewItem locationDetails = new ListViewItem(details);
                    listViewShowLocations.Items.Add(locationDetails);
                }
            } else {
                processText = "Noget gik galt";
            }
            labelProcessText.Text = processText;
        }


        private async void buttonCreateLocation_Click(object sender, EventArgs e) {

            Location? createdLocation = null;
            labelProcessText.Text = "Arbejder på sagen...";

            string locationName = textBoxLocation.Text;

            if (InputIsOk(locationName)) {
                Location locationToCreate = new Location(-1, locationName);
                createdLocation = await _locationControl.CreateNewLocation(locationToCreate);

                if (createdLocation == null) {
                    labelProcessText.Text = "Der skete en fejl";
                    MessageBox.Show("Lokationen blev ikke oprettet, prøv igen");


                } else {
                    labelProcessText.Text = "Ok!";
                    MessageBox.Show($"{createdLocation.LocationName} med id {createdLocation.LocationId.ToString()} er oprettet");

                } 
            } else {
                labelProcessText.Text = "Udfyld venligst alle felterne";
                MessageBox.Show($"Udfyld venligst alle felterne");
            }
            UpdateList();
            ClearTextBoxes();
        }

        private async Task ClearTextBoxes() {
            textBoxLocation.Clear();
            textBoxLocationId.Clear();
        }

        private bool InputIsOk(string locationName) {
            bool isValidInput = false;
            if (!string.IsNullOrWhiteSpace(locationName)) {
                if (locationName.Length > 1) {
                    isValidInput = true;
                }
            }
            return isValidInput;
        }

        private void buttonUpdateLocation_Click(object sender, EventArgs e) {

        }

        private void buttonDeleteLocation_Click(object sender, EventArgs e) {

        }

        private void listViewShowLocations_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
