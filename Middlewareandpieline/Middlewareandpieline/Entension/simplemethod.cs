using Microsoft.AspNetCore.Builder;

namespace Middlewareandpieline.Entension
{
    public static class simplemethod
    {


       public static IApplicationBuilder Simple (this IApplicationBuilder buider)
        {
            return buider.UseMiddleware<IApplicationBuilder>();
        }

    }
}
