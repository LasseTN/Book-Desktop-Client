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

        // This method retrieves a list of all books.
        public async Task<List<Book>?> GetAllBooks() {

            // Initialize a nullable list for holding the books to be returned.
            List<Book>? books = null;

            // Temporary list to hold deserialized books.
            var temp1 = new List<Book>();

            // Check if the _Connection object is not null.
            if (_Connection != null) {

                // Set the URL to use for the service call.
                _Connection.UseUrl = _Connection.BaseUrl;

                try {

                    // Make an asynchronous GET call to the service and store the response.
                    var serviceResponse = await _Connection.CallServiceGet();

                    // Check if the service response is not null and successful.
                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {

                        // Check if the status code is OK (200).
                        if (serviceResponse.StatusCode == HttpStatusCode.OK) {

                            // Read the content of the service response as a string.
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();

                            // Check if the books list has been initialized.
                            if (books == null) {

                                // Deserialize the JSON response to a List<Book> object.
                                temp1 = JsonConvert.DeserializeObject<List<Book>>(responseData);

                                // Initialize books list if temp1 is not null.
                                if (temp1 != null) {
                                    books = new List<Book>();
                                } else {

                                    // Initialize an empty books list if the status code is NotFound (404).
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

                    // Store the exception message and set books to null in case of an error.
                    string notFound = ex.Message;
                    books = null;
                }
            }

            // Return the temporary list of books.
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
