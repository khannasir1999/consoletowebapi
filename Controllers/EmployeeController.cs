using Consoletowebapi.Models;
using Consoletowebapi.Repository_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel(){Id= 1 , Name = "abc"},
                new EmployeeModel() {Id=2 , Name = "def"}

            };

        }
        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>(){
                new EmployeeModel(){Id= 1 , Name = "abc"},
                new EmployeeModel() {Id=2 , Name = "def"},
                new EmployeeModel() {Id=3 , Name = "def"}

            }
            );
                
        }
        [Route("{id}/basics")]
        public ActionResult <EmployeeModel> GetEmployeesDetails(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 1, Name = "abc" };
            
        }
        //resolving the dependency directly in action method
        [HttpGet("name")]
        public IActionResult GetName([FromServices] IproductRepository _productRepository)
        {

            var name = _productRepository.GetName();

            return Ok(name);

        }

    }
}
