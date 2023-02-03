using System.Reflection;
using _468Insider.Core.Endpoints;
using _468Insider.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddDbContext<Admin468InsiderDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("468InsiderDB")));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());


            //Endpoints registration
            services.AddScoped<UserEndpoint>();

            return services;
        }
    }
}
