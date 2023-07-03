using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ControlLayer {
    public class GenreControl : IGenreControl {
        public Task<Genre> CreateNewGenre(Genre genreToCreate) {
            throw new NotImplementedException();
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
