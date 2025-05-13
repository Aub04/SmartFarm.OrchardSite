using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Ajouter les services Orchard Core CMS
builder.Services.AddOrchardCms();

var app = builder.Build();

// Utiliser les fichiers statiques
app.UseStaticFiles();

// Utiliser Orchard Core
app.UseOrchardCore();

app.Run();
