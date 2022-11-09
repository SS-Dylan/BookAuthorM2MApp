namespace BookAuthorM2MApp.Services;

public class DbAuthorRepository : IAuthorRepository
{
    private readonly ApplicationDbContext _db;

    public DbAuthorRepository(ApplicationDbContext db)
    {
        _db = db;
    }
}
