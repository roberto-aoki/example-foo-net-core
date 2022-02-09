using Foo.Model;
using Foo.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Foo.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<FooModel> Foos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new FooModelConfiguration());
        }
    }
}
