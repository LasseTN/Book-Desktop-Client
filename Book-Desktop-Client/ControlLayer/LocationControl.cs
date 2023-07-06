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

        public Task<Location> CreateNewLocation(Location locationToCreate) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLocation(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Location>?> GetAllLocation() {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateLocationById(int id, Location update) {
            throw new NotImplementedException();
        }
    }
}
