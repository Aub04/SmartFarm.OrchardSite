using Microsoft.AspNetCore.Mvc;

namespace SmartFarm.Module.Controllers
{
    [Route("smartfarm")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("Bienvenue dans la ferme intelligente 🌾", "text/plain");
        }
    }
}
