using Microsoft.AspNetCore.Mvc;
using Gis.Models;
using System.Collections.Generic;

namespace Gis.Controllers
{
    public class View360Controller : Controller
    {
        public IActionResult Index() => View();
    }
}
