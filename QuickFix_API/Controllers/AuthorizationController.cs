using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickFix_API.Context;
using QuickFix_API.DTOS;
using QuickFix_API.Models;

namespace QuickFix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly QuickFixDbContext _dbcontext;
        public AuthorizationController(QuickFixDbContext context)
        {
            _dbcontext = context;
        }

        [HttpPost("CustomerRegistration")]
        public async Task<IActionResult> CustomerRegistration([FromBody] SignupDTO signup )
        {
            var newCustomer = new Customer{ 
                FirstName = signup.FirstName,
                LastName = signup.LastName,
                Email = signup.Email,
                Password = signup.Password,
                ContactNumber = signup.ContactNumber,
                Address = signup.Address,
                CityLivingIn = signup.CityLivingIn
            };
            _dbcontext.Add(newCustomer);
            await _dbcontext.SaveChangesAsync();
            return Ok(new {message="User Registration Successful!"});
        }
    }
}
