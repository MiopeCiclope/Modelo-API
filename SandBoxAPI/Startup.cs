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
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SandBoxAPI.Data;
using SandBoxAPI.Services;
using SandBoxAPI.Repositories;
using SandBoxAPI.Interfaces;
using Microsoft.OpenApi.Models;

namespace SandBoxAPI
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
            services.AddControllers().AddNewtonsoftJson();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Indicadores Econômicos",
                        Version = "v1",
                        Description = "Exemplo de API REST criada com o ASP.NET Core 3.0 para consulta a indicadores econômicos",
                        Contact = new OpenApiContact
                        {
                            Name = "Renato Groffe",
                            Url = new Uri("https://github.com/renatogroffe")
                        }
                    });
            });

            services.AddDbContext<SandBoxAPIContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<DbContext, SandBoxAPIContext>();
            services.AddScoped<WeatherRepository>();
            services.AddScoped<WeatherForecastService>();

            services.AddScoped<RegionRepository>();
            services.AddScoped<RegionService>();

            services.AddScoped<CountryRepository>();
            services.AddScoped<CountryService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Indicadores Econômicos V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
