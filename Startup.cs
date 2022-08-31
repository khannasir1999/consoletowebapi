using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Consoletowebapi
{
    public class Startup
    {
        public void ConfigureService(IServiceCollection services)
        {
            services.AddControllers();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });
        }

    }
}
