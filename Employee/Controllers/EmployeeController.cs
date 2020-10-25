using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
            => Ok(new List<Employee>
            {
                new Employee {Name = "John Doe"},
                new Employee {Name = "Bruce Wayne"},
                new Employee {Name = "Thomas Anderson"},
            });

        [HttpGet("{id:int}")]
        public ActionResult<Employee> Get(int id)
            => Ok(new Employee { Name = $"#{id} John Doe" });
    }
}
