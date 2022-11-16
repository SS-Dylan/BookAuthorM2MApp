using BookAuthorM2MApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookAuthorM2MApp.Controllers;

public class BookAuthorController : Controller
{
    private readonly IBookAuthorRepository _bookAuthorRepo;
    private readonly IBookRepository _bookRepo;
    private readonly IAuthorRepository _authorRepo;

    public BookAuthorController(IBookAuthorRepository bookAuthorRepo,
        IBookRepository bookRepo,
        IAuthorRepository authorRepo)
    {
        _bookAuthorRepo = bookAuthorRepo;
        _bookRepo = bookRepo;
        _authorRepo = authorRepo;
    }

    public async Task<IActionResult> AssignAuthor([Bind(Prefix = "Id")] int bookId)
    {
        var authors = await _authorRepo.ReadAllAsync();
        ViewData["Book"] = bookId;
        return View(authors);
    }
    public async Task<IActionResult> AssignToBook([Bind(Prefix = "Id")] int bookId, int authorid)
    {
        await _bookAuthorRepo.Create(bookId, authorid);
        return RedirectToAction("Index", "Book");
    }
}
