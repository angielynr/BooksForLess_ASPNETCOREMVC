using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksForLess.Repository.RepositoryDTO
{
    public class AllCategoriesResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? DisplayOrder { get; set; }
        public string? ResultMessage { get; set; }
    }
}
