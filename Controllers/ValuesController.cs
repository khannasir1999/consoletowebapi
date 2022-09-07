using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    
    [ApiController]
    //set the base route at controller level
    [Route("[action]/[controller]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/api/getall")] //to give a Route its own identity other than base routes
        //[Route("get-all")]
        //[Route("get-this")]
      
        public string GetAll()
        {
            return "hello from get all";
        }
        //[Route("api/get-all-authors")]
        
        //[Route("get-all")] --single url cannot have multiple resource
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }
        //[Route("api/{id}")]
        //we have to pass id as dynamic value
        [Route("{id}")]
        public string GetId(int id)
        {
            return ("hello" + id);
        }
        //[Route("api/{id}/author/{authorid}")]
       
      
        public string Getauthoraddress(int id, int authorid)
        {
            return "hell author" + id + " " + authorid;
        }
        //[Route("search")]
        public string SearchBooks(int id , string name , int price , string author)
        {
            return ("hello Searchbooks" + id + name + price + author);
        }
    }
}
