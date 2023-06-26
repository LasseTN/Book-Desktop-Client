using Book_Desktop_Client.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer {
    public class ServiceConnection : IServiceConnection {
        public string? BaseUrl { get; init; }
        public string? UserUrl { get; set; }
        public HttpClient HttpEnabler { get; set; }

        public ServiceConnection(string baseUrl) { 
            HttpEnabler = new HttpClient();
            BaseUrl = baseUrl;
            UserUrl = BaseUrl;
        }

        public Task<HttpResponseMessage?> CallServiceDelete() {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage?> CallServiceGet() {
            HttpResponseMessage? httpResponseMessage = null;
            if (UserUrl != null) {
                httpResponseMessage = await HttpEnabler.GetAsync(UserUrl);
            }
            return httpResponseMessage;
        }

        public Task<HttpResponseMessage?> CallServicePost(StringContent postJson) {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage?> CallServicePost(HttpRequestMessage postRequest) {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage?> CallServicePut() {
            throw new NotImplementedException();
        }
    }
}
