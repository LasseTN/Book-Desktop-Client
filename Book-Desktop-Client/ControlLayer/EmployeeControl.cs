using Book_Desktop_Client.ControlLayer.Interfaces;
using Book_Desktop_Client.ServiceLayer;
using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;

namespace Book_Desktop_Client.ControlLayer {
    public class EmployeeControl : IEmployeeControl {

        readonly IEmployeeAccess _employeeAccess;

        public EmployeeControl() {
            _employeeAccess = new EmployeeServiceAccess();
        }
        public Task<Employee> CreateNewEmployee(EmployeeControl employeeToCreate) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployees(int id) {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>?> GetAllEmployees() {
            List<Employee>? foundEmployees = null;
            if (_employeeAccess != null) {
                foundEmployees = await _employeeAccess.GetEmployees();
            }
            return foundEmployees;
        }

        public Task<bool> UpdateEmployeeById(int id, Employee update) {
            throw new NotImplementedException();
        }
    }
}
