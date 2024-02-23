using AuthN_AuthZ.Models;

namespace AuthN_AuthZ.Business
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee model);
    }
}
