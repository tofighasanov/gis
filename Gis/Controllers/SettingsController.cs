using Microsoft.AspNetCore.Mvc;

namespace Gis.Controllers
{
    public class SettingsController : Controller
    {
        // GET: /Settings
        public IActionResult Index()
        {
            return View();
        }
    }
}
