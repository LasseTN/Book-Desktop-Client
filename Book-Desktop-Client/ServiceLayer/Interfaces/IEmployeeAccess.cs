using Book_Desktop_Client.ControlLayer;
using Model;


namespace Book_Desktop_Client.ServiceLayer.Interfaces {
    public interface IEmployeeAccess {

        Task<Employee?> CreateEmployee(Employee employeeToCreate);
        Task<bool> DeleteEmployee(int id);
        Task<List<Employee>?> GetEmployees();
        Task<bool> UpdateChosenEmployeeById(int id, Employee update);
    }
}
