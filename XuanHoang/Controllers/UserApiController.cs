using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using XuanHoang.Models;

namespace XuanHoang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private readonly TodoContext _context;

        public UserApiController(TodoContext context)
        {
            _context = context;
        }

        // method pót
        [HttpPost]
        public async Task<ActionResult<LoginRequest>> Login(LoginRequest request)
        {
            
                Customers customer = await _context.Customers.Where(x=> x.Email == request.Email && x.Pass == request.Pass).FirstAsync();
                if(customer != null){
                     return Ok(customer);
                }
                return NotFound();
        }
        
    }
}