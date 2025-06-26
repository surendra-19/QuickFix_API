using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickFix_API.Context;
using QuickFix_API.DTOS;
using QuickFix_API.Interfaces;
using QuickFix_API.Models;

namespace QuickFix_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;

        public AuthorizationController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        [HttpPost("CustomerRegistration")]
        public async Task<IActionResult> CustomerRegistration([FromBody] SignupDTO signup)
        {
            await _authorizationService.RegisterCustomerAsync(signup);
            return Ok(new { message = "User Registration Successful!" });
        }
    }
}
