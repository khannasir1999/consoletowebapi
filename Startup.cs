using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace Consoletowebapi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use 1 -1 \n");
            //    await next();
            //    await context.Response.WriteAsync("hello from use 1 -2 \n");
            //});
            //Method to call customMiddleware
            //app.UseMiddleware<CustomMiddleware1>();
            //run method lgao gy to middlewares execute hongy kiun k app.run() use hi application ko complete krnay k lye hota
            
             //app.Map("/me", customcode);







            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from use 2 -1 \n");

            //    await next();
            //    await context.Response.WriteAsync("hello from use 2 -2 \n");

            //});






            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("request complete \n");
            //    await next.Invoke();
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                
            });
        }

        private void customcode(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Nasir \n");
            });
        }
    }
}
