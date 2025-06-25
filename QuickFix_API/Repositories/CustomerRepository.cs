using QuickFix_API.Context;
using QuickFix_API.DTOS;
using QuickFix_API.Models;

namespace QuickFix_API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly QuickFixDbContext _dbContext;
        public CustomerRepository(QuickFixDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task RegisterCustomerAsync(SignupDTO signupDTO)
        {
            var customer = new Customer
            {
                FirstName = signupDTO.FirstName,
                LastName = signupDTO.LastName,
                Email = signupDTO.Email,
                Password = signupDTO.Password,
                ContactNumber = signupDTO.ContactNumber,
                Address = signupDTO.Address,
                CityLivingIn = signupDTO.CityLivingIn
            };
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}
