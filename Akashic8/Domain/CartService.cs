using Akashic8.Data;
using Microsoft.EntityFrameworkCore;
using Akashic8.Domain;

namespace Akashic8.Domain
{
    public class CartService
    {
        private readonly IDbContextFactory<Akashic8Context> _dbFactory;

        public CartService(IDbContextFactory<Akashic8Context> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        // Create or Update
        public async Task AddOrUpdateItemAsync(string userId, CartItem item)
        {
            using var context = await _dbFactory.CreateDbContextAsync();

            Console.WriteLine($"Attempting to add/update cart item for user: {userId}");

            var existingItem = await context.CartItem
                .FirstOrDefaultAsync(ci => ci.UserId == userId && ci.BookId == item.BookId);

            if (existingItem != null)
            {
                Console.WriteLine($"Item {item.BookName} already in cart. Increasing quantity.");
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Console.WriteLine($"Adding new cart item: {item.BookName}");
                item.UserId = userId;
                context.CartItem.Add(item);
            }

            await context.SaveChangesAsync();
            Console.WriteLine("Cart update saved to database.");
        }



        // Read
        public async Task<List<CartItem>> GetCartItemAsync(string userId)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            return await context.CartItem.Where(ci => ci.UserId == userId).ToListAsync();
        }


    }

}