using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface IbookAccess {
        HttpStatusCode CurrentHttpStatusCode { get; set; }
        Task<Book?> CreatedBook(Book bookToCreate);
        Task<List<Book>?> GetAllBooks();
        Task<bool> UpdatedBook(Book bookToUpdate);

    }
}
