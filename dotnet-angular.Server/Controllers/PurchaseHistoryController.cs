using dotnet_angular.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_angular.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseHistoryController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public PurchaseHistoryController(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = dbContext.PurchaseHistories.ToList();
                var response = new { data = result, Message = "data returned" };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new { data = new List<PurchaseHistory>(), Message = "Some Error Occured" };
                return StatusCode(500, response);
            }
        }
    }
}
