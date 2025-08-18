using Guispin.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Guispin.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PingController : Controller
    {
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            Player player = new Player();
            player.Level = 100;
            player.Name = "Rod";

            return Ok(new { Message = player });
        }
    }
}
