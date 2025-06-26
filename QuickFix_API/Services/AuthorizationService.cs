using QuickFix_API.DTOS;
using QuickFix_API.Interfaces;

namespace QuickFix_API.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly ICustomerRepository _customerRepository;
        public AuthorizationService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task RegisterCustomerAsync(SignupDTO signup)
        {
            await _customerRepository.RegisterCustomerAsync(signup);
        }
    }
}
