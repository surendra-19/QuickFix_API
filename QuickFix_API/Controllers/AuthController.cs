using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickFix_API.Data;
using QuickFix_API.Models;

namespace QuickFix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly QuickFixDBContext _context;
        public AuthController(QuickFixDBContext context)
        {
            _context = context;
        }
        [HttpPost("Signup")]
        public async Task<IActionResult> CustomerRegistration(Customer customer)
        {
            var newCustomer = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Password = customer.Password,
                CityLivingIn = customer.CityLivingIn
            };
            _context.Customers.Add(newCustomer);
            await _context.SaveChangesAsync();
            return Ok(newCustomer);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> CustomerLogin(Login login)
        {
            var email = login.Email;
            var password = login.Password;
            var existingCustomer = await _context.Customers.Where(
                    customer => customer.Email == email && customer.Password == password
                ).ToListAsync();
            if (existingCustomer.Count == 0)
            {
                return NotFound("Invalid email or password");
            }
            return Ok(existingCustomer);
        }
    }
}
