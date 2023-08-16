using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer {
    public class BookServiceAccess : IbookAccess {
        readonly IServiceConnection _Connection;
        readonly string _ServiceBaseUrl = "https://localhost:7199/api/Book";

        public BookServiceAccess() {
            _Connection = new ServiceConnection(_ServiceBaseUrl);
        }
        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public Task<Book?> CreatedBook(Book bookToCreate) {
            throw new NotImplementedException();
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

        public Task<Book?> UpdatedBook(Book bookToUpdate) {
            throw new NotImplementedException();
        }
    }
}
