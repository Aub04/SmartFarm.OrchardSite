using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using SimpleText.Module.Migrations;

namespace SimpleText.Module
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddDataMigration<SimpleTextMigrations>();
        }
    }
}

