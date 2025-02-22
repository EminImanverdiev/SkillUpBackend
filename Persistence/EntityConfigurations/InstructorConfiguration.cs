

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");

            builder.HasKey(i => i.Id); 

            builder.Property(i => i.Name)
                .IsRequired()           
                .HasMaxLength(200);     

            builder.Property(i => i.Biography)
                .HasMaxLength(1000);   

            builder.Property(i => i.Description)
                .HasMaxLength(1000);   

            builder.Property(i => i.StudentCount)
                .IsRequired();          

            builder.Property(i => i.Job)
                .IsRequired();
        }
    }
}
