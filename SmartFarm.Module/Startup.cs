using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Data.Migration;
using SmartFarm.Module.Models;
using SmartFarm.Module.Migration;
using SmartFarm.Module.Drivers;
using OrchardCore.ContentManagement;
using SmartFarm.Module.Migration;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddContentPart<FarmPart>();


        services.AddScoped<IDataMigration, FarmMigrations>();
    }
}
