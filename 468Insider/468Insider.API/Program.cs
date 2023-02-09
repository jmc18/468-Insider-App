using _468Insider.Core;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Web application starting.");

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ContextBoundObject, LoggerConfiguration) => LoggerConfiguration
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .ReadFrom.Configuration(ContextBoundObject.Configuration));

// Add services to the container.

builder.Services.AddApplicationServices(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseDefaultFiles();
    app.UseStaticFiles();
}

app.UseHttpsRedirection();

app.AddWebApplication();

app.Run();