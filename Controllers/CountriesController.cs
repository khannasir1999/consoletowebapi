using Consoletowebapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [BindProperty(SupportsGet =true)]
      public CountriesModel country { get; set; }
        [HttpPost("postcountries")]
        public IActionResult postcountries()
        {
            return Ok($"Name = {this.country.Name}," + $"Area = {this.country.Area}");
        }
        
    [HttpGet("getcountries")]
        public IActionResult getcountries()
        {
            return Ok($"Name = {this.country.Name}," + $"Area = { this.country.Area}");
        }
    }
}
