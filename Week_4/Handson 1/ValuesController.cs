using FirstWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //simple controller to return a list of employees
    public class ValuesController : ControllerBase
    {
        public string Get()
        {
            return "Returning from EmployeeController Get Method";
        }


    }
}
