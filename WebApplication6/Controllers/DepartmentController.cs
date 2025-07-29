using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models.Data;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly AppDB DbContext;

        public DepartmentController(AppDB DbContext)
        {
            this.DbContext = DbContext;
        }
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var AllDepartments = DbContext.Department.ToList();
            return Ok(AllDepartments);
        }
    }
}
