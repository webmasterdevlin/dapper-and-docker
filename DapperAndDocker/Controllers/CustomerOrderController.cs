using DapperAndDocker.Services.CustomerOrders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperAndDocker.Controllers
{
    [ApiController]
    [Route("api/customer-orders")]
    public class CustomerOrderController : ControllerBase
    {
        private readonly ICustomerOrderRepository _repo;
        
        public CustomerOrderController(ICustomerOrderRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_repo.GetList());
        }
    }
}