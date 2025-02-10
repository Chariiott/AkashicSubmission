using Akashic8.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Akashic8.Configurations.Entities
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                 new Book
                 {
                     Id = 1,
                     Name = "To Kill A Mockingbird",
                     Description = "A novel by Harper Lee",
                     ISBN = "978-0-06-112008-4",
                     Price = 12.99,
                     Quantity = 10,
                     ImageUrl = "/images/To Kill A Mockingbird.jpg",
                     AuthorId = 1,
                     GenreId = 1,
                     LanguageId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Book
                 {
                     Id = 2,
                     Name = "The Hobbit",
                     Description = "A novel by J.R.R. Tolkien",
                     ISBN = "978-0-21-102080-4",
                     Price = 15.99,
                     Quantity = 3,
                     ImageUrl = "/images/The Hobbit.jpg",
                     AuthorId = 2,
                     GenreId = 9,
                     LanguageId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Book
                 {
                     Id = 3,
                     Name = "Moby-Dick",
                     Description = "A novel by Herman Melville",
                     ISBN = "978-0-43-265346-1",
                     Price = 11.50,
                     Quantity = 17,
                     ImageUrl = "/images/Moby Dick.jpg",
                     AuthorId = 3,
                     GenreId = 1,
                     LanguageId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Book
                 {
                     Id = 4,
                     Name = "Harry Potter and the Sorcerer's Stone",
                     Description = "A novel by J.K. Rowling",
                     ISBN = "978-0-43-265346-1",
                     Price = 18.99,
                     Quantity = 34,
                     ImageUrl = "/images/Harry Potter and The Sorcerer's Stone.jpg",
                     AuthorId = 4,
                     GenreId = 9,
                     LanguageId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
                );
        }
    }
}
