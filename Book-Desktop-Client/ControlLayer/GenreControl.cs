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

        public async Task<List<Genre>?> GetAllGenres() {
            List<Genre>? foundGenres = null;
            if (_genreServiceAccess != null) {
                foundGenres = await _genreServiceAccess.GetAllGenres();
            }
            return foundGenres;
        }

        public Task<bool> UpdateGenreById(int id, Genre update) {
            throw new NotImplementedException();
        }
    }
}
