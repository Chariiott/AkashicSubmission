namespace Akashic8.Domain
{
    public class Genre : BaseDomainModel
    {
        public string? Name { get; set; }

        //Navigation Property
        public List<Book> Books { get; set; }
    }
}
