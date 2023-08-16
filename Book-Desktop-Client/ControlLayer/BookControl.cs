using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.ServiceLayer;
using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using System.Net;


namespace Book_Desktop_Client.ControlLayer {
    public class BookControl : IBookControl {
        readonly IbookAccess _bookAccess;
        public HttpStatusCode CurrentStatusCode { get; set; }

        public BookControl() {
            _bookAccess = new BookServiceAccess();            
        }

        public async Task<Book>? CreateNewBook(Book bookToCreate) {
            Book? createdBook;
            try {
                createdBook = await _bookAccess.CreatedBook(bookToCreate);
            } catch (Exception ex) {
                createdBook = null;
            }
            return createdBook;
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
