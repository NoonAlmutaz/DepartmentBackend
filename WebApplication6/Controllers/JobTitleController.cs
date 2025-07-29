using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models.Data;

namespace WebApplication6.Controllers
{     
    [Route("api/[controller]")]
        [ApiController] 
    public class JobTitleController : ControllerBase
    {
        private readonly AppDB DbContext;
        public JobTitleController(AppDB DbContext)
        {
            this.DbContext = DbContext;
        }


        [HttpGet]

        public IActionResult GetAllJobTitles()
        {
            var AllJobTitles = DbContext.JobTitle.ToList();
            return Ok(AllJobTitles);
        }





    }
}

