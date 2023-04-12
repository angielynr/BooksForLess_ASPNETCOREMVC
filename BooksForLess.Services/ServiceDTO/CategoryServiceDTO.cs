using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksForLess.Services.ServiceDTO
{
    public class CategoryServiceDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        public string? DisplayOrder { get; set; }
    }
}
