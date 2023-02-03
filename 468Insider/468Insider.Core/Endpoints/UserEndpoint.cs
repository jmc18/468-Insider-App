using _468Insider.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace _468Insider.Core.Endpoints
{
    public class UserEndpoint
    {
        private readonly Admin468InsiderDbContext _dbContext;
        public UserEndpoint(Admin468InsiderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterUserAPIs(WebApplication app)
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapGet("/weatherforecast", () =>
                {
                    var forecast = Enumerable.Range(1, 5).Select(index =>
                            new WeatherForecast
                            (
                                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                                Random.Shared.Next(-20, 55),
                                summaries[Random.Shared.Next(summaries.Length)]
                            ))
                        .ToArray();
                    return forecast;
                })
                .WithName("GetWeatherForecast")
                .WithTags("WeatherForecast")
                .WithOpenApi();
        }

        internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
        {
            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
