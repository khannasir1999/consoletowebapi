using Consoletowebapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        //[BindProperty(SupportsGet =true)]
     //public CountriesModel country { get; set; }
        //  [HttpPost("postcountries")]
        //    public IActionResult postcountries()
        //    {
        //        return Ok($"Name = {this.country.Name}," + $"Area = {this.country.Area}");
        //    }

        //[HttpGet("getcountries")]
        //    public IActionResult getcountries()
        //    {
        //        return Ok($"Name = {this.country.Name}," + $"Area = { this.country.Area}");
        //  }
        //pasing the data in url 
        //[HttpGet("{Name}/{Area}")]
        //public IActionResult getdata(string Name , int Area)
        //{
        //    return Ok($"Name = {Name}"   + $"Area = {Area}");

        //}
        //passing the complex data
        //[HttpPost("")]
        //public IActionResult postcountries(CountriesModel country)
        //{
        //    return Ok($"Name = {country.Name}");
        //}
        //custom Model Binder
        //[HttpGet("search")]
        //public IActionResult searchcountry([ModelBinder(typeof(CustomBinder))]string[] mulk)
        //{
        //    return Ok(mulk);
        //}
        //another example of custom model binder ...geting the data from db based on id and then manipulate it
        //custom model binder are used to manipulate data
        [HttpGet("{id}")]
        public IActionResult countryDetails([ModelBinder(Name =  "Id")]CountriesModel countries)
        {
            return Ok(countries);
        }
    }
}
