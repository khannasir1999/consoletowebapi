using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TestController: ControllerBase
    {
        [Route("t")]
        public string Get()
        {
            return ("Hello from Get in test class");
        }
    }
}
