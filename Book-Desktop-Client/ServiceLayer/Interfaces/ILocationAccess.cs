using Model;

namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface ILocationAccess {

        Task<Location?> CreateLocation(Location locationToCreate);
        Task<bool> DeleteLocation(int id);
        Task<List<Location>?> GetAllLocations();
        Task<bool> UpdateChoosenLocationById(int id, Location locationToUpdate);
    }
}
