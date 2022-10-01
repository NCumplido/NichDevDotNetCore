using Microsoft.AspNetCore.Mvc;

namespace NichDevDotNetCore.Controllers
{
    public class GraphPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
