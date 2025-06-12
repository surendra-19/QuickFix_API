using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickFix_API.AuthService;
using QuickFix_API.Data;
using QuickFix_API.Models;

namespace QuickFix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly QuickFixDBContext _context;
        private readonly IConfiguration _config;
        private readonly AuthServiceClass _authService;

        public AuthController(QuickFixDBContext context ,IConfiguration configuration,AuthServiceClass authServiceClass)
        {
            _context = context;
            _config =  configuration;
            _authService = authServiceClass;
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
            var existingCustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Email == login.Email && c.Password == login.Password);
            if (existingCustomer == null)
            {
                return NotFound("Invalid email or password");
            }
            var token = _authService.GenerateJwtToken(existingCustomer);
            return Ok(new { token });
        }
    }
}
