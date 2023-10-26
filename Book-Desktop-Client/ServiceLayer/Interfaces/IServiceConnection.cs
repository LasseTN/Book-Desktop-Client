using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer.Interfaces {

    public interface IServiceConnection {

        // Gets or initializes the base URL for the service.
        public string? BaseUrl { get; init; }

        // Gets or sets the URL to use for specific service calls.
        public string? UseUrl { get; set; }

        // Gets or sets the HttpClient used to make HTTP requests.
        public HttpClient HttpEnabler { get; set; }

        // Method for making a DELETE request to a service. 
        // Returns a HttpResponseMessage or null.
        Task<HttpResponseMessage?> CallServiceDelete();

        // Method for making a GET request to a service. 
        // Returns a HttpResponseMessage or null.
        Task<HttpResponseMessage?> CallServiceGet();

        // Method for making a POST request to a service with JSON payload.
        // Takes in a StringContent object that contains the JSON.
        // Returns a HttpResponseMessage or null.
        Task<HttpResponseMessage?> CallServicePost(StringContent postJson);

        // Alternate method for making a POST request to a service.
        // Takes in a HttpRequestMessage object that contains the request details.
        // Returns a HttpResponseMessage or null.
        Task<HttpResponseMessage?> CallServicePost(HttpRequestMessage postRequest);

        // Method for making a PUT request to a service with JSON payload.
        // Takes in a StringContent object that contains the JSON.
        // Returns a HttpResponseMessage or null.
        Task<HttpResponseMessage?> CallServicePut(StringContent putJson);
    }
}
