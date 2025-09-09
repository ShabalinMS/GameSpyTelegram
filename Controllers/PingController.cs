using Microsoft.AspNetCore.Mvc;

namespace GameSpyTelegram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {

        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Ping")]
        public string Get()
        {
            return "Pong";
        }
    }
}