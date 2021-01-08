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
    public class CustomersApiController : ControllerBase
    {
        private readonly TodoContext _context;

        public CustomersApiController(TodoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomersDTO>>> GetCustomers()
        {
             return await _context.Customers
                .Select(x => CustomersitemDTO(x))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomersDTO>> GetCustomers(long id)
        {
            var customers = await _context.Customers.FindAsync(id);

            if (customers == null)
            {
                return NotFound();
            }

            return CustomersitemDTO(customers);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(long id, CustomersDTO customersDTO)
        {
            if (id != customersDTO.Id)
            {
                return BadRequest();
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }

            customers.Name = customersDTO.Name;
            customers.Email = customersDTO.Email;
            customers.Address = customersDTO.Address;
            customers.Phone = customersDTO.Phone;
            customers.Pass = customersDTO.Pass;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CustomerExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<CustomersDTO>> CreateCategory(CustomersDTO customersDTO)
        {
            var customers = new Customers
            {
                Name = customersDTO.Name,
                Email = customersDTO.Email,
                Address = customersDTO.Address,
                Phone = customersDTO.Phone,
                Pass = customersDTO.Pass
                
            };

            _context.Customers.Add(customers);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCustomers),
                new { id = customers.Id },
                CustomersitemDTO(customers));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomers(long id)
        {
            var customers = await _context.Customers.FindAsync(id);

            if (customers == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(long id) =>
                    _context.Customers.Any(e => e.Id == id);
        private static CustomersDTO CustomersitemDTO(Customers customers) =>
            new CustomersDTO
            {
                Id = customers.Id,
                Name = customers.Name,
                Email = customers.Email,
                Address = customers.Address,
                Phone = customers.Phone,
                Pass = customers.Pass
            };
    }
}