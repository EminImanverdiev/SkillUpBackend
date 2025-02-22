

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class PartnerConfiguration : IEntityTypeConfiguration<Partner>
{
    public void Configure(EntityTypeBuilder<Partner> builder)
    {
        builder.ToTable("Partners");

        builder.HasKey(p => p.Id);  

        builder.Property(p => p.ImageURL)
            .IsRequired()  
            .HasMaxLength(1000);  

        builder.Property(p => p.ImageName)
            .HasMaxLength(200); 
    }
    }
