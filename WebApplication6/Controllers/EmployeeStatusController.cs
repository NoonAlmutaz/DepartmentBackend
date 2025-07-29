using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;
using WebApplication6.Models.Data;
namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeStatusController : ControllerBase
    {

        private readonly AppDB DbContext;

        public EmployeeStatusController(AppDB DbContext)
        {
            this.DbContext = DbContext;
        }

        [HttpGet]

        public IActionResult GetAllStatus()
        {
            var AllStatus = DbContext.EmployeeStatus.ToList();
            return Ok(AllStatus);
        }



    }
}
