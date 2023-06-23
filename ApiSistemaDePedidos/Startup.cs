using ApiSistemaDePedidos.Context;
using ApiSistemaDePedidos.Repositorys;
using ApiSistemaDePedidos.Repositorys.Interfaces;
using ApiSistemaDePedidos.Services;
using ApiSistemaDePedidos.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace ApiSistemaDePedidos
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
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorServices, FornecedorServices>();


            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefatulConnection"));
            });


           services.AddControllersWithViews();

           services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiSistemaDePedidos", Description = "Teste API", Version = "v1" });
            });

        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            
            if (!app.Environment.IsDevelopment())
            {
              
                app.UseHsts();

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "APISaudacao v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html"); ;
        }
    }
}
