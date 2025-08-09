using System.ComponentModel.DataAnnotations;

namespace PracticeWebApiOntoMany.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
