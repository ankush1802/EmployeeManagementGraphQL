using EmployeeManagementGraphQL.Data.Models;
using EmployeeManagementGraphQL.Data.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementGraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(EmployeeRepository employeeRepository) : ControllerBase
    {
        private readonly EmployeeRepository _employeeRepository = employeeRepository;
        [HttpGet]
        public IActionResult GetAll()
        {
            var allEmployees = _employeeRepository.GetAllEmployees();
            return Ok(allEmployees);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var book = _employeeRepository.GetEmployeeById(id);
            return Ok(book);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            var addedCourse = _employeeRepository.AddEmployee(employee);
            return Ok(addedCourse);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Employee employee)
        {
            var updatedCourse = _employeeRepository.UpdateEmployee(id, employee);
            return Ok(updatedCourse);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok();
        }
    }
}
