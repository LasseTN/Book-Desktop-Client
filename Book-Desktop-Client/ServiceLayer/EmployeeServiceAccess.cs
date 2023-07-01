using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using Newtonsoft.Json;
using System.Net;
using System.Text;


namespace Book_Desktop_Client.ServiceLayer {
    public class EmployeeServiceAccess : IEmployeeAccess {

        readonly IServiceConnection _Connection;
        readonly string _ServiceBaseUrl = "https://localhost:7199/api/Employee";

        public EmployeeServiceAccess() {
            _Connection = new ServiceConnection(_ServiceBaseUrl);

        }

        public async Task<Employee?> CreateEmployee(Employee employeeToCreate) {
            Employee? foundEmployee = null;

            _Connection.UseUrl = _Connection.BaseUrl;

            try {
                var json = JsonConvert.SerializeObject(employeeToCreate);
                var postData = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage? response = await _Connection.CallServicePost(postData);

                if (response != null && response.IsSuccessStatusCode) {
                    var content = await response.Content.ReadAsStringAsync();
                    foundEmployee = JsonConvert.DeserializeObject<Employee>(content);
                }
            } catch (Exception) {
                throw;
            }
            return foundEmployee;
        }

        public async Task<bool> DeleteEmployee(int id) {
            bool deleteEmployee = false;

            _Connection.UseUrl = _Connection.BaseUrl;

            if (id > 0) {
                _Connection.UseUrl += $"/{id}";
            }

            if (_Connection != null) {
                try {
                    var response = await _Connection.CallServiceDelete();
                    if (response != null && response.IsSuccessStatusCode) {
                        deleteEmployee = true;
                    } else {
                        deleteEmployee = false;
                    }
                } catch {
                    deleteEmployee= false;
                }
            }
            return deleteEmployee;
        }

        public async Task<List<Employee>?> GetEmployees() {
            
            List<Employee>? employees = null;
            var temp1 = new List<Employee>();

            if (_Connection != null) {
                _Connection.UseUrl = _Connection.BaseUrl;

                try {
                    var serviceResponse = await _Connection.CallServiceGet();
                    
                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                        if (serviceResponse.StatusCode == HttpStatusCode.OK) {
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();
                            if (employees == null) {

                                temp1 = JsonConvert.DeserializeObject<List<Employee>>(responseData);
                                if (temp1 != null) {
                                    employees = new List<Employee>();
                                } else {

                                    if (serviceResponse != null && serviceResponse.StatusCode == HttpStatusCode.NotFound) {
                                        employees = new List<Employee>();
                                    }
                                }
                            } else {
                                employees = null;
                            }
                        }
                    }
                } catch (Exception ex) {
                    string notFound = ex.Message;
                    employees = null;
                }
            }
            return temp1;
        }

        public async Task<bool> UpdateChosenEmployeeById(int id, Employee update) {
            bool updateOk;

            _Connection.UseUrl = _Connection.BaseUrl + $"/{id}";

            try {
                var Json = JsonConvert.SerializeObject(update);
                var postData = new StringContent(Json, Encoding.UTF8, "application/json");

                HttpResponseMessage? response = await _Connection.CallServicePut(postData);
                if (response != null && response.IsSuccessStatusCode) {
                    updateOk = true;
                } else {
                    updateOk = false;
                }
            } catch  {
                updateOk = false;
            }
            return updateOk;
        }
    }
}
