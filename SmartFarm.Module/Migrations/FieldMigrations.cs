using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

namespace SmartFarm.Module.Migrations
{
    public class FieldMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;
        public FieldMigrations(IContentDefinitionManager contentDefinitionManager)
            => _contentDefinitionManager = contentDefinitionManager;

        public int Create()
        {
            // Définit un Content Type "Field" (Champ)
            _contentDefinitionManager.AlterTypeDefinition("Field", type => type
                .Creatable()    // Cratable via l'admin
                .Listable()     // Listable dans l'admin
                .WithPart("FieldPart", part => part
                    .WithField("CowCount", field => field
                        .OfType("NumericField")
                        .WithDisplayName("Nombre de vaches"))
                    .WithField("Race", field => field
                        .OfType("TextField")
                        .WithDisplayName("Race"))
                    .WithField("ArrivalDate", field => field
                        .OfType("DateField")
                        .WithDisplayName("Date d'arrivée"))
                    .WithField("Localisation", field => field
                        .OfType("TextField")
                        .WithDisplayName("Localisation"))
                ));

            return 1;
        }
    }
}
