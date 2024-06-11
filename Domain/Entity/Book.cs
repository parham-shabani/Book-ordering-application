using System.ComponentModel.DataAnnotations;


namespace Domain.Entity
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public int Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}