using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NichDevDotNetCore.Data;
using NichDevDotNetCore.Models;
using NichDevDotNetCore.Models.ViewModels;
using NichDevDotNetCore.Repositories;
using NichDevDotNetCore.Services;

namespace NichDevDotNetCore.Controllers;
public class PostsController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly PostRepository _postRepository;
    private readonly ICatFactService _catFactService;

    public PostsController(ApplicationDbContext context, ICatFactService catFactService)
    {
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

    public async Task<IActionResult> Details(int id)
    {

        var post = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);

        post.Comments = _postRepository.GetAllCommentsByPost(id);

        if (post == null)
        {
            return NotFound();
        }

        return View(post);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Post post)
    {
        if (ModelState.IsValid)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(post);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var post = await _context.Posts.FindAsync(id);
        if (post == null)
        {
            return NotFound();
        }
        return View(post);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Post post)
    {
        if (post == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(post);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(post.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(post);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var post = await _context.Posts
            .FirstOrDefaultAsync(m => m.Id == id);
        if (post == null)
        {
            return NotFound();
        }

        return View(post);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var post = await _context.Posts.FindAsync(id);
        _context.Posts.Remove(post);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PostExists(int id)
    {
        return _context.Posts.Any(e => e.Id == id);
    }
}
