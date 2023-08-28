using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ControlLayer.Interfaces {
    public interface IBookControl {

        public HttpStatusCode CurrentStatusCode { get; set; }
        Task<Book>? CreateNewBook(Book bookToCreate);
        Task<List<Book>?> GetAllBooks();
        Task<bool> UpdateBook(Book bookToUpdate);
    }
}
