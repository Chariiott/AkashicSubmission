namespace Akashic8.Domain
{
    public class Book : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string? ImageUrl { get; set; }
        
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public int LanguageId { get; set; }


        //Navigation Property
        public Genre Genre { get; set; }
    }
}
