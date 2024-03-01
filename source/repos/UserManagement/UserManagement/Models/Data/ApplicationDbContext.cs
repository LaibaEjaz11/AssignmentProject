using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Models.Data
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Admin> Admin{ get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
