//using Microsoft.AspNetCore.Server.IIS;

//var builder = WebApplication.CreateBuilder();

//var feature = builder.Environment.Features.Get<IISEnvironmentFeature>();

//builder.Configuration.AddInMemoryCollection(new[] { new KeyValuePair<string, string>("IISSite", feature.SiteName) });

//var site = builder.Configuration["IISSite"];

//var app = builder.Build();

//app.Run();

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Server.IIS;

var builder = WebHost.CreateDefaultBuilder()
    .ConfigureAppConfiguration((context, builder) =>
    {
        var feature = context.HostingEnvironment.Features.Get<IISEnvironmentFeature>();
    })
    .Build();

builder.Start();
