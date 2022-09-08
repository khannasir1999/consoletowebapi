using Consoletowebapi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Consoletowebapi
{
    public class CustomBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelname = bindingContext.ModelName; ;
            var value = bindingContext.ValueProvider.GetValue(modelname);
            var result = value.FirstValue;
            if(!int.TryParse(result , out var id))
            {
                return Task.CompletedTask;
            }
            var model = new CountriesModel()
            {

                Id = id,
                Name = "pakistan",
                Area = 200

            };
            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
