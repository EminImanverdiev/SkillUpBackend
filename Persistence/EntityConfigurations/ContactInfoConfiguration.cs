

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ContactInfoConfiguration : IEntityTypeConfiguration<ContactInfo>
{
    public void Configure(EntityTypeBuilder<ContactInfo> builder)
    {
        builder.ToTable("ContactInfos");  

        builder.HasKey(ci => ci.Id);  

        builder.Property(ci => ci.Title)
            .IsRequired()          
            .HasMaxLength(100);      

        builder.Property(ci => ci.Description)
            .HasMaxLength(500);      

        builder.Property(ci => ci.Value)
            .IsRequired()            
            .HasMaxLength(255);     

        builder.Property(ci => ci.Icon)
            .HasMaxLength(100);      

        builder.Property(ci => ci.DisplayOrder)
            .IsRequired()
            .HasMaxLength(3);
            
    }
}
