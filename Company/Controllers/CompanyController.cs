using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
            => Ok(new List<Company>
            {
                new Company {Name = "Google"},
                new Company {Name = "Amazon"},
                new Company {Name = "Facebook"},
                new Company {Name = "Apple"},
                new Company {Name = "Microsoft"},
            });

        [HttpGet("{id:int}")]
        public ActionResult<Company> Get(int id)
            => Ok(new Company {Name = $"#{id} Google" });
    }
}
