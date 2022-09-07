using Consoletowebapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalsController()

        {
            animals = new List<AnimalModel> {
                new AnimalModel() { Name = "dog", Description = "4 legs", id = 1 },

                new AnimalModel() { Name = "cat", Description = "4 legs" , id =2 },


            };
        }
        [Route("t", Name = "All")]
        public IActionResult GetAnimals()
        {






            return Ok(animals);
        }
        [Route("test")]
        public IActionResult GetAnimalstest()
        {




            return LocalRedirect("~/api/animals/t");
        }
        [Route("{Name}")]
        public IActionResult GetAnimalsByName(string Name)
        {
            if (!Name.Contains("abc"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }
        [Route("{id:int}")]
        public IActionResult GetAnimalsByID(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(animals.FirstOrDefault(x => x.id == id));
        }
        [HttpPost("getanimal")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);
            //return Created("~/api/animals/t" +animal.id , animal);
            //another approch if you dont pass the url
            return CreatedAtAction("GetAnimalsByID", new { id = animal.id }, animal);
        }
        //[Route("testlocalredirect")]
        //public IActionResult GetAnimalstestlocal()
        //{




        //    return LocalRedirect("~/api/animals");
        //}
    }
}
