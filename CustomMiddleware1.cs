namespace Consoletowebapi
{
    public class CustomMiddleware1 : IMiddleware
    {
       
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("hello from New File 2 -1 \n");

            await next(context);
            await context.Response.WriteAsync("hello from New File 2 -2 \n");

        }
    }
}
