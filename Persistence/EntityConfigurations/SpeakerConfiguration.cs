

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class SpeakerConfiguration : IEntityTypeConfiguration<Speaker>
{
    public void Configure(EntityTypeBuilder<Speaker> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
            .IsRequired()  
            .HasMaxLength(150); 
        
        builder.Property(s => s.Bio)
            .HasMaxLength(1000); 
        
        builder.Property(s => s.ImageURL)
            .HasMaxLength(1000);  

        builder.Property(s => s.ImageName)
            .HasMaxLength(200);

        builder.HasMany(s => s.Events)
            .WithMany(e => e.Speakers);

        builder.HasMany(s => s.SocialMedias) 
            .WithOne(sm => sm.Speaker)  
            .HasForeignKey(sm => sm.SpeakerId); 

    }
}
