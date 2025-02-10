using System.ComponentModel.DataAnnotations.Schema;

namespace Akashic8.Domain
{
    public class Order : BaseDomainModel
    {
        public string UserId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public string PaymentStatus { get; set; } = "Pending";
        public List<CartItem> CartItems { get; set; } = new();

    }
}
