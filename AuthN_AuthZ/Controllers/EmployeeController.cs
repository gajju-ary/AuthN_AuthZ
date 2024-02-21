using AuthN_AuthZ.Business;
using AuthN_AuthZ.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthN_AuthZ.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Employee model)
        {
            if (ModelState.IsValid)
            {
               var count = _employeeService.AddEmployee(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
