using BookingAirplaneTickets.Services.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookingAirplaneTickets.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public void ConfigureServices(IServiceCollection services)
        {
            // CORS
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            // get the connection string
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            // register DB CONTEXT 
            DiModule.RegisterModule(services, connectionString);




            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //SWAGER:
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "V1";
                    document.Info.Title = "Booking Airplane Tickets App";
                    document.Info.Description = "Nebb-Four Solutions Interview Coding Assignment";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Dushko Videski",
                        Email = "dushko.videski@gmail.com"
                    };
                };
            });
        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("CorsPolicy");

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseMvc();
        }
    }
}
