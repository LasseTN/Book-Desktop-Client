using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.ServiceLayer;
using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ControlLayer {
    public class BookControl : IBookControl {
        readonly IbookAccess _bookAccess;
        public HttpStatusCode CurrentStatusCode { get; set; }

        public BookControl() {
            _bookAccess = new BookServiceAccess();            
        }

        public Task<Book>? CreateNewBook(Book bookToCreate) {
            throw new NotImplementedException();
        }

        public async Task<List<Book>?> GetAllBooks() {
            List<Book>? foundBooks = null;
            if (_bookAccess != null) {
                foundBooks = await _bookAccess.GetAllBooks();
            }
            return foundBooks;

        }

        public Task<Book> UpdateBook(Book bookToUpdate) {
            throw new NotImplementedException();
        }
    }
}
