using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeWebApiOntoMany.Data;
using PracticeWebApiOntoMany.Dto;
using PracticeWebApiOntoMany.Model;
using PracticeWebApiOntoMany.Service;

namespace PracticeWebApiOntoMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        private readonly ICountryService _countryService;

        public ProductsController(IMapper mapper,ApplicationDbContext context,ICountryService countryService)
        {
            _mapper = mapper;
            _context = context;
            _countryService = countryService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<List<ListProductDto>> GetProducts()
        {
            var product = await _countryService.GetListProduct();
            return product;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailProductDto>> GetProduct(int id)
        {
            var model = await _countryService.GetSingleProduct(id);
            
            return model;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<EditProductDto>> PutProduct(int id, EditProductDto product)
        {
            var update = await _countryService.EditProduct(id,product);
            if (update == null)
            {
                return BadRequest("Duplicate product name or invalid data");
            }
            return update;
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<EditProductDto>> PostProduct(EditProductDto product)
        {
            var update = await _countryService.CreateProduct(product);
            if (update == null)
            {
                return BadRequest("Unsuccess");
            }
            return CreatedAtAction("GetProducts", new { Name = product.Name }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _countryService.DeleteProduct(id);

            return NoContent();
        }

        
    }
}
