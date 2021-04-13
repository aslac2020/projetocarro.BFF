using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using projetocarro.BFF.Adapter;
using projetocarro.BFF.Borders.Adapter;
using projetocarro.BFF.Borders.Interfaces;
using projetocarro.BFF.Borders.UseCase;
using projetocarro.BFF.Repositorios;
using projetocarro.BFF.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetocarro.BFF
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
            services.AddScoped<IDeleteCarsUseCase, DeleteCarsUseCase>();
            services.AddScoped<IAddCarsUseCase, AddCarsUseCase>();
            services.AddScoped<IReturnCarsIdUseCase, ReturnCarsIdUseCase>();
            services.AddScoped<IReturnListCarsUseCase, ReturnListCarsUseCase>();
            services.AddScoped<IUpdateCarsUseCase, UpdateCarsUseCase>();

            services.AddScoped<IRepositoriesCars, RepositoriesCars>();

            services.AddScoped<IAddCarsAdapter, AddCarsAdapter>();
            services.AddScoped<IUpdateCarsAdapter, UpdateCarsAdapter>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "projetocarro.BFF", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "projetocarro.BFF v1"));
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
