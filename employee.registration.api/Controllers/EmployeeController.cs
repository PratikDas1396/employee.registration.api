using employee.registration.repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace employee.registration.api.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository db;
        public EmployeeController(IDataRepository db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return Ok(db.Employees.ToList());
        }
    }
}
