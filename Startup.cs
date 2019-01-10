using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace TemperatureDataAPI
{
    public class Startup
    {
        public static string file_path;

        public void ConfigureServices(IServiceCollection services)
        {
            Console.Write("Enter File Path To Read From: ");
            file_path = Console.ReadLine();
            services.AddMvc();
        }

         public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MVC didn't find anything");
            });
        }
    }
}
