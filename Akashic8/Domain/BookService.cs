using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akashic8.Data;
using Akashic8.Domain;
using Microsoft.EntityFrameworkCore;

public class BookService
{
    private readonly Akashic8Context _context;

    public BookService(Akashic8Context context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetRandomFeaturedBooks(int count = 5)
    {
        return await _context.Book
            .OrderBy(r => Guid.NewGuid()) // Random order
            .Take(count) // Limit the number of books
            .ToListAsync();
    }

    public async Task<List<Genre>> GetAllGenresAsync()
    {
        return await _context.Genre.Include(g => g.Books).ToListAsync();
    }

    // Fetch books by genre ID
    public async Task<List<Book>> GetBooksByGenreAsync(int genreId)
    {
        return await _context.Book.Where(b => b.GenreId == genreId).ToListAsync();
    }
}
