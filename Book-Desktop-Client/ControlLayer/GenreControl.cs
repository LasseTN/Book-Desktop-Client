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

        public async Task<bool> DeleteGenre(int id) {
            bool wasDeleted = false;
            if (id > 0) { 
                wasDeleted = await _genreServiceAccess.DeleteGenre(id);
            }
            return wasDeleted;
        }

        public async Task<List<Genre>?> GetAllGenres() {
            List<Genre>? foundGenres = null;
            if (_genreServiceAccess != null) {
                foundGenres = await _genreServiceAccess.GetAllGenres();
            }
            return foundGenres;
        }

        public async Task<bool> UpdateGenreById(int id, Genre update) {
            bool wasUpdated;
            try {
                wasUpdated = await _genreServiceAccess.UpdateChoosenGenreById(id, update);
            } catch {
                wasUpdated = false;
            }
            return wasUpdated;
        }
    }
}
