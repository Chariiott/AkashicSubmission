using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Akashic8.Data;
using Akashic8.Configurations.Entities;
using Akashic8.Domain;

namespace Akashic8.Data
{
    public class Akashic8Context(DbContextOptions<Akashic8Context> options) : IdentityDbContext<Akashic8User>(options)
    {
        public DbSet<Akashic8.Domain.Author> Author { get; set; } = default!;
        public DbSet<Akashic8.Domain.Book> Book { get; set; } = default!;
        public DbSet<Akashic8.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Akashic8.Domain.Genre> Genre { get; set; } = default!;
        public DbSet<Akashic8.Domain.Language> Language { get; set; } = default!;
        public DbSet<Akashic8.Domain.Order> Order { get; set; } = default!;
        public DbSet<Akashic8.Domain.CartItem> CartItem { get; set; } = default!;
        public DbSet<Akashic8.Domain.Payment> Payment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AuthorSeed());
            builder.ApplyConfiguration(new GenreSeed());
            builder.ApplyConfiguration(new LanguageSeed());
            builder.ApplyConfiguration(new BookSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
     
    }
}
