using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer {
    public class EmployeeServiceAccess : IEmployeeAccess {

        readonly IServiceConnection _Connection;
        readonly String _ServiceBaseUrl = "https://localhost:7199/api/Employees";

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
                _Connection.UserUrl = _Connection.BaseUrl;

                try {
                    var serviceResponse = await _Connection.CallServiceGet();
                    
                    if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                        if (serviceResponse.StatusCode == System.Net.HttpStatusCode.OK) {
                            var responseData = await serviceResponse!.Content.ReadAsStringAsync();
                            if (employees == null) {

                                temp1 = JsonConvert.DeserializeObject<List<Employee>>(responseData);
                                if (temp1 != null) {
                                    employees = new List<Employee>();
                                } else {

                                    if (serviceResponse != null && serviceResponse.StatusCode == System.Net.HttpStatusCode.NotFound) {
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
