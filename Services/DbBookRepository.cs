namespace BookAuthorM2MApp.Services;

public class DbBookRepository : IBookRepository
{
    private readonly ApplicationDbContext _db;

    public DbBookRepository(ApplicationDbContext db)
    {
        _db = db;
    }
}
