using Model;

namespace Book_Desktop_Client.ControlLayer.Interfaces {
    public interface IGenreControl {

        Task<Genre> CreateNewGenre(Genre genreToCreate);
        Task<List<Genre>?> GetAllGenres();
        Task<bool> DeleteGenre(int id);
        Task<bool> UpdateGenreById(int id, Genre update);
    }
}
