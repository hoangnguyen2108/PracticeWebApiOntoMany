using Microsoft.AspNetCore.Mvc;
using PracticeWebApiOntoMany.Dto;

namespace PracticeWebApiOntoMany.Service
{
    public interface ICountryService
    {
        Task<ActionResult<EditProductDto>> CreateProduct(EditProductDto product);
        Task<bool> DeleteProduct(int id);
        Task<ActionResult<EditProductDto>> EditProduct(int id, EditProductDto product);
        Task<List<ListProductDto>> GetListProduct();
        Task<ActionResult<DetailProductDto>> GetSingleProduct(int id);
    }
}