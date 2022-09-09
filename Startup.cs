using Consoletowebapi.Repository_Layer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Consoletowebapi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();
            //in addsingleton one instance is shared along the application no mater how muc http requests come however previous data is destroyed if application 
            //restarts
            //services.AddSingleton<IproductRepository , productRepository>();
            //in AddScoped a new instance is created for every new http requests hence previous data is lost on every http request
            //services.AddScoped<IproductRepository, productRepository>();
            //AddTransieent a new instance is created for every http request such that now sharing of instances is done as in AddScoped<>

            //services.AddTransient<IproductRepository , TestRepository>();
            //services.AddTransient<IproductRepository, productRepository>();
            //by using try method you can remove the problem of overriden as without try the new service will override previous
            //if we are using same interface for different repositories.

            services.TryAddTransient<IproductRepository , TestRepository>();
            services.TryAddTransient<IproductRepository, productRepository>();

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
