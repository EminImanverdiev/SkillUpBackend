

using Domain.Comman;
using System.Collections.ObjectModel;

namespace Domain.Entities;

public class Event : BaseEntity
{
    public string Title { get; set; } 
    public string Description { get; set; } 
    public DateTime StartTime { get; set; } 
    public DateTime EndTime { get; set; } 
    public string Location { get; set; } 
    public string ImageURL { get; set; } 
    public string ImageName { get; set; }
    public bool IsOnline { get; set; } 
    public string Organizer { get; set; }
    public int AttendeeCount { get; set; }
    public string YouTubeLink { get; set; }
    public ICollection<Speaker> Speakers { get; set; } = new Collection<Speaker>();  
}
