

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("Services");

        builder.HasKey(s => s.Id);  

        builder.Property(s => s.Title)
            .IsRequired()   
            .HasMaxLength(100);  

        builder.Property(s => s.Description)
            .HasMaxLength(500);  

        builder.Property(s => s.ImageURL)
            .HasMaxLength(1000);  

        builder.Property(s => s.ImageName)
            .HasMaxLength(200);
    }
}
