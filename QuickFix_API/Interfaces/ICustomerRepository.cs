using QuickFix_API.DTOS;

namespace QuickFix_API.Interfaces
{
    public interface ICustomerRepository
    {
        Task RegisterCustomerAsync(SignupDTO signup);
    }
}
