using BookAuthorM2MApp.Models.Entities;
using System.Security.Cryptography;

namespace BookAuthorM2MApp.Services;

public class DbBookAuthorRepository : IBookAuthorRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IBookRepository _bookRepo;
    private readonly IAuthorRepository _authorRepo;

    public DbBookAuthorRepository(ApplicationDbContext db,
        IBookRepository bookRepo,
        IAuthorRepository authorRepo)
    {
        _db = db;
        _bookRepo = bookRepo;
        _authorRepo = authorRepo;
    }

    public async Task<BookAuthor?> Create(int bookId, int authorId)
    {
        var book = await _bookRepo.ReadAsync(bookId);
        if (book == null)
        {
            return null;
        }
        var authorCheck = book.Authors.FirstOrDefault(a => a.Id == authorId);
        if (authorCheck != null)
        {
            return null;
        }
        var author = await _authorRepo.ReadAsync(authorId);
        if (author == null)
        {
            return null;
        }
        var bookAuthor = new BookAuthor
        {
            Author = author,
            Book = book
        };
        book.Authors.Add(author);
        author.Books.Add(book);
        await _db.SaveChangesAsync();
        return bookAuthor;
    }
}
