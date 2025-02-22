

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("Messages");

        builder.HasKey(m => m.Id); 

        builder.Property(m => m.Name)
            .IsRequired()   
            .HasMaxLength(100); 

        builder.Property(m => m.Email)
            .IsRequired()    
            .HasMaxLength(100);  

        builder.Property(m => m.Subject)
            .HasMaxLength(200);  

        builder.Property(m => m.Content)
            .IsRequired()    
            .HasMaxLength(1000); 
    }
    }
