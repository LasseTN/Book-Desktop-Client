using System;
using System.Collections.Generic;
namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface IServiceConnection {

        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }

        public HttpClient HttpEnabler { get; set; }

        Task<HttpResponseMessage?> CallServiceDelete();
        Task<HttpResponseMessage?> CallServiceGet();
        Task<HttpResponseMessage?> CallServicePost(StringContent postJson);
        Task<HttpResponseMessage?> CallServicePost(HttpRequestMessage postRequest);
        Task<HttpResponseMessage?> CallServicePut();
    }
}
