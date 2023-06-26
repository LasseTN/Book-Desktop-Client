using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface IServiceConnection {

        public string? BaseUrl { get; init; }
        public string? UserUrl { get; set; }

        public HttpClient HttpEnabler { get; set; }

        Task<HttpResponseMessage?> CallServiceDelete();
        Task<HttpResponseMessage?> CallServiceGet();
        Task<HttpResponseMessage?> CallServicePost(StringContent postJson);
        Task<HttpResponseMessage?> CallServicePost(HttpRequestMessage postRequest);
        Task<HttpResponseMessage?> CallServicePut();
    }
}
