using System.Reflection;
using System.Text.Json.Serialization;
using _468Insider.Core.Endpoints;
using _468Insider.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using _468Insider.Domain.Helpers;

namespace _468Insider.Core
{
    public static class ApplicationServiceRegistration
    {
        /// <summary>
        /// Registers the application services.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddDbContext<Admin468InsiderDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("468InsiderDB")));

            services.Configure<JsonOptions>(options =>
                options.SerializerOptions.DefaultIgnoreCondition =
                    JsonIgnoreCondition.WhenWritingDefault | JsonIgnoreCondition.WhenWritingNull);

            services.AddCors();

            // configure strongly typed settings object
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());


            //Endpoints registration
            services.AddScoped<UserEndpoint>();

            return services;
        }
    }
}
