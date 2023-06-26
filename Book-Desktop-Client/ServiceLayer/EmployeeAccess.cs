using Book_Desktop_Client.ServiceLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer {
    public class EmployeeAccess : IEmployeeAccess {
        public Task<Employee?> CreateEmployee(Employee employeeToCreate) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployee(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Employee>?> GetEmployees() {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateChosenEmployee(int id, Employee update) {
            throw new NotImplementedException();
        }
    }
}
