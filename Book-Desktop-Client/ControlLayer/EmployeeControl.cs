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
        public async Task<Employee> CreateNewEmployee(Employee employeeToCreate) {
            Employee? createdEmployee;
            try {
                createdEmployee = await _employeeAccess.CreateEmployee(employeeToCreate);
            } catch (Exception ex) {
                createdEmployee = null;
            }
            return createdEmployee;
        }

        public async Task<bool> DeleteEmployees(int id) {
            bool employeeDeleted = false;
            if (id > 0) {
                employeeDeleted = await _employeeAccess.DeleteEmployee(id);
            }
            return employeeDeleted;
        }

        public async Task<List<Employee>?> GetAllEmployees() {
            List<Employee>? foundEmployees = null;
            if (_employeeAccess != null) {
                foundEmployees = await _employeeAccess.GetEmployees();
            }
            return foundEmployees;
        }

        public async Task<bool> UpdateEmployeeById(int id, Employee update) {
            bool wasUpdated;
            try {
                wasUpdated = await _employeeAccess.UpdateChosenEmployeeById(id, update);
            } catch {
                wasUpdated = false;
            }
            return wasUpdated;
        }
    }
}
