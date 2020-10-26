using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Company.Controllers
{
    [Route("api/")]
    [ApiController]
    [Produces("application/json")]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger _logger;

        public CompanyController(ILogger<CompanyController> logger)
            => _logger = logger;

        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            _logger.LogInformation($"GET / - {nameof(CompanyController)}");

            return Ok(new List<Company>
            {
                new Company {Name = "Google"},
                new Company {Name = "Amazon"},
                new Company {Name = "Facebook"},
                new Company {Name = "Apple"},
                new Company {Name = "Microsoft"},
            });
        }

        [HttpGet("{id:int}")]
        public ActionResult<Company> Get(int id)
        {
            _logger.LogInformation($"GET /{id} - {nameof(CompanyController)}");

            return Ok(new Company { Name = $"#{id} Google" });
        }
    }
}
