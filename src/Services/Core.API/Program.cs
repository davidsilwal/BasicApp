using SharedKernel.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBasicServiceExtensions();

var app = builder.Build();

app.AddBasicWebAppExtensions();

app.Run();