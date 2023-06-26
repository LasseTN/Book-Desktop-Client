using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface IEmployeeAccess {

        Task<Employee?> CreateEmployee(Employee employeeToCreate);
        Task<bool> DeleteEmployee(int id);
        Task<List<Employee>?> GetEmployees();
        Task<bool> UpdateChosenEmployee(int id, Employee update);
    }
}
