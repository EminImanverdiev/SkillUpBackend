

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> builder)
    {
        builder.ToTable("Testimonial");

        builder.HasKey(t => t.Id);

        builder.Property(t=>t.Title)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t=>t.Description)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(t=>t.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t=>t.Location)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.ImageName)
               .HasMaxLength(200);

    }
}
