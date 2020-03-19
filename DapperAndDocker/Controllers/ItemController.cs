using DapperAndDocker.Services.Items;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperAndDocker.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IItemRepository service)
        {
            return Ok(service.GetList());
        }
    }
}