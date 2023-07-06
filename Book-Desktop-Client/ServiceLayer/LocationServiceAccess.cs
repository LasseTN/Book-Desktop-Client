using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;


namespace Book_Desktop_Client.ServiceLayer {
    public class LocationServiceAccess : ILocationAccess {

        readonly IServiceConnection _connection;
        readonly string _ServiceBaseUrl = "https://localhost:7199/api/Location";

        public LocationServiceAccess() {
            _connection = new ServiceConnection(_ServiceBaseUrl);
        }
        public Task<Location?> CreateLocation(Location locationToCreate) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLocation(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Location>?> GetAllLocations() {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateChoosenLocationById(int id, Location locationToUpdate) {
            throw new NotImplementedException();
        }
    }
}
