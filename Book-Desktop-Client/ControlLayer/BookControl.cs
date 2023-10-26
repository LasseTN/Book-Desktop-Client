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

        // This method fetches a list of all books.
        public async Task<List<Book>?> GetAllBooks() {

            // Initialize a nullable List to hold the books that are found.
            List<Book>? foundBooks = null;

            // Check if the _bookAccess object is not null before making the API call.
            if (_bookAccess != null) {

                // Await the GetAllBooks method from the _bookAccess object, which fetches books from a API and database.
                foundBooks = await _bookAccess.GetAllBooks();
            }

            // Return the list of found books. This could be null if _bookAccess is null or if the GetAllBooks call fails.
            return foundBooks;
        }


        public async Task<bool> UpdateBook(Book bookToUpdate) {
            bool isUpdated = false;

            try {
                isUpdated = await _bookAccess.UpdatedBook(bookToUpdate);
            } catch (Exception) {
                isUpdated = false;
            }
            return isUpdated;
        }

    }
}
