using Microsoft.AspNetCore.Mvc;

namespace weblayout.Controllers
{
    public class teamController : Controller
    {
        public IActionResult Team()
        {
            return View();
        }
    }
}
