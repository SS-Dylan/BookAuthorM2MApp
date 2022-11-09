﻿using BookAuthorM2MApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAuthorM2MApp.Services;

public class DbAuthorRepository : IAuthorRepository
{
    private readonly ApplicationDbContext _db;

    public DbAuthorRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<ICollection<Author>> ReadAllAsync()
    {
        return await _db.Authors.ToListAsync();
    }
}
