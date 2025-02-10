namespace Akashic8.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
    }
}
