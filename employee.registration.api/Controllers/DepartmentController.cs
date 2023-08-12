using employee.registration.repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace employee.registration.api.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDataRepository db;

        public DepartmentController(IDataRepository db) {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return Ok(db.Departments.ToList());
        }
    }
}
