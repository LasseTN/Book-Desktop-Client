using Model;

namespace Book_Desktop_Client.ControlLayer.Interfaces {
    public interface IEmployeeControl {

        Task<Employee> CreateNewEmployee(Employee employeeToCreate);
        Task<List<Employee>?> GetAllEmployees();
        Task<bool> DeleteEmployees(int id);
        Task<bool> UpdateEmployeeById(int id, Employee update);
    }
}
