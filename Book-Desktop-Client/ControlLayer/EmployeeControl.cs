using Book_Desktop_Client.ControlLayer.Interfaces;
using Model;

namespace Book_Desktop_Client.ControlLayer {
    public class EmployeeControl : IEmployeeControl {
        public Task<Employee> CreateNewEmployee(EmployeeControl employeeToCreate) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployees(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Employee>?> GetAllEmployees() {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmployeeById(int id, Employee update) {
            throw new NotImplementedException();
        }
    }
}
