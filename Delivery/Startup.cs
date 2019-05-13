using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace Delivery
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(c => {  
                c.SwaggerDoc("alexa-netcore", new OpenApiInfo {  
                    Version = "v1",  
                    Title = "Alexa NetCore Template",  
                    Description = "NetCore template project for Amazon Alexa",  
                    Contact = new OpenApiContact() {  
                        Name = "Juan Rodriguez", 
                        Email = "juan.rod707@gmail.com", 
                        Url = new Uri("https://gamecodetips.com/")  
                    }  
                });  
            });  

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/alexa-netcore/swagger.json", "Alexa NetCore Template");
            });

            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}