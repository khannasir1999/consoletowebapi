using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10)}")] //passing route constraints
        public string GetId(int id)
        {
            return ("hello" + id);
        }

        //[Route("{id}")]
        //[Route("{id:length(5):alpha}")] //pasing alpha constraint
        [Route("{id:regex(a(b|c))}")] //passing regex as a constraint
        public string GetIdstring(string id)
        {
            return ("hello getidby stringggggggggggggggggggggggggggggggggggg" + id);
        }

    }
}
