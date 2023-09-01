using Book_Desktop_Client.ControlLayer;
using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;

namespace Book_Desktop_Client.UI {
    public partial class ShowLocations : Form {
        private readonly ILocationControl _locationControl;
        public ShowLocations() {
            InitializeComponent();

            _locationControl = new LocationControl();
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

        private async void ButtonUpdateLocation_Click(object sender, EventArgs e) {
            if (listViewShowLocations.SelectedItems.Count != 0) {

                await UpdateLocation();
                await UpdateList();
            } else {
                MessageBox.Show("Du skal vælge en lokation på listen");
            }
            await ClearTextBoxes();
        }


        private async void buttonDeleteLocation_Click(object sender, EventArgs e) {

            if (listViewShowLocations.SelectedItems.Count != 0) {
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette den valgte lokation?", "Bekræft", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes) {

                    await DeleteGenre();
                    await UpdateList();
                    await ClearTextBoxes();

                } else if (dialogResult == DialogResult.No) {
                    MessageBox.Show("Du skal vælge en lokation fra listen");
                }
                await UpdateProcessText();
            }
        }

        private async Task DeleteGenre() {
            string processText = "Ok";

            int id;
            id = GetAsInt(textBoxLocationId.Text);

            if (id > 0) {
                await _locationControl.DeleteLocation(id);
                processText = "Ok";
                await UpdateList();
            } else {
                processText = "Something went wrong";
            }
        }



        private async void listViewShowLocations_SelectedIndexChanged(object sender, EventArgs e) {
            string processText = "Location id";

            if (listViewShowLocations.SelectedItems.Count > 0) {
                ListViewItem item = listViewShowLocations.SelectedItems[0];

                textBoxLocation.Text = item.SubItems[0].Text;
                textBoxLocationId.Text = item.SubItems[1].Text;
                labelProcessText.Text = processText + listViewShowLocations.SelectedItems[0].SubItems[1].Text;

            } else if (listViewShowLocations.SelectedItems.Count <= 0) {

                textBoxLocation.Text = string.Empty;
                textBoxLocationId.Text = string.Empty;
                UpdateProcessText();
            }
        }

        private async Task UpdateLocation() {
            bool wasUpdateOk;
            string processText = "Lokationen blev opdateret";
            int idRaw = GetAsInt(textBoxLocationId.Text);
            string locationName = textBoxLocation.Text;

            if (idRaw != 0 && !string.IsNullOrEmpty(locationName)) {

                Location loc = new Location(idRaw, locationName);

                wasUpdateOk = await _locationControl.UpdateLocationById(idRaw, loc);
            } else {
                wasUpdateOk = false;
            }
            if (!wasUpdateOk) {
                processText = "Lokationen blev ikke opdateret";
            }
            labelProcessText.Text = processText;
        }
    }
}

