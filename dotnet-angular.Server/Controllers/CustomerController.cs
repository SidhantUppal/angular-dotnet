using dotnet_angular.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_angular.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        public CustomerController(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public IActionResult FetchCustomerWithData()
        {
            try
            {
                var result = dbContext.customers.Join(dbContext.paymentMethods, c => c.Id, p => p.CustomerId, (c, p) => new { c, p })
                      .Join(dbContext.testimonials, temp => temp.c.Id, t => t.CustomerId, (temp, t) => new { temp, t })
                      .Select(r => new CustomerWithDetails
                      {
                          Customer = r.temp.c,
                          PaymentMethods = r.temp.c.PaymentMethods.ToList(),
                          Testimonials = r.temp.c.Testimonials.ToList(),
                      }).ToList();

                var response = new { data = result, Message = "Data Returned" };
                return Ok(response);

            }
            catch (Exception ex)
            {
                var response = new { data = new List<CustomerWithDetails>(), Message = "Some Error Occured" };
                return StatusCode(500, response);
            }
        }
    }
}
