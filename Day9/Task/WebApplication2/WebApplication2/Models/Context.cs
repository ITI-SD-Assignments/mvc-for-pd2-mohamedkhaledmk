using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.ViewModels;

namespace WebApplication2.Models
{
    public class Context:IdentityDbContext<AppUser>//DbContext
    {
        public Context(DbContextOptions<Context> optionsBuilder) :base(optionsBuilder){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public DbSet<WebApplication2.ViewModels.UserViewModel> UserViewModel { get; set; } = default!;
        public DbSet<WebApplication2.ViewModels.LoginUserVM> LoginUserVM { get; set; } = default!;
    }
}
