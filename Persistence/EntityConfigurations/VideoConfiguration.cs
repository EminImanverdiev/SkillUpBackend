

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;
public class VideoConfiguration : IEntityTypeConfiguration<Video>
{
    public void Configure(EntityTypeBuilder<Video> builder)
    {
        builder.ToTable("Videos");

        builder.HasKey(v => v.Id);

        builder.Property(v => v.VideoName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(v => v.VideoURL)
            .IsRequired();

        builder.Property(v => v.Order)
            .IsRequired();

        builder.HasOne(v => v.Course)
               .WithMany(v => v.Videos)
               .HasForeignKey(v=>v.CourseId);
    }
}
