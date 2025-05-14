using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.Views;
using SmartFarm.Module.Models;

namespace SmartFarm.Module.Drivers
{
    public class FarmPartDisplayDriver : ContentPartDisplayDriver<FarmPart>
    {
        public override IDisplayResult Display(FarmPart part, BuildPartDisplayContext context)
        {
            return View("Parts/FarmPart", part).Location("Detail", "Content");
        }
    }
}
