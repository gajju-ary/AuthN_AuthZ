using AuthN_AuthZ.Models;

namespace AuthN_AuthZ.Business
{
    public class EmployeeService: IEmployeeService
    {
        List<Employee> _employees = new List<Employee>()
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
               FirstName = "ABC",
               LastName = "XYZ",
               Email = "abc@gmail.com",
               Address = "Bhopal"}
           };

        public List<Employee> GetAllEmployees()
        {
            return _employees.ToList();
        }

        public void AddEmployee(Employee model)
        {
           _employees.Add(model); //store in List
           
        }
    }
}
