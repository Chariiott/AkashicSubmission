namespace Akashic8.Domain
{
    public class CartItem
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Links cart to a specific user
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }


}
