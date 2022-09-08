using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Models
{
    //we have to pass the type of modelbinder here also
    [ModelBinder(typeof(CustomBinderCountryDetails))] //hamesha class definition se pehly ata
    public class CountriesModel
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
    }
}
