using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeWebApiOntoMany.Data;
using PracticeWebApiOntoMany.Dto;
using PracticeWebApiOntoMany.Model;

namespace PracticeWebApiOntoMany.Service
{
    public class CountryService : ICountryService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CountryService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<ListProductDto>> GetListProduct()
        {
            var listProduct = _context.Products.ToList();
            var model = _mapper.Map<List<ListProductDto>>(listProduct);

            return model;
        }

        public async Task<ActionResult<DetailProductDto>> GetSingleProduct(int id)
        {
            var product = await _context.Products.Include(c => c.Category).FirstOrDefaultAsync(c => c.ProductId == id);
            if (product == null)
            {
                return null;
            }
            var model = _mapper.Map<DetailProductDto>(product);

            return model;
        }

        public async Task<ActionResult<EditProductDto>> CreateProduct(EditProductDto product)
        {
            if (ProductExists(product.Name))
            {
                return null; // or BadRequest("Duplicate product name")
            }

            var entity = _mapper.Map<Product>(product);
            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<EditProductDto>(entity);
        }

        public async Task<ActionResult<EditProductDto>> EditProduct(int id, EditProductDto product)
        {
            var existing = await _context.Products.FindAsync(id);
            if (existing == null)
            {
                return null; // or NotFound()
            }

            if (ProductExists(product.Name) && existing.Name != product.Name)
            {
                return null; // or BadRequest("Duplicate product name")
            }

            _mapper.Map(product, existing);
            await _context.SaveChangesAsync();

            return _mapper.Map<EditProductDto>(existing);
        }
        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool ProductExists(string name)
        {
            return _context.Products.Any(e => e.Name == name);
        }

    }
}
