using AuthN_AuthZ.Models;

namespace AuthN_AuthZ.Business
{
    public class EmployeeService
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>()
           {
               new Employee() {
               Id =1,
               FirstName = "Gajendra",
               LastName = "Pawar",
               Email = "gajendra@gmail.com",
               Address = "Bhopal"
               },
               new Employee() {
                   Id =2,
               FirstName = "Ankur",
               LastName = "Sahu",
               Email = "Ankur@gmail.com",
               Address = "Bhopal"}
           };

            return employees;
        }

        public void AddEmployee(Employee model)
        {
           
        }
    }
}
