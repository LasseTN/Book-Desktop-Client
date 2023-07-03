﻿using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer {
    public class GenreServiceAccess : IGenreAccess {

        readonly IServiceConnection _Connection;
        readonly string _ServiceBaseUrl = "https://localhost:7199/api/Genre";

        public GenreServiceAccess() {
            _Connection = new ServiceConnection(_ServiceBaseUrl);
        }

        public async Task<Genre?> CreateGenre(Genre genreToCreate) {
            Genre? foundGenre = null;

            _Connection.UseUrl = _Connection.BaseUrl;

            try {
                var json = JsonConvert.SerializeObject(genreToCreate);
                var postData = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage? response = await _Connection.CallServicePost(postData);

                if (response != null && response.IsSuccessStatusCode) {
                    var content = await response.Content.ReadAsStringAsync();
                    foundGenre = JsonConvert.DeserializeObject<Genre>(content);
                }
            } catch (Exception) {
                throw;
            }
            return foundGenre;
        }

        public Task<bool> DeleteGenre(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Genre>?> GetAllGenres() {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateChoosenGenreById(int id, Genre genreToUpdate) {
            throw new NotImplementedException();
        }
    }
}
