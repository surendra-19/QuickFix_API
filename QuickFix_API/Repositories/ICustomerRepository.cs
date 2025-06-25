using QuickFix_API.DTOS;

namespace QuickFix_API.Repositories
{
    public interface ICustomerRepository
    {
        Task RegisterCustomerAsync(SignupDTO signup);
    }
}
