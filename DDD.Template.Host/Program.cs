using DDD.Template.Api.Rest;
using DDD.Template.Host;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHost(builder.Configuration);

var app = builder.Build();

app.UseHttpLogging();

var apiGroup = app.MapGroup("api");
apiGroup.MapRest();

app.Run();
