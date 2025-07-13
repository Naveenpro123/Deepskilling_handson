using FirstWebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Valuecontroller : ControllerBase
    {
        // GET: api/<Valuecontroller>
        private readonly List<Employee> _employees = new List<Employee>
        {
            new Employee { id = 1, firstName = "John", Role = "Developer" },
            new Employee { id = 2, firstName = "Jane", Role = "Manager" }
        };
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_employees);
        }

        // GET api/<Valuecontroller>/5
        [HttpGet("{id}")]
        public ActionResult Getbyid(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);

        }
    }
}
