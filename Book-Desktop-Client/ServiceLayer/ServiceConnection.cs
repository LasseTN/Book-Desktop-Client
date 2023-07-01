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

        public async Task<HttpResponseMessage?> CallServiceDelete() {
            HttpResponseMessage? httpResponseMessage = null;
            if (UseUrl != null) {
                httpResponseMessage = await HttpEnabler.DeleteAsync(UseUrl);
            }
            return httpResponseMessage;
        }

        public async Task<HttpResponseMessage?> CallServiceGet() {
            HttpResponseMessage? httpResponseMessage = null;
            if (UseUrl != null) {
                httpResponseMessage = await HttpEnabler.GetAsync(UseUrl);
            }
            return httpResponseMessage;
        }

        public async Task<HttpResponseMessage?> CallServicePost(StringContent postJson) {
            HttpResponseMessage? httpResponseMessage = null;
            if (UseUrl != null) {
                httpResponseMessage = await HttpEnabler.PostAsync(UseUrl, postJson);
            }
            return httpResponseMessage;
        }

        public Task<HttpResponseMessage?> CallServicePost(HttpRequestMessage postRequest) {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage?> CallServicePut(StringContent putJson) {
            HttpResponseMessage? httpResponseMessage = null;
            if (UseUrl != null) {
                httpResponseMessage = await HttpEnabler.PutAsync(UseUrl, putJson);
            }
            return httpResponseMessage;
        }
    }
}
