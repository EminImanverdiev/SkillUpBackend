

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class StatisticConfiguration : IEntityTypeConfiguration<Statistic>
{
    public void Configure(EntityTypeBuilder<Statistic> builder)
    {
        builder.ToTable("Statistics");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Count)
            .IsRequired();

        builder.Property(s => s.Value)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s=>s.DisplayOrder)
            .IsRequired()
            .HasMaxLength(10);
    }
}
