using Microsoft.AspNetCore.Mvc;

namespace Gis.Controllers
{
    public class ParticipantsController : Controller
    {
        // GET: /Participants or /Participants/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
