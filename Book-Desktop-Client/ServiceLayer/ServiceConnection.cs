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

        // Defines a method that initiates a GET request to the API.
        public async Task<HttpResponseMessage?> CallServiceGet() {

            // Initializes a nullable HttpResponseMessage object to hold the response from the API.
            HttpResponseMessage? httpResponseMessage = null;

            // Checks if UseUrl is set, meaning there is a specific URL to use for this GET request.
            if (UseUrl != null) {

                // Makes the actual asynchronous GET request to the service using the HttpClient (HttpEnabler).
                // Assigns the received HttpResponseMessage to httpResponseMessage.
                httpResponseMessage = await HttpEnabler.GetAsync(UseUrl);
            }

            // Returns the HttpResponseMessage or null if the GET request could not be made.
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



