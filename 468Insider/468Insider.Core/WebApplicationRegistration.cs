using _468Insider.Core.Endpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace _468Insider.Core
{
    public static class WebApplicationRegistration
    {
        /// <summary>
        /// Registers the Web Application.
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static void AddWebApplication(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var service = scope.ServiceProvider.GetService<UserEndpoint>();
            service?.RegisterUserAPIs(app);
        }
    }
}
