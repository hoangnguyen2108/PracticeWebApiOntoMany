using System.Security.Cryptography.Pkcs;

namespace PracticeWebApiOntoMany.Dto
{
    public class EditProductDto
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}
