using Microsoft.AspNetCore.Mvc;

namespace weblayout.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
