

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts;

public class SkillUpDbContext:DbContext
{
    public SkillUpDbContext(DbContextOptions options):base(options){}
    DbSet<Video> Videos { get; set; }
    DbSet<Testimonial> Testimonials { get; set; }
    DbSet<Statistic> Statistics { get; set; }
    DbSet<Speaker> Speakers { get; set; }
    DbSet<Partner> Partners { get; set; }
    DbSet<Message> Messages { get; set; }
    DbSet<Instructor> Instructors { get; set; }
    DbSet<Fag> Fags { get; set; }
    DbSet<ContactInfo> ContactInfos { get; set; }
    DbSet<Course> Courses { get; set; }
    DbSet<Event> Events { get; set; }
    DbSet<SocialMedia> SocialMedias { get; set; }
    DbSet<Service> Services { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SkillUpDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}
