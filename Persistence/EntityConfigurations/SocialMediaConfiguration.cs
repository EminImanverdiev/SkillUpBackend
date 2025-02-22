

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder
            .ToTable("SocialMedias");

        builder.
            HasKey(sm => sm.Id);

        builder
            .Property(sm => sm.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .Property(sm => sm.Icon)
            .HasMaxLength(200);

        builder
            .Property(sm => sm.URL)
            .HasMaxLength(500);

        builder
            .HasOne(sm => sm.Speaker)
            .WithMany(s => s.SocialMedias)
            .HasForeignKey(sm => sm.SpeakerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}