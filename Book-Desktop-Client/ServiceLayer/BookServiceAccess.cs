using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Book_Desktop_Client.ServiceLayer {
    public class BookServiceAccess : IbookAccess {
        readonly IServiceConnection _Connection;
        readonly string _ServiceBaseUrl = "https://localhost:7199/api/Book";

        public BookServiceAccess() {
            _Connection = new ServiceConnection(_ServiceBaseUrl);
        }
        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public async Task<Book?> CreatedBook(Book bookToCreate) {
            Book? foundBook = null;

            _Connection.UseUrl = _Connection.BaseUrl;

            try {
                var json = JsonConvert.SerializeObject(bookToCreate);
                var postData = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage? response = await _Connection.CallServicePost(postData);

                if (response != null && response.IsSuccessStatusCode) {
                    var content = await response.Content.ReadAsStringAsync();
                    foundBook = JsonConvert.DeserializeObject<Book>(content);
                }
            } catch (Exception) {
                throw;
            }
            return foundBook;
        }

        public async Task<List<Book>?> GetAllBooks() {
            
            List<Book>? books = null;
            var temp1 = new List<Book>();

            if (_Connection != null) {
                _Connection.UseUrl = _Connection.BaseUrl;

                try {
                    var serviceResponse = await _Connection.CallServiceGet();

                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                        if (serviceResponse.StatusCode == HttpStatusCode.OK) {
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();
                            if (books == null) {

                                temp1 = JsonConvert.DeserializeObject<List<Book>>(responseData);
                                if (temp1 != null) {
                                    books = new List<Book>();
                                } else {

                                    if (serviceResponse != null && serviceResponse.StatusCode == HttpStatusCode.NotFound) {
                                        books = new List<Book>();
                                    }
                                }
                            } else {
                                books = null;
                            }
                        }
                    }
                } catch (Exception ex) {
                    string notFound = ex.Message;
                    books = null;
                }
            }
            return temp1;
        }

        public async Task<bool> UpdatedBook(Book bookToUpdate) {
            bool isUpdated = false;

            _Connection.UseUrl = _Connection.BaseUrl + $"/{bookToUpdate.BookId}";

            if (_Connection != null) {
                try {
                    var json = JsonConvert.SerializeObject(bookToUpdate);
                    var postData = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage? response = await _Connection.CallServicePut(postData);
                    if (response != null && response.IsSuccessStatusCode) {
                        var content = await response.Content.ReadAsStringAsync();
                        isUpdated = true;
                    }
                } catch (Exception) {
                    isUpdated = false;
                }
            }
            return isUpdated;
        }
    }
}
