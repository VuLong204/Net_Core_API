using System.Collections.Generic;

namespace FirstWebMVC.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        
        // Một tác giả có nhiều sách
        public List<Book>? Books { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }

        // Khóa ngoại
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}