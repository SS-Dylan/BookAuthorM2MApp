using BookAuthorM2MApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookAuthorM2MApp.Controllers;

public class AuthorController : Controller
{
    private readonly IAuthorRepository _authorRepo;

    public AuthorController(IAuthorRepository authorRepo)
    {
        _authorRepo = authorRepo;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _authorRepo.ReadAllAsync());
    }
}
