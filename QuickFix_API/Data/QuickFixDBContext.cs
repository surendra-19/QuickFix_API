using Microsoft.EntityFrameworkCore;
using QuickFix_API.Models;

namespace QuickFix_API.Data
{
    public class QuickFixDBContext:DbContext
    {
        public QuickFixDBContext(DbContextOptions<QuickFixDBContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
