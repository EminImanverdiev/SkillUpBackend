

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable("Events");  

        builder.HasKey(e => e.Id); 

        builder.Property(e => e.Title)
            .IsRequired()           
            .HasMaxLength(200);     

        builder.Property(e => e.Description)
            .HasMaxLength(1000);    

        builder.Property(e => e.StartTime)
            .IsRequired();       

        builder.Property(e => e.EndTime)
            .IsRequired();        

        builder.Property(e => e.Location)
            .HasMaxLength(500);    

        builder.Property(e => e.ImageURL)
            .HasMaxLength(500);     

        builder.Property(e => e.ImageName)
            .HasMaxLength(500);  

        builder.Property(e => e.IsOnline)
            .IsRequired();       

        builder.Property(e => e.Organizer)
            .HasMaxLength(500);    
        builder.Property(e => e.AttendeeCount)
            .IsRequired();          

        builder.Property(e => e.YouTubeLink)
            .HasMaxLength(500);

        builder.HasMany(e => e.Speakers)
            .WithMany(s => s.Events);
    }
}
