using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NichDevDotNetCore.Data;
using NichDevDotNetCore.Models;
using NichDevDotNetCore.Models.ViewModels;
using NichDevDotNetCore.Repositories;
using NichDevDotNetCore.Services;
using System.Diagnostics;

namespace NichDevDotNetCore.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;
    private readonly PostRepository _postRepository;
    private readonly ICatFactService _catFactService;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ICatFactService catFactService)
    {
        _logger = logger;
        _context = context;
        _postRepository = new PostRepository(context);
        _catFactService = catFactService;
    }

    public async Task<IActionResult> Index()
    {
        PostsViewModel viewModel = new PostsViewModel();
        viewModel.Posts = await _context.Posts.ToListAsync();

        viewModel.CatFact = await _catFactService.GetCatFact();
        return View(viewModel);
    }

    public async Task<CatFact> GetCatFact()
    {
        var catFact = await _catFactService.GetCatFact();
        return catFact;
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
