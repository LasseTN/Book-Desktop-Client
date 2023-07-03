using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.ServiceLayer;
using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;

namespace Book_Desktop_Client.ControlLayer {
    public class GenreControl : IGenreControl {

        readonly IGenreAccess _genreServiceAccess;

        public GenreControl() {
            _genreServiceAccess = new GenreServiceAccess();
        }
        public async Task<Genre> CreateNewGenre(Genre genreToCreate) {
            Genre? createdGenre;
            try {
                createdGenre = await _genreServiceAccess.CreateGenre(genreToCreate);
            } catch (Exception ex) {
                createdGenre = null;
            }
            return createdGenre;
        }

        public Task<bool> DeleteGenre(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Genre>?> GetAllGenres() {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateGenreById(int id, Genre update) {
            throw new NotImplementedException();
        }
    }
}
