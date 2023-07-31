using Microsoft.AspNetCore.Server.IIS;

var builder = WebApplication.CreateBuilder();

var feature = builder.Environment.Features.Get<IISEnvironmentFeature>();

builder.Configuration.AddInMemoryCollection(new[] { new KeyValuePair<string, string>("IISSite", feature.SiteName) });

var site = builder.Configuration["IISSite"];

var app = builder.Build();

app.Run();
