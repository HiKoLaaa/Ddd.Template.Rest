using DDD.Template.Api.Rest;
using DDD.Template.Domain.Entities;
using DDD.Template.Host;
using DDD.Template.Infrastructure;
using DDD.Template.Persistence;
using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddConfigurations(builder.Configuration);
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddInfrastructure();
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(typeof(Example).Assembly));
builder.Services.AddHttpLogging(logging => { logging.LoggingFields = HttpLoggingFields.All; });

var app = builder.Build();

app.UseHttpLogging();

var apiGroup = app.MapGroup("api");
apiGroup.MapRest();

app.Run();
