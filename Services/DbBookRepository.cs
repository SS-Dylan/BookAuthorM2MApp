using BookAuthorM2MApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAuthorM2MApp.Services;

public class DbBookRepository : IBookRepository
{
    private readonly ApplicationDbContext _db;

    public DbBookRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<ICollection<Book>> ReadAllAsync()
    {
        return await _db.Books.ToListAsync();
    }
}
