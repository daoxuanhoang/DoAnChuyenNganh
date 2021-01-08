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
    public class CategoryApiController : ControllerBase
    {
        private readonly TodoContext _context;

        public CategoryApiController(TodoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategory()
        {
             return await _context.Category
                .Select(x => CategoryitemDTO(x))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTO>> GetCategory(long id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return CategoryitemDTO(category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(long id, CategoryDTO categoryDTO)
        {
            if (id != categoryDTO.Id)
            {
                return BadRequest();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            category.Name = categoryDTO.Name;
            category.Description = categoryDTO.Description;
            category.Status = categoryDTO.Status;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CategoryExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateCategory(CategoryDTO categoryDTO)
        {
            var category = new Category
            {
                Name = categoryDTO.Name,
                Description = categoryDTO.Description,
                Status = categoryDTO.Status
                
            };

            _context.Category.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCategory),
                new { id = category.Id },
                CategoryitemDTO(category));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(long id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(long id) =>
                    _context.Category.Any(e => e.Id == id);
        private static CategoryDTO CategoryitemDTO(Category category) =>
            new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Status = category.Status
            };
    }
}