using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middlewareandpieline.Middelware
{
    public class Simple
    {
        private readonly RequestDelegate _next;
        public Simple(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("Tuan dep troai 3");
            await context.Response.WriteAsync("Tuan dep troai 3");
            await context.Response.WriteAsync("Tuan dep troai 3");
        }
    }
}
