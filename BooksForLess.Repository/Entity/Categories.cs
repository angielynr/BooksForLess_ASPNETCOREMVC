using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksForLess.Repository.Entity
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? DisplayOrder { get; set; }
    }
}
