using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrchardCore.Modules;
using OrchardCore.Mvc.Core;

var builder = WebApplication.CreateBuilder(args);

// Ajouter les services Orchard Core
builder.Services.AddOrchardCms();

var app = builder.Build();

// Utiliser les fichiers statiques
app.UseStaticFiles();


// Utiliser Orchard Core
app.UseOrchardCore();

app.Run();

