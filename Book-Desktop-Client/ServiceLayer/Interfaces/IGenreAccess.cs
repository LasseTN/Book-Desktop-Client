using Model;

namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface IGenreAccess {

        Task<Genre?> CreateGenre(Genre genreToCreate);
        Task<bool> DeleteGenre(int id);
        Task<List<Genre>?> GetAllGenres();
        Task<bool> UpdateChoosenGenreById(int id, Genre genreToUpdate);
    }
}
