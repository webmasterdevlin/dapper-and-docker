using DapperAndDocker.Services.Customers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperAndDocker.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repo;
        
        public CustomerController(ICustomerRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get([FromServices] ICustomerRepository service)
        {
            return Ok(service.GetList());
        }
    }
}