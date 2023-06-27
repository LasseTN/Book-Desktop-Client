using Book_Desktop_Client.ServiceLayer.Interfaces;

namespace Book_Desktop_Client.ServiceLayer {
    public class ServiceConnection : IServiceConnection {
        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }
        public HttpClient HttpEnabler { get; set; }

        public ServiceConnection(string baseUrl) { 

            HttpEnabler = new HttpClient();
            BaseUrl = baseUrl;
            UseUrl = BaseUrl;
        }

        public Task<HttpResponseMessage?> CallServiceDelete() {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage?> CallServiceGet() {
            HttpResponseMessage? httpResponseMessage = null;
            if (UseUrl != null) {
                httpResponseMessage = await HttpEnabler.GetAsync(UseUrl);
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
