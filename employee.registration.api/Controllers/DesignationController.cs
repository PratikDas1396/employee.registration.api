using employee.registration.repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace employee.registration.api.Controllers
{
    [Route("api/designations")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly IDataRepository db;
        public DesignationController(IDataRepository db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return Ok(db.Designations.ToList());
        }
    }
}
