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

        public Task<Employee?> CreateEmployee(Employee employeeToCreate) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployee(int id) {
            throw new NotImplementedException();
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

        public Task<bool> UpdateChosenEmployee(int id, Employee update) {
            throw new NotImplementedException();
        }
    }
}
