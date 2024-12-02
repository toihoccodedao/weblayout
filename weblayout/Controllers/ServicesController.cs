using Microsoft.AspNetCore.Mvc;

namespace weblayout.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }
    }
}
