namespace BookAuthorM2MApp.Services;

public class DbBookAuthorRepository : IBookAuthorRepository
{
    private readonly ApplicationDbContext _db;

    public DbBookAuthorRepository(ApplicationDbContext db)
    {
        _db = db;
    }
}
