using Microsoft.AspNetCore.Mvc;
using Gis.Models;
using System.Collections.Generic;

namespace Gis.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index() => View();
    }
}
