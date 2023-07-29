using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Middlewareandpieline.Entension;
using Middlewareandpieline.Middelware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middlewareandpieline
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Tuan dep troai 1");
                next.Invoke();
                await context.Response.WriteAsync("Tuan dep troai 1");
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Tuan dep troai 2");
                next.Invoke();
                await context.Response.WriteAsync("Tuan dep troai 2");
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Tuan dep troai 3");
            });

            app.UseMiddleware<Simple>();
           app.Simple();    // benfolder
            app.UseMvc();

            // Tạo 1 midle were đơn giản
       
        }
        }
        
}
