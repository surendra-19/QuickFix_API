using QuickFix_API.DTOS;

namespace QuickFix_API.Services
{
    public interface IAuthorizationService
    {
        Task RegisterCustomerAsync(SignupDTO signup);
    }
}
