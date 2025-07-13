using FirstWebApi.CustomAuthFilt;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace FirstWebApi.Controllers
{
    [Authorize(Roles = "Admin,POC")]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees =
            new List<Employee> {
            new Employee { id = 1, Name = "John Doe", Salary = 50000, Permanent = true, Department =new Department{id=1,Name="IT"},
                Skills = new List<Skill> {new Skill{id=1,Name="C#" },new Skill{id=3,Name="Java" } } ,DateOfBirth = new DateTime(1990, 1, 1) },
            new Employee { id = 2, Name = "Jane Smith", Salary = 60000, Permanent = false, Department = new Department{id=2,Name="HR"},
                Skills = new List<Skill> {new Skill{id=2,Name="Python"} }, DateOfBirth = new DateTime(1985, 5, 15) },
            new Employee
                {
                    id = 3,
                    Name = "Mohamed Gows",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { id = 1, Name = "IT" },
                    Skills = new List<Skill> { new Skill { id = 1, Name = "C#" } },
                    DateOfBirth = new DateTime(1990, 5, 12)
                }
        };

        

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(employees);
        }

        
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var emp = employees.FirstOrDefault(e => e.id == id);
            if (emp == null)
                return BadRequest("Invalid employee id");

            emp.Name = updatedEmp.Name;
            emp.Salary = updatedEmp.Salary;
            emp.Permanent = updatedEmp.Permanent;
            emp.Department = updatedEmp.Department;
            emp.Skills = updatedEmp.Skills;
            emp.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(emp);
        }
    }
}
