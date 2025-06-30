using QuickFix_API.DTOS;

namespace QuickFix_API.Interfaces
{
    public interface IAuthorizationService
    {
        Task RegisterCustomerAsync(SignupDTO signup);
        Task LoginCustomerAsync(LoginDTO login);
    }
}
