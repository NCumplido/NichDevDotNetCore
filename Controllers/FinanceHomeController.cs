using Microsoft.AspNetCore.Mvc;

namespace NichDevDotNetCore.Controllers
{
    public class FinanceHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
