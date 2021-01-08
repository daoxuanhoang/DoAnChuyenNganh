using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XuanHoang.Models;

namespace XuanHoang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly TodoContext _context;

        public ProductApiController(TodoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProduct()
        {
             return await _context.Product
                .Select(x => ProductitemDTO(x))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProduct(long id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return ProductitemDTO(product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(long id, ProductDTO productDTO)
        {
            if (id != productDTO.Id)
            {
                return BadRequest();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            product.Name = productDTO.Name;
            product.Description = productDTO.Description;
            product.CategoryId = productDTO.CategoryId;
            product.Image = productDTO.Image;
            product.Price = productDTO.Price;
            product.Status = productDTO.Status;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ProductExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(ProductDTO productDTO)
        {
            var product = new Product
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                CategoryId = productDTO.CategoryId,
                Image = productDTO.Image,
                Price = productDTO.Price,
                Status = productDTO.Status
                
            };

            _context.Product.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetProduct),
                new { id = product.Id },
                ProductitemDTO(product));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(long id) =>
                    _context.Product.Any(e => e.Id == id);
        private static ProductDTO ProductitemDTO(Product product) =>
            new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                CategoryId = product.CategoryId,
                Image = product.Image,
                Price = product.Price,
                Status = product.Status
            };
    }
}