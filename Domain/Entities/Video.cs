

using Domain.Comman;

namespace Domain.Entities;

public class Video:BaseEntity
{
    public string VideoName { get; set; }  
    public string VideoURL { get; set; }  
    public int Order { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }

}
