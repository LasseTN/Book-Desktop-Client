using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Book_Desktop_Client.ServiceLayer {
    public class LocationServiceAccess : ILocationAccess {

        readonly IServiceConnection _Connection;
        readonly string _ServiceBaseUrl = "https://localhost:7199/api/Location";

        public LocationServiceAccess() {
            _Connection = new ServiceConnection(_ServiceBaseUrl);
        }
        public async Task<Location?> CreateLocation(Location locationToCreate) {
            Location? foundLocation = null;

            _Connection.UseUrl = _Connection.BaseUrl;

            try {
                var json = JsonConvert.SerializeObject(locationToCreate);
                var postData = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage? response = await _Connection.CallServicePost(postData);

                if (response != null && response.IsSuccessStatusCode) {
                    var content = await response.Content.ReadAsStringAsync();
                    foundLocation = JsonConvert.DeserializeObject<Location>(content);
                }
            } catch (Exception) {
                throw;
            }
            return foundLocation;
        }

        public async Task<bool> DeleteLocation(int id) {
            bool deleteLocation = false;

            _Connection.UseUrl = _Connection.BaseUrl;

            if (id > 0) {
                _Connection.UseUrl += $"/{id}";
            }

            if (_Connection != null) {
                try {
                    var response = await _Connection.CallServiceDelete();
                    if (response != null && response.IsSuccessStatusCode) {
                        deleteLocation = true;
                    } else {
                        deleteLocation = false;
                    }
                } catch {
                    deleteLocation = false;
                }
            }
            return deleteLocation;
        }


        public async Task<List<Location>?> GetAllLocations() {

            List<Location>? locations = null;
            var temp1 = new List<Location>();

            if (_Connection != null) {
                _Connection.UseUrl = _Connection.BaseUrl;

                try {
                    var serviceResponse = await _Connection.CallServiceGet();

                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                        if (serviceResponse.StatusCode == HttpStatusCode.OK) {
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();
                            if (locations == null) {

                                temp1 = JsonConvert.DeserializeObject<List<Location>>(responseData);
                                if (temp1 != null) {
                                    locations = new List<Location>();
                                } else {

                                    if (serviceResponse != null && serviceResponse.StatusCode == HttpStatusCode.NotFound) {
                                        locations = new List<Location>();
                                    }
                                }
                            } else {
                                locations = null;
                            }
                        }
                    }
                } catch (Exception ex) {
                    string notFound = ex.Message;
                    locations = null;
                }
            }
            return temp1;
        }


        public async Task<bool> UpdateChoosenLocationById(int id, Location locationToUpdate) {
            bool updateOk;

            _Connection.UseUrl = _Connection.BaseUrl + $"/{id}";

            try {
                var Json = JsonConvert.SerializeObject(locationToUpdate);
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
