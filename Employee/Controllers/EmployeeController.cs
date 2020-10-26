using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employee.Controllers
{
    [Route("api/")]
    [ApiController]
    [Produces("application/json")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
            => _logger = logger;

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            _logger.LogInformation($"GET / - {nameof(EmployeeController)}");

            return Ok(new List<Employee>
            {
                new Employee {Name = "John Doe"},
                new Employee {Name = "Bruce Wayne"},
                new Employee {Name = "Thomas Anderson"},
            });
        }

        [HttpGet("{id:int}")]
        public ActionResult<Employee> Get(int id)
        {
            _logger.LogInformation($"GET /{id} - {nameof(EmployeeController)}");

            return Ok(new Employee {Name = $"#{id} John Doe"});
        }
    }
}
