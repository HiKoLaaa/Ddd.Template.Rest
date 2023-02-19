namespace DDD.Template.Persistence.Configurations;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class ExampleConfiguration : IEntityTypeConfiguration<Example>
{
    public void Configure(EntityTypeBuilder<Example> builder)
    {
        builder.ToTable("examples");

        builder.HasKey(example => example.Id).HasName("PK_id");
        builder.Property(example => example.Id).HasColumnName("id");
    }
}
