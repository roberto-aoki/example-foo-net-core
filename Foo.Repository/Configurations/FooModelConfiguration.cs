using Foo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foo.Repository.Configurations
{
    internal class FooModelConfiguration : IEntityTypeConfiguration<FooModel>
    {
        public void Configure(EntityTypeBuilder<FooModel> builder)
        {
            builder.ToTable("foo");
            builder.Property(x => x.Id)
                .HasColumnName("id");
            builder.Property(x => x.Name)
                .HasColumnName("name");
            builder.Property(x => x.Age)
                .HasColumnName("age");
        }
    }
}
