using System.Threading.Tasks;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
namespace SimpleText.Module.Migrations
{
    public class SimpleTextMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public SimpleTextMigrations(IContentDefinitionManager contentDefinitionManager)
            => _contentDefinitionManager = contentDefinitionManager;

        public async Task<int> CreateAsync()
        {
            // Appel asynchrone à AlterTypeDefinitionAsync
            await _contentDefinitionManager.AlterTypeDefinitionAsync("text", type => type
                   .WithPart("CommonPart")
                   .WithPart("TitlePart")
                   .Creatable()
                   .Draftable());
        

            return 1;
        }
    }
}
