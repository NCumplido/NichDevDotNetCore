using Microsoft.AspNetCore.Mvc;

namespace NichDevDotNetCore.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
