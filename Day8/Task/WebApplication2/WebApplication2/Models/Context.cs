using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> optionsBuilder) :base(optionsBuilder){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
