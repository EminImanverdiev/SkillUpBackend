

using Domain.Comman;

namespace Domain.Entities;

public class SocialMedia:BaseEntity
{
    public string Name { get; set; } 
    public string Icon { get; set; }
    public string URL { get; set; }
    public Speaker Speaker { get; set; }
    public Guid SpeakerId { get; set; }
}
