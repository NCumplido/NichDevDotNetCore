using Microsoft.AspNetCore.Mvc;

namespace NichDevDotNetCore.Controllers;
public class PortfolioController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
