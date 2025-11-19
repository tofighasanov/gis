using Microsoft.AspNetCore.Mvc;

namespace Gis.Controllers
{
    public class PanelController : Controller
    {
        // GET: /Panel
        public IActionResult Index()
        {
            // позже подкинем реальные цифры из БД
            ViewBag.TeamsCount = 4;
            ViewBag.ParticipantsCount = 27;
            ViewBag.PaymentsToday = 3;
            ViewBag.RevenueToday = 320; // AZN
            return View();
        }
    }
}
