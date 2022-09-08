
//customBinder Class
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Consoletowebapi
{
    public class CustomBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var data = bindingContext.HttpContext.Request.Query;
            var result = data.TryGetValue("mulk", out var country);
            if (result)
            {
                var array =country.ToString().Split("|");
                bindingContext.Result = ModelBindingResult.Success(array);
            }
            return Task.CompletedTask;
        }
    }
}
