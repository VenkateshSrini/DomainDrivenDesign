using DomainObjects;

namespace ItemCatalogue.Domain
{
    public enum BookType
    {
        Audio = 0,
        eBook= 1
    }
    public class Book
    {
        public string ISBNId { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public BookType BookType { get; set; }
        public List<Author> Authors { get; set; }
        public  List<UserRating> Ratings { get; set; }

    }
}
