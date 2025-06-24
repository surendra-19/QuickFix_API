using Microsoft.EntityFrameworkCore;
using QuickFix_API.Models;

namespace QuickFix_API.Context
{
    public class QuickFixDbContext : DbContext
    {
        public QuickFixDbContext(DbContextOptions<QuickFixDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
