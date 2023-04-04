using System.ComponentModel.DataAnnotations;

namespace BooksForLess.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? DisplayOrder { get; set; }
    }
}
