using DapperAndDocker.Services.Customers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperAndDocker.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] ICustomerRepository service)
        {
            return Ok(service.GetList());
        }
    }
}