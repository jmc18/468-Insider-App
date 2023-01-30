using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace _468Insider.Core
{
    public static class ApplicationServiceRegistration
    {
        /// <summary>
        /// Registers the application services.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
