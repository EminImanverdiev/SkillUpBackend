

using Domain.Comman;

namespace Domain.Entities;

public class Speaker:BaseEntity
{
    public string Name { get; set; }       
    public string Bio { get; set; }
    public string ImageURL { get; set; }
    public string ImageName { get; set; }
    public ICollection<SocialMedia> SocialMedias { get; set; }=new List<SocialMedia>(); 
    public ICollection<Event> Events { get; set; }=new List<Event>();
}
