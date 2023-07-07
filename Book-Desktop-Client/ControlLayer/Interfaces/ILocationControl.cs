using Model;

namespace Book_Desktop_Client.ControlLayer.Interfaces {
    public interface ILocationControl {

        Task<Location> CreateNewLocation(Location locationToCreate);
        Task<List<Location>?> GetAllLocations();
        Task<bool> DeleteLocation(int id);
        Task<bool> UpdateLocationById(int id, Location update);
    }
}
