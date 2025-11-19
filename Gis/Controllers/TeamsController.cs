using Microsoft.AspNetCore.Mvc;

namespace Gis.Controllers
{
    public class TeamsController : Controller
    {
        // GET: /Teams or /Teams/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
