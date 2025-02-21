using Domain.Comman;

namespace Domain.Entities;

public class Course: BaseEntity
{
    public string Icon { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
    public int CourseCount { get; set; }
    public ICollection<Video> Videos { get; set; } 

}