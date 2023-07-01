using Book_Desktop_Client.ControlLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface IEmployeeAccess {

        Task<Employee?> CreateEmployee(Employee employeeToCreate);
        //Task<Employee?> CreateEmployee(EmployeeControl employeeToCreate);
        Task<bool> DeleteEmployee(int id);
        Task<List<Employee>?> GetEmployees();
        Task<bool> UpdateChosenEmployeeById(int id, Employee update);
    }
}
