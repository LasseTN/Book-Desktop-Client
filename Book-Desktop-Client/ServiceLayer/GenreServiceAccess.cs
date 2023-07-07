using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using Newtonsoft.Json;
using System.Net;
using System.Text;

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

        public async Task<bool> DeleteGenre(int id) {
            bool deleteGenre = false;

            _Connection.UseUrl = _Connection.BaseUrl;

            if (id > 0) {
                _Connection.UseUrl += $"/{id}";
            }

            if (_Connection != null) {
                try {
                    var response = await _Connection.CallServiceDelete();
                    if (response != null && response.IsSuccessStatusCode) {
                        deleteGenre = true;
                    } else {
                        deleteGenre = false;
                    }
                } catch {
                    deleteGenre = false;
                }
            }
            return deleteGenre;
        }

        public async Task<List<Genre>?> GetAllGenres() {

            List<Genre>? genres = null;
            var temp1 = new List<Genre>();

            if (_Connection != null) {
                _Connection.UseUrl = _Connection.BaseUrl;

                try {
                    var serviceResponse = await _Connection.CallServiceGet();

                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                        if (serviceResponse.StatusCode == HttpStatusCode.OK) {
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();
                            if (genres == null) {

                                temp1 = JsonConvert.DeserializeObject<List<Genre>>(responseData);
                                if (temp1 != null) {
                                    genres = new List<Genre>();
                                } else {

                                    if (serviceResponse != null && serviceResponse.StatusCode == HttpStatusCode.NotFound) {
                                        genres = new List<Genre>();
                                    }
                                }
                            } else {
                                genres = null;
                            }
                        }
                    }
                } catch (Exception ex) {
                    string notFound = ex.Message;
                    genres = null;
                }
            }
            return temp1;
        }

        public async Task<bool> UpdateChoosenGenreById(int id, Genre genreToUpdate) {
            bool updateOk;

            _Connection.UseUrl = _Connection.BaseUrl + $"/{id}";

            try {
                var Json = JsonConvert.SerializeObject(genreToUpdate);
                var postData = new StringContent(Json, Encoding.UTF8, "application/json");

                HttpResponseMessage? response = await _Connection.CallServicePut(postData);
                if (response != null && response.IsSuccessStatusCode) {
                    updateOk = true;
                } else {
                    updateOk = false;
                }
            } catch {
                updateOk = false;
            }
            return updateOk;
        }
    }
}
