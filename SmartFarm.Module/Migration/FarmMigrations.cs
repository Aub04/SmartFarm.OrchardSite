using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.ContentFields.Settings;
using Microsoft.Extensions.DependencyInjection;
using SmartFarm.Module.Models;
using System.Threading.Tasks;

namespace SmartFarm.Module.Migration
{
    public class FarmMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public FarmMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public async Task<int> CreateAsync()
        {
            await _contentDefinitionManager.AlterPartDefinitionAsync("FarmPart", part => part
                .Attachable()
                .WithField("CowCount", field => field
                    .OfType("NumericField")
                    .WithDisplayName("Number of Cows")
                    .WithSettings(new NumericFieldSettings
                    {
                        Minimum = 0,
                        Required = true
                    }))
                .WithField("CowBreed", field => field
                    .OfType("TextField")
                    .WithDisplayName("Breed of Cows")
                    .WithSettings(new TextFieldSettings
                    {
                        Hint = "Example: Holstein, Jersey"
                    }))
                .WithField("ArrivalDateUtc", field => field
                    .OfType("DateField")
                    .WithDisplayName("Arrival Date")
                    .WithSettings(new DateFieldSettings
                    {
                        Hint = "Date when the cows arrived"
                    }))
            );

            await _contentDefinitionManager.AlterTypeDefinitionAsync("FarmField", type => type
                .Creatable()
                .Listable()
                .WithPart("FarmPart")
            );

            return 1;
        }
    }

}
