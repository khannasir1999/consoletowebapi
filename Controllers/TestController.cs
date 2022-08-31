using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController: ControllerBase
    {
        public string Get()
        {
            return ("Hello from Get");
        }
    }
}
