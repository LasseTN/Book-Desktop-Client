using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.ServiceLayer;
using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;

namespace Book_Desktop_Client.ControlLayer {
    public class LocationControl : ILocationControl {

        readonly ILocationAccess _locationServiceAccess;

        public LocationControl() {
            _locationServiceAccess = new LocationServiceAccess();
        }

        public async Task<Location> CreateNewLocation(Location locationToCreate) {
            Location? createdLocation;
            try {
                createdLocation = await _locationServiceAccess.CreateLocation(locationToCreate);
            } catch (Exception ex) {
                createdLocation = null;
            }
            return createdLocation;
        }

        public async Task<bool> DeleteLocation(int id) {
            bool wasDeleted = false;
            if (id > 0) {
                wasDeleted = await _locationServiceAccess.DeleteLocation(id);
            }
            return wasDeleted;
        }

        public async Task<List<Location>?> GetAllLocations() {
            List<Location>? foundLocations = null;
            if (_locationServiceAccess != null) {
                foundLocations = await _locationServiceAccess.GetAllLocations();
            }
            return foundLocations;
        }

        public async Task<bool> UpdateLocationById(int id, Location update) {
            bool wasUpdated;
            try {
                wasUpdated = await _locationServiceAccess.UpdateChoosenLocationById(id, update);
            } catch {
                wasUpdated = false;
            }
            return wasUpdated;
        }
    }
}
