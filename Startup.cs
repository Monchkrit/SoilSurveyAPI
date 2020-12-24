
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using SoilSurveyAPI.Models;
using SoilSurveyAPI.Services;

namespace SoilSurveyAPI
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
          services.Configure<SoilSurveyDatabaseSettings>(
            Configuration.GetSection(nameof(SoilSurveyDatabaseSettings)));

          services.AddSingleton<ISoilSurveyDatabaseSettings>(sp =>
            sp.GetRequiredService<IOptions<SoilSurveyDatabaseSettings>>().Value);
          
          services.AddSingleton<SoilSurveyService>();

          services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
