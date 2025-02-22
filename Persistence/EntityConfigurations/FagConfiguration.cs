

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class FagConfiguration : IEntityTypeConfiguration<Fag>
{
    public void Configure(EntityTypeBuilder<Fag> builder)
    {
        builder.ToTable("Fags");

        builder.HasKey(f => f.Id); 

        builder.Property(f => f.Title)
            .IsRequired()        
            .HasMaxLength(150);    

        builder.Property(f => f.Content)
            .IsRequired()         
            .HasMaxLength(1000);   

        builder.Property(f => f.Type)
            .IsRequired();      
    }
    }
