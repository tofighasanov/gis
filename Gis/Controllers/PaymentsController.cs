using Microsoft.AspNetCore.Mvc;

namespace Gis.Controllers
{
    public class PaymentsController : Controller
    {
        // GET: /Payments or /Payments/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
