using DapperAndDocker.Services.CustomerOrders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperAndDocker.Controllers
{
    [ApiController]
    [Route("api/customer-orders")]
    public class CustomerOrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] ICustomerOrderRepository service)
        {
            return Ok(service.GetList());
        }
    }
}