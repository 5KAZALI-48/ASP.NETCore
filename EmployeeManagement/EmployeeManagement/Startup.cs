using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //First Middleware
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Since we run our project in VS it uses iisexpress in default
            //Second Middleware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from 1st middleware\n");
                await next();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from 2nd middleware");
            });
        }
    }
}
