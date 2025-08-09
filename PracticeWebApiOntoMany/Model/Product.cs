using System.ComponentModel.DataAnnotations;

namespace PracticeWebApiOntoMany.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}