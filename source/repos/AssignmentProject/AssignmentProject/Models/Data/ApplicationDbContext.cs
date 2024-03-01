using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssignmentProject.Models.Data
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Customer> Customer { get; set; }
       
    }
}
